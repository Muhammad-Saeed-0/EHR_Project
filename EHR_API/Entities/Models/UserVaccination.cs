﻿using EHR_API.Entities.Models.UsersData;
using Microsoft.AspNetCore.Identity;

namespace EHR_API.Entities.Models
{
    public class UserVaccination
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Instruction { get; set; }
        public string RegistrationDataId { get; set; }
        public int VisitId { get; set; }
        public string VaccinationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

       
        public RegistrationData RegistrationData { get; set; }
        public Vaccination Vaccination { get; set; }
        public Visit Visit { get; set; }
    }
}