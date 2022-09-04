using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_epl.Data;
using dotnet_epl.Dtos.Team;
using dotnet_epl.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_epl.Services.TeamService
{
  public class TeamService : ITeamService
  {
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public TeamService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<ServiceResponse<List<GetTeamDto>>> Get()
    {
      var respone = new ServiceResponse<List<GetTeamDto>>();
      var teams = await _context.Teams.ToListAsync();
      respone.Data = teams.Select(t => _mapper.Map<GetTeamDto>(t)).ToList();
      return respone;
    }

    public async Task<ServiceResponse<List<GetSeasonTeamDto>>> GetSeasonRandom()
    {
      var response = new ServiceResponse<List<GetSeasonTeamDto>>();
      var teams = await _context.Teams.ToListAsync();
      
      for (int i = 0; i < 20; i++)
      {
        for (int j = 0; j < 20; j++)
        {
            if (i != j)
            {
                int gameResult = new Random().Next(3);
                if (gameResult == 1)
                {
                    teams[i].Points += 3;
                    teams[i].Wins++;
                    teams[j].Losses++;
                }              
                else if (gameResult == 2)
                {
                    teams[j].Points += 3;
                    teams[j].Wins++;
                    teams[i].Losses++;
                }                  
                else
                 {
                    teams[i].Points++;
                    teams[j].Points++;
                    teams[i].Draws++;
                    teams[j].Draws++;
                 }
            }        
        }
      }

      response.Data = teams.Select(t => _mapper.Map<GetSeasonTeamDto>(t)).OrderByDescending(t => t.Points).ToList();
      return response;
    }

    public async Task<ServiceResponse<List<GetSeasonTeamDto>>> GetSeasonWithValues()
    {
      var response = new ServiceResponse<List<GetSeasonTeamDto>>();
      var teams = await _context.Teams.ToListAsync();
      
      for (int i = 0; i < 20; i++)
      {
        for (int j = 0; j < 20; j++)
        {
            if (i != j)
            {
                int gameResult = 3; // draw
                int i_score = 0;
                int j_score = 0;
                for (int k = 0; k < 5; k++)
                {
                  int attacker = teams[i].AttackValue + new Random().Next(10);
                  int defender = teams[j].DefenceValue + new Random().Next(5);
                  if (attacker > defender)
                      i_score++;
                }
                for (int k = 0; k < 5; k++)
                {
                  int attacker = teams[j].AttackValue + new Random().Next(10);
                  int defender = teams[i].DefenceValue + new Random().Next(5);
                  if (attacker > defender)
                      j_score++;
                }
                if (i_score > j_score) 
                  gameResult = 1;
                else if (i_score < j_score)
                  gameResult = 2;
                if (gameResult == 1)
                {
                    teams[i].Points += 3;
                    teams[i].Wins++;
                    teams[j].Losses++;
                }              
                else if (gameResult == 2)
                {
                    teams[j].Points += 3;
                    teams[j].Wins++;
                    teams[i].Losses++;
                }                  
                else
                 {
                    teams[i].Points++;
                    teams[j].Points++;
                    teams[i].Draws++;
                    teams[j].Draws++;
                 }
            }        
        }
      }

      response.Data = teams.Select(t => _mapper.Map<GetSeasonTeamDto>(t)).OrderByDescending(t => t.Points).ToList();
      return response;
    }
  }
}