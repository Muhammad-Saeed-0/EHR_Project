﻿using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.AdmitProgressNoteDTOs
{
    public class AdmitProgressNoteUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile File { get; set; }
        [Required]
        public string MedicalTeamId { get; set; }

        [Required]
        public int SurgeryId { get; set; }
    }
}
