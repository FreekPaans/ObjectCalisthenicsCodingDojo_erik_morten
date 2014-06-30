using System;
using System.Collections.Generic;

namespace TennisMatchCodingDojo
{

    public class SetScoreBoard
    {
        private readonly Dictionary<Speler, SetScore> _setScores;
 
        public SetScoreBoard()
        {
            _setScores = new Dictionary<Speler, SetScore>();
            _setScores.Add(Speler.Een, SetScore.Zero);
            _setScores.Add(Speler.Twee, SetScore.Zero);
        }

        public void Increase(Speler speler)
        {
            _setScores[speler] += 1;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", (int)_setScores[Speler.Een], (int)_setScores[Speler.Twee]);
        }
    }

    public enum SetScore
    {
        Zero, One, Two, Three, Four, Five, Six, Seven
    }
}
