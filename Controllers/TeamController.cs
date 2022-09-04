using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_epl.Dtos.Team;
using dotnet_epl.Models;
using dotnet_epl.Services.TeamService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_epl.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetTeamDto>>>> Get()
        {
            return Ok(await _teamService.Get());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetTeamDto>>> GetWithId(int id)
        {
            return Ok(await _teamService.GetWithId(id));
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetTeamDto>>> Create(CreateTeamDto newTeam)
        {
            return Ok(await _teamService.Create(newTeam));
        }
        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<GetTeamDto>>> Delete(int id)
        {
            return Ok(await _teamService.Delete(id));
        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetTeamDto>>> Update(UpdateTeamDto uptadedTeam)
        {
            return Ok(await _teamService.Update(uptadedTeam));
        }
        [HttpGet("season/random")]
        public async Task<ActionResult<ServiceResponse<List<GetSeasonTeamDto>>>> GetSeasonRandom()
        {
            return Ok(await _teamService.GetSeasonRandom());
        }
        [HttpGet("season/withvalues")]
        public async Task<ActionResult<ServiceResponse<List<GetSeasonTeamDto>>>> GetSeasonWithValues()
        {
            return Ok(await _teamService.GetSeasonWithValues());
        }

    }
}