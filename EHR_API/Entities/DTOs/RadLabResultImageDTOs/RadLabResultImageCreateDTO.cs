﻿using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.RadLabResultImageDTOs
{
    public class RadLabResultImageCreateDTO
    {
        //    [Required]
        //    public int RadLabResultId { get; set; }
        [Required]
        public IFormFile Image { get; set; }
    }
}