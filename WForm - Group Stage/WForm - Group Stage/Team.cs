using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WForm___Group_Stage
{
    class Team
    {
        private static int winMod = 3;  //1 win = how many points? | winMod = win point modifier
        private static int drawMod = 1;
        private static int loseMod = 0;
        public static int teamAmount = 0;

        public string Name { get; set; }
        public int MatchPlayed { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }
        public int ScoredFor { get; set; }
        public int ScoredAgainst { get; set; }
        public int ScoreDiff { get; set; }
        public int Points { get; set; }


        #region Constructor
        /// <summary>
        /// Create a team
        /// </summary>
        /// <param name="_name">Team name</param>
        public Team(string _name)
        {
            Name = _name;
            MatchPlayed = 0;
            Win = 0;
            Draw = 0;
            Lose = 0;
            ScoredFor = 0;
            ScoredAgainst = 0;
            ScoreDiff = 0;
            Points = 0;
            teamAmount += 1;
        }
        #endregion

        #region Input Score and Calculate Result
        /// <summary>
        /// Input the score into database, and calculate the result. And insert it to the team stats
        /// </summary>
        /// <param name="_scoredFor">Score produced by this team</param>
        /// <param name="_scoredAgainst">Score conceded by this team</param>
        public void MatchScoreInput(int _scoredFor, int _scoredAgainst)
        {
            MatchPlayed += 1;
            ScoredFor += _scoredFor;
            ScoredAgainst += _scoredAgainst;
            ScoreDiffCalc();

            if (_scoredFor > _scoredAgainst)
                Win += 1;
            else if (_scoredFor == _scoredAgainst)
                Draw += 1;
            else
                Lose += 1;

            PointCalc();
        }
        #endregion

        #region Calculate Score Diff
        /// <summary>
        /// Calculate the score differences
        /// </summary>
        private void ScoreDiffCalc()
        {
            ScoreDiff = ScoredFor - ScoredAgainst;
        }
        #endregion

        #region Calculate Point
        /// <summary>
        /// Calculate the point
        /// </summary>
        private void PointCalc()
        {
            Points = (Win * winMod) + (Draw * drawMod) + (Lose * loseMod);
        }
        #endregion
    }
}
