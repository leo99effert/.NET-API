using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_epl.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_epl.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData
            (
                new Team {Id = 1, Name = "Arsenal", AttackValue = 4, DefenceValue = 3},
                new Team {Id = 2, Name = "Aston Villa", AttackValue = 1, DefenceValue = 2},
                new Team {Id = 3, Name = "Bournemouth", AttackValue = 2, DefenceValue = 1},
                new Team {Id = 4, Name = "Brentford", AttackValue = 2, DefenceValue = 1},
                new Team {Id = 5, Name = "Brighton", AttackValue = 1, DefenceValue = 3},
                new Team {Id = 6, Name = "Chelsea", AttackValue = 4, DefenceValue = 5},
                new Team {Id = 7, Name = "Crystal Palace", AttackValue = 3, DefenceValue = 2},
                new Team {Id = 8, Name = "Everton", AttackValue = 4, DefenceValue = 2},
                new Team {Id = 9, Name = "Fulham", AttackValue = 2, DefenceValue = 1},
                new Team {Id = 10, Name = "Leeds", AttackValue = 3, DefenceValue = 2},
                new Team {Id = 11, Name = "Leicester", AttackValue = 2, DefenceValue = 3},
                new Team {Id = 12, Name = "Liverpool", AttackValue = 5, DefenceValue = 4},
                new Team {Id = 13, Name = "Man City", AttackValue = 4, DefenceValue = 5},
                new Team {Id = 14, Name = "Man United", AttackValue = 5, DefenceValue = 3},
                new Team {Id = 15, Name = "Newcastle", AttackValue = 3, DefenceValue = 2},
                new Team {Id = 16, Name = "Nottingham", AttackValue = 2, DefenceValue = 1},
                new Team {Id = 17, Name = "Southampton", AttackValue = 1, DefenceValue = 2},
                new Team {Id = 18, Name = "Tottenham", AttackValue = 5, DefenceValue = 4},
                new Team {Id = 19, Name = "West Ham", AttackValue = 3, DefenceValue = 1},
                new Team {Id = 20, Name = "Wolves", AttackValue = 4, DefenceValue = 1}
            );
        }
        
        public DbSet<Team> Teams => Set<Team>();
    }
}