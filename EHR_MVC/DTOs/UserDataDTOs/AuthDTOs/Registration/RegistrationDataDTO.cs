﻿using EHR_MVC.DTOs.UserDataDTOs.MedicalDataDTOS;
using EHR_MVC.DTOs.UserDataDTOs.MedicalTeamDTOs;
using EHR_MVC.DTOs.UserDataDTOs.PersonalDataDTOs;
using System.ComponentModel;
using EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS;

namespace EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class RegistrationDataDTO
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Updated at")]
        public DateTime UpdateddAt { get; set; }

        public IEnumerable<string> Roles { get; set; }
        public PersonalDataDTO PersonalData { get; set; }
        public UserInsuranceDTO UserInsurance { get; set; }
        public MedicalDataDTO MedicalData { get; set; }
        public MedicalTeamDTO MedicalTeam { get; set; }
    }
}
