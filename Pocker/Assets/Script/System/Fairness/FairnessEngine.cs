using System.Collections.Generic;
using System.Linq;
using PokerGame.Systems.DecisionLogging;

namespace PokerGame.Systems.Fairness
{
    public class FairnessEngine
    {
        public SuspicionProfile AnalyzePlayer(string playerId, List<DecisionLog> logs)
        {
            var playerLogs = logs.Where(x => x.PlayerId == playerId).ToList();

            int raiseCount = playerLogs.Count(x => x.Action == PlayerActionType.Raise);
            int totalGames = playerLogs.Count;

            float raiseConsistency = (float)raiseCount / totalGames;

            float riskScore = 0f;

            // suspicious if always aggressive
            if (raiseConsistency >= 0.8f)
            {
                riskScore += 0.5f;
            }

            // suspicious if all hand strengths are very high
            float avgStrength = playerLogs.Average(x => x.HandStrength);

            if (avgStrength >= 0.8f)
            {
                riskScore += 0.5f;
            }

            return new SuspicionProfile
            {
                PlayerId = playerId,
                RiskScore = riskScore,
                IsSuspicious = riskScore >= 0.5f
            };
        }
    }
}
