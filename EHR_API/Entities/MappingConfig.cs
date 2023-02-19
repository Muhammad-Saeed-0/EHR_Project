﻿using AutoMapper;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.DTOs.UserDataDTOs.UserRolesDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using Microsoft.AspNetCore.Identity;

namespace EHR_API.Entities
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Governorate, GovernorateDTO>().ReverseMap();
            CreateMap<Governorate, GovernorateDTOForOthers>().ReverseMap();
            CreateMap<Governorate, GovernorateCreateDTO>().ReverseMap();
            CreateMap<Governorate, GovernorateUpdateDTO>().ReverseMap();

            CreateMap<HealthFacility, HealthFacilityDTO>().ReverseMap();
            CreateMap<HealthFacility, HealthFacilityDTOForOthers>().ReverseMap();
            CreateMap<HealthFacility, HealthFacilityCreateDTO>().ReverseMap();
            CreateMap<HealthFacility, HealthFacilityUpdateDTO>().ReverseMap();

            CreateMap<RegistrationData, RegistrationDataCreateDTO>().ReverseMap();
            CreateMap<RegistrationData, RegistrationDataUpdateDTO>().ReverseMap();
            CreateMap<RegistrationDataDTO, RegistrationDataUpdateDTO>().ReverseMap();
            CreateMap<RegistrationData, RegistrationDataDTO>().ReverseMap();
            CreateMap<RegistrationData, RegistrationDataDTOForOthers>().ReverseMap();

            CreateMap<RegistrationData, LoginResponseDTO>().ReverseMap();
            CreateMap<RegistrationData, LoginResponseaDataDTO>().ReverseMap();

            CreateMap<PersonalData, PersonalDataCreateDTO>().ReverseMap();
            CreateMap<PersonalData, PersonalDataUpdateDTO>().ReverseMap();
            CreateMap<PersonalData, PersonalDataDTO>().ReverseMap();
            CreateMap<PersonalData, PersonalDataDTOForOthers>().ReverseMap();
            
            CreateMap<Patient, PatientCreateDTO>().ReverseMap();
            CreateMap<Patient, PatientUpdateDTO>().ReverseMap();
            CreateMap<Patient, PatientDTO>().ReverseMap();
            CreateMap<Patient, PatientDTOForOthers>().ReverseMap();

            CreateMap<MedicalTeam, MedicalTeamCreateDTO>().ReverseMap();
            CreateMap<MedicalTeam, MedicalTeamUpdateDTO>().ReverseMap();
            CreateMap<MedicalTeam, MedicalTeamDTO>().ReverseMap();
            CreateMap<MedicalTeam, MedicalTeamDTOForOthers>().ReverseMap();

            CreateMap<MedicalData, MedicalDataCreateDTO>().ReverseMap();
            CreateMap<MedicalData, MedicalDataUpdateDTO>().ReverseMap();
            CreateMap<MedicalData, MedicalDataDTO>().ReverseMap();
            CreateMap<MedicalData, MedicalDataDTOForOthers>().ReverseMap();

            CreateMap<InsuranceData, InsuranceDataCreateDTO>().ReverseMap();
            CreateMap<InsuranceData, InsuranceDataUpdateDTO>().ReverseMap();
            CreateMap<InsuranceData, InsuranceDataDTO>().ReverseMap();
            CreateMap<InsuranceData, InsuranceDataDTOForOthers>().ReverseMap();

            CreateMap<UserInsurance, UserInsuranceCreateDTO>().ReverseMap();
            CreateMap<UserInsurance, UserInsurancesCreateDTO>().ReverseMap();
            CreateMap<UserInsurance, UserInsuranceUpdateDTO>().ReverseMap();
            CreateMap<UserInsurance, UserInsuranceDTO>().ReverseMap();
            CreateMap<UserInsurance, UserInsuranceDTOForOthers>().ReverseMap();

            CreateMap<IdentityRole, RolesDTO>().ReverseMap();
        }
    }
}
