using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_epl.Dtos.Team
{
    public class CreateTeamDto
    {
        public string Name { get; set; } = string.Empty;
        public int AttackValue { get; set; } = 1;
        public int DefenceValue { get; set; } = 1;
    }
}