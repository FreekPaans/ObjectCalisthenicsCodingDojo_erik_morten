using System;

namespace TennisMatchCodingDojo
{
    public class ScoreBoard
    {
        private readonly GameScoreBoard _gameScore;
        private readonly SetScoreBoard _setScore;

        public ScoreBoard()
        {
            _setScore = new SetScoreBoard();
            _gameScore = new GameScoreBoard();
        }

        public void Increase(Speler speler)
        {
            _gameScore.Increase(speler, _setScore);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", _setScore, _gameScore);
        }
    }
}
