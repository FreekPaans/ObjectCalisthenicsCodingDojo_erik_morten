namespace TennisMatchCodingDojo
{
    public class TennisMatch
    {
        private readonly ScoreBoard _scoreBoard;

        public TennisMatch()
        {
            _scoreBoard = new ScoreBoard();
        }

        public void ScorePuntVoor(Speler speler)
        {
            _scoreBoard.Increase(speler);
        }

        public string BerekenScore()
        {
            return _scoreBoard.ToString();
        }
    }
}
