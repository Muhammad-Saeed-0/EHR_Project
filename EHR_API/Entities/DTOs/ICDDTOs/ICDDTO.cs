﻿namespace EHR_API.Entities.DTOs.ICDDTOs
{
    public class ICDDTO
    {
        public string Code { get; set; }
        public string DiagnosisName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
