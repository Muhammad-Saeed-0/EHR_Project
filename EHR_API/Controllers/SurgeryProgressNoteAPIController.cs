﻿using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/SurgeryProgressNoteAPI")]
    [ApiController]
    public class SurgeryProgressNoteAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public SurgeryProgressNoteAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        //[Authorize]
        [HttpGet("GetSurgeryProgressNotes")]
        public async Task<ActionResult<APIResponse>> GetSurgeryProgressNotes(int surgeryId)
        {
            try
            {
                if (surgeryId == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._surgeryProgressNote.GetAllAsync(
                    expression: g => g.SurgeryId == surgeryId);
                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {surgeryId} "));
                }

                _response.Result = _mapper.Map<List<SurgeryProgressNoteDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("GetSurgeryProgressNote")]
        public async Task<ActionResult<APIResponse>> GetSurgeryProgressNote(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is Null"));
                }

                var entity = await _db._surgeryProgressNote.GetAsync(expression: g => g.Id == id);
                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
                }

                _response.Result = _mapper.Map<SurgeryProgressNoteDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpPost("CreateSurgeryProgressNote")]
        public async Task<ActionResult<APIResponse>> CreateSurgeryProgressNote([FromForm] SurgeryProgressNoteCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._surgeryProgressNote.GetAsync(expression: e => e.Id == entityCreateDTO.Id) == null)
                {
                    return BadRequest(APIResponses.BadRequest("ID is not exists"));
                }

                if (await _db._surgery.GetAsync(expression: e => e.Id == entityCreateDTO.SurgeryId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("SurgeryId is not exists"));
                }

                if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityCreateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Medical Member is not exists"));
                }


                var entity = _mapper.Map<SurgeryProgressNote>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;

                await _db._surgeryProgressNote.CreateAsync(entity);

                _response.Result = _mapper.Map<SurgeryProgressNoteDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpDelete("DeleteSurgeryProgressNote")]
        public async Task<ActionResult<APIResponse>> DeleteSurgeryProgressNote(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is Null"));
                }

                var removedEntity = await _db._surgeryProgressNote.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
                }

                await _db._surgeryProgressNote.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpPut("UpdateSurgeryProgressNote")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateSurgeryProgressNote(int id, [FromForm] SurgeryProgressNoteUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (entityUpdateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (id != entityUpdateDTO.Id)
                {
                    return BadRequest(APIResponses.BadRequest("Id is not equal to the Id of the object"));
                }

                var oldOne = await _db._surgeryProgressNote.GetAsync(expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
                }

                var entity = _mapper.Map<SurgeryProgressNote>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;

                await _db._surgeryProgressNote.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<SurgeryProgressNoteDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);

            }
        }
    }
}
