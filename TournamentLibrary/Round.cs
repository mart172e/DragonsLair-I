using System.Collections.Generic;

namespace TournamentLib
{
    public class Round
    {
        private List<Match> matches = new List<Match>();
        
        public void AddMatch(Match m)
        {
            matches.Add(m);
        }

        public Match GetMatch(string teamName1, string teamName2)
        
        //{
        //    bool matchesFinished = true;
        //    int numberOfRounds = currentTournament.GetNumberOfRounds();
        //    for (int round = 0; round < numberOfRounds; round++)
        //    {
        //        Round currentRound = currentTournament.GetRound(round);
        //        if (currentRound.IsMatchesFinished() == false)
        //            matchesFinished = false;
        //    }
            return null;
        }

        public bool IsMatchesFinished()
        {
            // TODO: Implement this method
            return false;
        }

        public List<Team> GetWinningTeams()
        {
            // TODO: Implement this method
            return null;
        }

        public List<Team> GetLosingTeams()
        {
            // TODO: Implement this method
            return null;
        }
    }
}
