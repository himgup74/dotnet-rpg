using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;
using dotnet_rpg.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController : ControllerBase
    {

       private readonly ICharacterService _CharacterService;
        public CharacterController(ICharacterService CharacterService)
        {
            _CharacterService =CharacterService;
        }

        [Route("GetAll")]
        public IActionResult Get()
        {

           return Ok(_CharacterService.Get());
        }

         public IActionResult GetSingle()
        {

           return Ok(_CharacterService.GetSingle());
        }
        
        [HttpGet("GetById/{id}")]
        public IActionResult GetId(int id)
        {

           return Ok(_CharacterService.GetId(id));
        }


    }
}