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
                if (teams.Count >= 2)
                {
                    scramble = teams;
                    Round newRound = new Round();

                    if (numberOfRounds % 2 != 0)
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
                        do
                        {
                            newFreeRider = scramble[x++];
                        }
                        while (newFreeRider == oldFreeRider);

                        newRound.SetFreeRider(newFreeRider);
                        teams.Remove(newFreeRider);
                    }
                    for (int i = 0; i < scramble.Count; i = i + 2)
                    {
                        Match match = new Match();
                        match.FirstOpponent = scramble[i];
                        match.SecondOpponent = scramble[i + 1]; //test virker ikke fix bounds out
                        newRound.AddMatch(match);
                    }
                    t.AddRound(newRound);
                    // Vis kampe i ny runde (se wireframe) Sprint 2 dag 1
                }
                else
                {
                    throw new Exception("Tournament is finished");
                }
            }
            else
            {
                throw new Exception("Round not finished");
            }
        }

        public TournamentRepo GetTournamentRepository()
        {
            return tournamentRepository;
        }

        /*public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
        }*/
        private void SaveMatch()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Write("Angiv runde: ");
            int round = int.Parse(Console.ReadLine());
            Console.Write("Angiv vinderhold: ");
            string winner = Console.ReadLine();
            Console.Clear();
            control.SaveMatch(tournamentName, round, winner);
        }

    }
}
