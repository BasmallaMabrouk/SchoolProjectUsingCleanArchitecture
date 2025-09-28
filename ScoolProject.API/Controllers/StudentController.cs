﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;

namespace SchoolProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("/Student/List")]
        public async Task<IActionResult> GetStudentList()
        {
            var respons = await _mediator.Send(new GetStudendListQuery());
            return Ok(respons);
                
        }
    }
}
