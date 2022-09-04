using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_epl.Dtos.Team;
using dotnet_epl.Models;

namespace dotnet_epl.Services.TeamService
{
    public interface ITeamService
    {
        Task <ServiceResponse<List<GetTeamDto>>> Get();
        Task <ServiceResponse<GetTeamDto>> GetWithId(int id);
        Task <ServiceResponse<GetTeamDto>> Create(CreateTeamDto newTeam);
        Task <ServiceResponse<GetTeamDto>>  Delete(int id);
        Task <ServiceResponse<GetTeamDto>> Update(UpdateTeamDto updatedTeam);
        Task <ServiceResponse<List<GetSeasonTeamDto>>> GetSeasonRandom();
        Task <ServiceResponse<List<GetSeasonTeamDto>>> GetSeasonWithValues();
    }
}