namespace PokerGame.Systems.Profiling
{
    public class PlayerProfile
    {
        public string PlayerId;
        public float AggressionScore;
        public float FoldRate;
        public string PlayStyle;

        public override string ToString()
        {
            return $"Player: {PlayerId} | Aggression: {AggressionScore} | FoldRate: {FoldRate} | Style: {PlayStyle}";
        }
    }
}
