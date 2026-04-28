namespace PokerGame.Systems.DecisionLogging
{
    public class DecisionEngine
    {
        public PlayerActionType DecideAction(float handStrength)
        {
            if (handStrength >= 0.6f)
            {
                return PlayerActionType.Raise;
            }
            else if (handStrength >= 0.35f)
            {
                return PlayerActionType.Call;
            }
            else
            {
                return PlayerActionType.Fold;
            }
        }
    }
}