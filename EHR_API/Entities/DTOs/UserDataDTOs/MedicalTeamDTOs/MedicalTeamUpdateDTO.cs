﻿using EHR_API.Entities.DTOs.MedicalFacilityTeamDTOs;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.MedicalTeamDTOs
{
    public class MedicalTeamUpdateDTO
    {
        [Required] 
        public string Id { get; set; }
        [Required]
        public string MedicalSpecialization { get; set; }
        [Required]
        public string Degree { get; set; }

        public MedicalFacilityTeamUpdateDTO MedicalFacilityTeam { get; set; }
    }
}
