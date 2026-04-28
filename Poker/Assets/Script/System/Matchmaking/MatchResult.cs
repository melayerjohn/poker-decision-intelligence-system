namespace PokerGame.Systems.Matchmaking
{
    public class MatchResult
    {
        public string Player1;
        public string Player2;
        public bool IsFairMatch;
        public string Reason;

        public override string ToString()
        {
            return $"{Player1} vs {Player2} | Fair Match: {IsFairMatch} | Reason: {Reason}";
        }
    }
}