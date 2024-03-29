﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Extensions;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class UsersConfiguration : IEntityTypeConfiguration<RegistrationData>
    {
        public void Configure(EntityTypeBuilder<RegistrationData> builder)
        {
            List<RegistrationData> registrations = new();
            var user = new RegistrationData
            {
                Id = "12345678912341",
                Nationality = "Egyptian",
                FullName = "Ahmed Mohamed Kamal",
                UserName = "@Kamal123",
                NormalizedUserName = "@KAMAL123",
                Email = "k@gmail.com",
                NormalizedEmail = "K@GMAIL.COM",
                PhoneNumber = "01234567890",
                EmailConfirmed = true,
            };

            PasswordHasher<string> pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912342",
                Nationality = "Egyptian",
                FullName = "Ahmed Mohamed Ahmed",
                UserName = "@Ahmed123",
                NormalizedUserName = "@AHMED123",
                Email = "M@gmail.com",
                NormalizedEmail = "M@GMAIL.COM",
                PhoneNumber = "",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);
            
            user = new RegistrationData
            {
                Id = "12345678912343",
                Nationality = "Egyptian",
                FullName = "Ahmed Mohamed Mohamed",
                UserName = "@Muhammad123",
                NormalizedUserName = "@MUHAMMAD123",
                Email = "muha75375@gmail.com",
                NormalizedEmail = "MUHA75375@GMAIL.COM",
                PhoneNumber = "01234567899",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);
             
            user = new RegistrationData
            {
                Id = "12345678912344",
                Nationality = "Egyptian",
                FullName = "Ahmed Mohammed Ali",
                UserName = "@Ali123",
                NormalizedUserName = "@ALI123",
                Email = "Al@gmail.com",
                NormalizedEmail = "AL@GMAIL.COM",
                PhoneNumber = "01234567890",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);
             
            user = new RegistrationData
            {
                Id = "12345678912346",
                Nationality = "Egyptian",
                FullName = "Ahmed Khater Ali",
                UserName = "@Khater123",
                NormalizedUserName = "@KHATER123",
                Email = "Ka@gmail.com",
                NormalizedEmail = "KA@GMAIL.COM",
                PhoneNumber = "",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912348",
                Nationality = "Egyptian",
                FullName = "Manal Khater Ahmed",
                UserName = "@Manal2123",
                NormalizedUserName = "@MANAL2123",
                Email = "Ma2@gmail.com",
                NormalizedEmail = "MA2@GMAIL.COM",
                PhoneNumber = "",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912349",
                Nationality = "Egyptian",
                FullName = "Khater Ahmed",
                UserName = "@Khater2123",
                NormalizedUserName = "@KHATER2123",
                Email = "Ka2@gmail.com",
                NormalizedEmail = "KA2@GMAIL.COM",
                PhoneNumber = "",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912350",
                Nationality = "Egyptian",
                FullName = "Ali Khater Ahmed",
                UserName = "@AlI2123",
                NormalizedUserName = "@TEST2123",
                Email = "TE@gmail.com",
                NormalizedEmail = "TE@GMAIL.COM",
                PhoneNumber = "",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912351",
                Nationality = "Egyptian",
                FullName = "Ahmed Fawzy Mohamed",
                UserName = "@Fawzy123",
                NormalizedUserName = "@FAWZY123",
                Email = "Fa@gmail.com",
                NormalizedEmail = "FA@GMAIL.COM",
                PhoneNumber = "",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912352",
                Nationality = "Egyptian",
                FullName = "Ali Fawzy Muhammad",
                UserName = "@AliFawzy123",
                NormalizedUserName = "@ALIFAWZY123",
                Email = "AlFa@gmail.com",
                NormalizedEmail = "ALFA@GMAIL.COM",
                PhoneNumber = "",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            user = new RegistrationData
            {
                Id = "12345678912353",
                Nationality = "Egyptian",
                FullName = "Ali Fawzy Ahmed",
                UserName = "@AFawzy123",
                NormalizedUserName = "@AFAWZY123",
                Email = "AFa@gmail.com",
                NormalizedEmail = "AFA@GMAIL.COM",
                PhoneNumber = "",
                EmailConfirmed = true,
            };

            pw = new PasswordHasher<string>();
            user.PasswordHash = pw.HashPassword(user.UserName, "123@Tt");
            registrations.Add(user);

            builder.HasData(registrations);
        }
    }
}
