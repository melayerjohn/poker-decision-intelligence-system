namespace PokerGame.Systems.Fairness
{
    public class SuspicionProfile
    {
        public string PlayerId;
        public float RiskScore;
        public bool IsSuspicious;

        public override string ToString()
        {
            return $"Player: {PlayerId} | RiskScore: {RiskScore} | Suspicious: {IsSuspicious}";
        }
    }
}