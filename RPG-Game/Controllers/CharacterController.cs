using Microsoft.AspNetCore.Mvc;
using RPG_Game.Services.CharacterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.CoreEntities
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;   
        public CharacterController( ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        [Route("Getall")]
        public async Task<ActionResult<List<Character>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharatcter(Character newCharacter)
        {

            return Ok(await _characterService.CreateCharacter(newCharacter));
        }
    }
}
