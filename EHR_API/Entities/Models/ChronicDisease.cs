﻿using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class ChronicDisease
    {
        [Key]
        public int Id { get; set; }
        public string ICDCode { get; set; }
        public string RegistrationDataId { get; set; }      
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
 
        public ICD ICD { get; set; }
        public RegistrationData RegistrationData { get; set; }
        public string MedicalTeamId { get; set; }
        public MedicalTeam MedicalTeam { get; set; }
        public ICollection<ChronicDiseaseDrug> ChronicDiseaseDrugs { get; set; }
    }
}
