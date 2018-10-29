using System;
using System.Collections.Generic;
using System.Linq;
using TournamentLib;

namespace DragonsLair
{
    public class Controller
    {
        private TournamentRepo tournamentRepository = new TournamentRepo();
       
        public void ShowScore(string tournamentName)
        {
            Console.WriteLine("Implement this method!");
        }

        public void ScheduleNewRound(string tournamentName, bool printNewMatches = true)
        {
            
            Tournament t = tournamentRepository.GetTournament(tournamentName);
            int numberOfRounds = t.GetNumberOfRounds();

            Round lastRound;
            bool isRoundFinished;
            List<Team> teams;
            Team oldFreeRider;
            Team newFreeRider;
            List<Team> scramble;

            if (numberOfRounds == 0)
            {
                lastRound = null;
                isRoundFinished = true;
            }
            else
            {
                lastRound = t.GetRound(numberOfRounds - 1);
                isRoundFinished = lastRound.IsMatchesFinished();
            }
            if (isRoundFinished)
            {
                if (lastRound == null)
                {
                    teams = t.GetTeams();
                }
                else
                {
                    teams = lastRound.GetWinningTeams();
                    if(lastRound.FreeRider != null )
                    {
                        teams.Add(lastRound.FreeRider);
                    }
                }
                if (teams.Count>=2)
                {
                    Round newRound = new Round();
                    
                    if (numberOfRounds%2 != 0)
                    {
                        if (numberOfRounds > 0)
                        {
                            oldFreeRider = lastRound.GetFreeRider();
                        }
                        else
                        {
                            oldFreeRider = null;
                        }

                        int x = 0;
                        scramble = teams;
                        do
                        {
                            newFreeRider = scramble[x++];
                        }
                        while (newFreeRider == oldFreeRider);
                    
                        newRound.SetFreeRider(newFreeRider); 

                        teams.Remove(newFreeRider);
                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }
        public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
        }
    }
}
