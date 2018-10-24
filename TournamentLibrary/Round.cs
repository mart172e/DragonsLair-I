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
        {
            /* TODO: Implement this method
            for (int i = 0; i < length; i++)
            {
            }
            if
            teamName1 = firstopponent
            */
            return null;
        }

        public bool IsMatchesFinished()
        {
            /* 
             * TODO: Implement this method
             * bool
             *if matches.(i) get winner
             */
            return false;
        }

        public List<Team> GetWinningTeams()
        {
            /* TODO: Implement this method
            GetWinningTeams()
            foreach
            */
            return null;
        }

        public List<Team> GetLosingTeams()
        {
            /* TODO: Implement this method
            GetWinningTeams()
            foreach
            */
            return null;
        }
    }
}
