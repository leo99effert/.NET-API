using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_epl.Dtos.Team
{
    public class GetSeasonTeamDto
    {
        public string Name { get; set; } = string.Empty;
        public int Points { get; set; } = 0;
        public int Wins { get; set; } = 0;
        public int Draws { get; set; } = 0;
        public int Losses { get; set; } = 0;
    }
}