﻿namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login
{
    public class LoginResponseDTO
    {
        public LoginResponseaDataDTO User { get; set; }
        public ICollection<string> Roles { get; init; }
        public string Token { get; set; }
    }
}
