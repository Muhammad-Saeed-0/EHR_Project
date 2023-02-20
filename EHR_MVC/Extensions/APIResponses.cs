﻿using EHR_MVC.Entities;
using EHR_MVC.Models;
using System.Net;

namespace EHR_MVC.Extensions
{
    public static class APIResponses
    {
        //public static APIResponse BadRequest(string error)
        //{
        //    APIResponse _response = new();
        //    _response.StatusCode = HttpStatusCode.BadRequest;
        //    _response.IsSuccess = false;
        //    _response.Result = "There are no result";
        //    _response.Errors = new List<string>() { error };
        //    return _response;
        //}

        //public static APIResponse NotFound(string error)
        //{
        //    APIResponse _response = new();
        //    _response.StatusCode = HttpStatusCode.BadRequest;
        //    _response.IsSuccess = false;
        //    _response.Result = "There are no result";
        //    _response.Errors = new List<string>() { error };
        //    return _response;
        //}

        public static APIResponse InternalServerError(Exception ex)
        {
            APIResponse _response = new();
            _response.IsSuccess = false;
            _response.StatusCode = HttpStatusCode.InternalServerError;
            _response.Errors = new List<string> { ex.GetBaseException().ToString() };
            return _response;
        }
        //public static APIResponse Unauthorized()
        //{
        //    APIResponse _response = new();
        //    _response.Errors = new() { "The Email and Password are wrong" };
        //    _response.IsSuccess = false;
        //    _response.StatusCode = HttpStatusCode.Unauthorized;
        //    return _response;
        //}

        //public static UserDTOForOthers User(RegistrationData registrationData)
        //{
        //    UserDTOForOthers user = new();
        //    user.Id = registrationData.Id;
        //    user.Name = registrationData.FullName;
        //    if (registrationData.PersonalData != null)
        //    {
        //        user.UserImageUrl = registrationData.PersonalData.UserImageUrl;
        //    }
        //    if (registrationData.MedicalTeam != null)
        //    {
        //        user.Specialization = registrationData.MedicalTeam.MedicalSpecialization;
        //    }

        //    return user;
        //}   
    }
}
