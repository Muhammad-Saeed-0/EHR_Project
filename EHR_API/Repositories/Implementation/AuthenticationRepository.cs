﻿using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace EHR_API.Repositories.Implementation
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly IMapper _mapper;
        private readonly UserManager<RegistrationData> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _emailSender;
        private RegistrationData _user;

        public AuthenticationRepository(IMapper mapper, UserManager<RegistrationData> userManager, IConfiguration configuration, IEmailSender emailSender)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
            _emailSender = emailSender;
        }

        private async Task Code(string email, string code)
        {
            var message = new Message(new string[] { email }, "Confirm Email", code);

            await _emailSender.SendEmailAsync(message);
        }

        public async Task<IdentityResult> RegisterUser(RegistrationDataCreateDTO registrationDataDTO, bool flag)
        {
            var user = _mapper.Map<RegistrationData>(registrationDataDTO);
            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;


            var result = await _userManager.CreateAsync(user, registrationDataDTO.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRolesAsync(user, new List<string>() { registrationDataDTO.Role });

                if (flag)
                {
                    user.ConfirmEmailCode = ServiceExtensions.RandomCode();
                    await Code(registrationDataDTO.Email, user.ConfirmEmailCode);
                }
                else
                {
                    await _userManager.ConfirmEmailAsync(user,
                        await _userManager.GenerateEmailConfirmationTokenAsync(user));
                }
            }

            return result;
        }

        public async Task ReSendEmailConfirmCode(string email)
        {
            _user = await _userManager.FindByEmailAsync(email);
            await Code(email, _user.ConfirmEmailCode);
        }

        public async Task<RegistrationData> ConfirmEmail(string email, string code)
        {
            _user = await _userManager.FindByEmailAsync(email);

            if (_user != null && code == _user.ConfirmEmailCode)
            {
                _user.EmailConfirmed = true;
                _user.ConfirmEmailCode = null;

                var result = await _userManager.UpdateAsync(_user);
                if (result.Succeeded)
                {
                    return _user;
                }
            }

            return null;
        }

        public async Task<bool> ForgotPassword(string email)
        {
            _user = await _userManager.FindByEmailAsync(email);

            if (_user != null)
            {
                _user.ForgotPasswordCode = ServiceExtensions.RandomCode();
                var result = await _userManager.UpdateAsync(_user);

                if (result.Succeeded)
                {
                    var message = new Message(new string[] { _user.Email }, "Forgot Password Code", _user.ForgotPasswordCode);

                    await _emailSender.SendEmailAsync(message);
                }

                return result.Succeeded;
            }

            return false;
        }
        public async Task<RegistrationData> NewPassword(string email, string code, string password)
        {
            _user = await _userManager.FindByEmailAsync(email);

            if (_user != null && code == _user.ForgotPasswordCode)
            {
                _user.ForgotPasswordCode = null;
                var pw = new PasswordHasher<string>();
                _user.PasswordHash = pw.HashPassword(_user.UserName, password);

                var result = await _userManager.UpdateAsync(_user);
                if (result.Succeeded)
                {
                    return _user;
                }
            }

            return null;
        }
        public async Task<RegistrationData> ValidateUser(LoginRequestDTO loginRequestDTO)
        {
            _user = await _userManager.FindByEmailAsync(loginRequestDTO.Email);
            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, loginRequestDTO.Password));

            if (!result || _user.EmailConfirmed == false)
            {
                _user = null;
            }

            return _user;
        }

        // https://www.endpointdev.com/blog/2022/06/implementing-authentication-in-asp.net-core-web-apis/
        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            var tokenValue = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return tokenValue;
        }

        //tells the JwtSecurityToken how to cryptographically sign the token.
        private SigningCredentials GetSigningCredentials()
        {
            /*
            * To generate a JWT, the server signs the header and payload with a secret key using the specified algorithm. 
            * 
            * The resulting signature is then appended to the header and payload to create the final token.

            */
            var key = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JwtSettings:Secret"));
            var secret = new SymmetricSecurityKey(key);
            //the algorithm to use to produce key.
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            /*
             * a claim is essentially a statement about the entity for which the token is generated, some data that identifies it.
             * 
             * The data that we put in here will make its way into the encoded token that our API caller eventually sees.
             */
            var claims = new List<Claim>
            {
                new Claim("User Id", _user.Id),
                new Claim("UserName", _user.UserName),
                new Claim("User Email", _user.Email),
                new Claim("Expiration Date", $"{DateTime.Now.AddDays(Convert.ToDouble(_configuration.GetSection("JwtSettings")["expires"]))}"),
            };

            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken(
                issuer: jwtSettings["validIssuer"],
                audience: jwtSettings["validAudience"],
                claims: claims,
                //the expiration date of the token
                expires: DateTime.Now.AddDays(Convert.ToDouble(jwtSettings["expires"])),
                signingCredentials: signingCredentials);

            return tokenOptions;
        }

        public async Task<List<RegistrationData>> GetAllAsync(Expression<Func<RegistrationData, bool>> expression = null, string includeProperties = null)
        {
            IQueryable<RegistrationData> entities = _userManager.Users;
            entities = expression != null ? entities.Where(expression) : entities;

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    entities = entities.Include(item);
                }
            }

            return await entities.ToListAsync();
        }

        public async Task<RegistrationData> GetAsync(Expression<Func<RegistrationData, bool>> expression, string includeProperties = null)
        {
            var entity = _userManager.Users;
            entity = expression != null ? entity.Where(expression) : entity;

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    entity = entity.Include(item);
                }
            }

            return await entity.SingleOrDefaultAsync();
        }

        public async Task<RegistrationData> UpdateAsync(RegistrationDataUpdateDTO entity)
        {
            var user = await _userManager.FindByIdAsync(entity.Id);
            user.FullName = entity.FullName;
            user.Nationality = entity.Nationality;
            user.UserName = entity.UserName;
            user.Email = entity.Email;
            user.PhoneNumber = entity.PhoneNumber;
            user.UpdatedAt = DateTime.Now;

            var pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(entity.UserName, entity.Password);

            await _userManager.UpdateAsync(user);
            return user;
        }
    }
}
