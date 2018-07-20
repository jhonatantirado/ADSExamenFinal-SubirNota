using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Estudiantes.Application;
using Estudiantes.Application.Dto;

namespace Estudiantes.API{
    public class EstudianteController : Controller{

        IEstudianteApplicationService _estudianteApplicationService;
        public EstudianteController(IEstudianteApplicationService estudianteApplicationService)
        {
            _estudianteApplicationService = estudianteApplicationService;
        }


        [Route("/api/Estudiantes/{studentType}")]
        [HttpGet]
        public IActionResult getByStudentByType(string studentType="All")
        {
            if (string.IsNullOrWhiteSpace(studentType)){
                return BadRequest("Invalid student type");
            } 

            try
            {
                return Ok(_estudianteApplicationService.getByStudentType(studentType));
            }
            catch (ArgumentException ex){
                return BadRequest("Controlled exception:" + ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }
    
}