namespace PokerGame.Systems.DecisionLogging
{
    public class DecisionLog
    {
        public string PlayerId;
        public PlayerActionType Action;
        public string Stage;
        public float HandStrength;
        public int PotSize;

        public override string ToString()
        {
            return $"Player: {PlayerId} | Action: {Action} | Stage: {Stage} | HandStrength: {HandStrength} | Pot: {PotSize}";
        }
    }
}