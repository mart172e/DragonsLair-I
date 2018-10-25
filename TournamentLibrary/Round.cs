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
            foreach (Match m in matches)
            {
                if (m.FirstOpponent.Name == teamName1 && m.SecondOpponent.Name == teamName2)
                {
                    return m;
                }
            }
            return null;
        }

        public bool IsMatchesFinished()
        {
            /* TODO: Implement this method
            bool
            */
            return false;
        }

        public List<Team> GetWinningTeams()
        {
            /* TODO: Implement this method
            GetWinningTeams()
            */
            return null;
        }

        public List<Team> GetLosingTeams()
        {
            // TODO: Implement this method
            return null;
        }
    }
}
