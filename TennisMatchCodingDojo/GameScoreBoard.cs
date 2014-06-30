using System;
using System.Collections.Generic;

namespace TennisMatchCodingDojo
{
    public class GameScoreBoard
    {
        private readonly Dictionary<Speler, GameScore> _scoreBoard;

        public GameScoreBoard()
        {
            _scoreBoard = new Dictionary<Speler, GameScore>();
            _scoreBoard.Add(Speler.Een, GameScore.Zero);
            _scoreBoard.Add(Speler.Twee, GameScore.Zero);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", 
                GameScorePrinter.Print(_scoreBoard[Speler.Een]),
                GameScorePrinter.Print(_scoreBoard[Speler.Twee]));
        }

        public void Increase(Speler speler, SetScoreBoard setScore)
        {
            var enemy = 1 - speler;
            var playerScore = _scoreBoard[speler];
            var enemyScore = _scoreBoard[enemy];

            if (playerScore == GameScore.Fourty && enemyScore < GameScore.Fourty || playerScore == GameScore.Advantage)
            {
                _scoreBoard[Speler.Een] = GameScore.Zero;
                _scoreBoard[Speler.Twee] = GameScore.Zero;
                setScore.Increase(speler);
                return;
            }

            if (enemyScore == GameScore.Advantage)
            {
                _scoreBoard[speler] = GameScore.Fourty;
                _scoreBoard[enemy] = GameScore.Fourty;
                return;
            }

            _scoreBoard[speler] += 1;
        }
    }

    public enum GameScore
    {
        Zero, Fifteen, Thirty, Fourty, Advantage
    }

    public static class GameScorePrinter
    {
        public static string Print(GameScore gameScore)
        {
            switch (gameScore)
            {
                case GameScore.Zero:
                    return "0";
                case GameScore.Fifteen:
                    return "15";
                case GameScore.Thirty:
                    return "30";
                case GameScore.Fourty:
                    return "40";
                case GameScore.Advantage:
                    return "A";
            }
            return null;
        }
    }
}
