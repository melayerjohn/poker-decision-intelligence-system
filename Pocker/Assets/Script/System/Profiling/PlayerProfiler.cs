using System.Collections.Generic;
using System.Linq;
using PokerGame.Systems.DecisionLogging;

namespace PokerGame.Systems.Profiling
{
    public class PlayerProfiler
    {
        public PlayerProfile GenerateProfile(string playerId, List<DecisionLog> logs)
        {
            var playerLogs = logs.Where(x => x.PlayerId == playerId).ToList();

            int raiseCount = playerLogs.Count(x => x.Action == PlayerActionType.Raise);
            int foldCount = playerLogs.Count(x => x.Action == PlayerActionType.Fold);

            float aggressionScore = (float)raiseCount / playerLogs.Count;
            float foldRate = (float)foldCount / playerLogs.Count;

            string style = "Balanced";

            if (aggressionScore > 0.6f)
                style = "Aggressive";
            else if (foldRate >= 0.5f)
                style = "Passive";

            return new PlayerProfile
            {
                PlayerId = playerId,
                AggressionScore = aggressionScore,
                FoldRate = foldRate,
                PlayStyle = style
            };
        }
    }
}