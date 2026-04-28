using PokerGame.Systems.Profiling;

namespace PokerGame.Systems.Matchmaking
{
    public class MatchmakingEngine
    {
        public MatchResult EvaluateMatch(PlayerProfile p1, PlayerProfile p2)
        {
            float aggressionGap = System.Math.Abs(
                p1.AggressionScore - p2.AggressionScore
            );

            bool fairMatch = aggressionGap <= 0.4f;

            string reason = fairMatch
                ? "Balanced matchup"
                : "High aggression mismatch";

            return new MatchResult
            {
                Player1 = p1.PlayerId,
                Player2 = p2.PlayerId,
                IsFairMatch = fairMatch,
                Reason = reason
            };
        }
    }
}
