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