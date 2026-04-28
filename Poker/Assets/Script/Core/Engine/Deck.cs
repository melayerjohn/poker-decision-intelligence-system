using System;
using System.Collections.Generic;
using PokerGame.Models;

namespace PokerGame.Core.Engine
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();
        private Random _random = new Random();

        public void Initialize()
        {
            _cards.Clear();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    _cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            int n = _cards.Count;

            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);

                (_cards[k], _cards[n]) = (_cards[n], _cards[k]);
            }
        }

        public Card Draw()
        {
            Card card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }
    }
}