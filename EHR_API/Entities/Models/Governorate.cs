﻿using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.Models
{
    public class Governorate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdateddAt { get; set; }

        public ICollection<HealthFacility> HealthFacilitys { get; set; }
        public ICollection<PersonalData> PersonalData { get; set; }
    }
}
