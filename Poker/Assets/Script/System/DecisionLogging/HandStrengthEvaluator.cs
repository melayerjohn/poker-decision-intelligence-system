using System.Collections.Generic;
using PokerGame.Models;

namespace PokerGame.Systems.DecisionLogging
{
    public class HandStrengthEvaluator
    {
        public float Evaluate(List<Card> hand)
        {
            int total = 0;

            foreach (var card in hand)
            {
                total += (int)card.Rank;
            }

            return total / 30f;
        }
    }
}
