using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_epl.Dtos.Team;
using dotnet_epl.Models;

namespace dotnet_epl
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Team, GetTeamDto>();
            CreateMap<Team, GetSeasonTeamDto>();
        }
    }
}