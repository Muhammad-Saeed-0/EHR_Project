﻿

namespace EHR_API.Entities.DTOs.ReceiveBloodDataDTOs
{
    public class ReceiveBloodDataDTO
    {
        public int Id { get; set; }
        public string BloodGroup { get; set; }
        public string ReceiveType { get; set; }
        public int ReceiveBloodId { get; set; }

    }
}