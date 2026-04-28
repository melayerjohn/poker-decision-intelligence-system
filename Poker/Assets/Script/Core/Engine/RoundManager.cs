using System.Collections.Generic;
using PokerGame.Models;

namespace PokerGame.Core.Engine
{
    public class RoundManager
    {
        private List<Player> _players;
        private Deck _deck;
        private List<Card> _communityCards = new List<Card>();

        public RoundManager(List<Player> players)
        {
            _players = players;
            _deck = new Deck();
        }

        public void StartRound()
        {
            _deck.Initialize();
            _deck.Shuffle();

            DealHoleCards();
            DealFlop();
            DealTurn();
            DealRiver();
        }

        private void DealHoleCards()
        {
            foreach (var player in _players)
            {
                player.Hand.Add(_deck.Draw());
                player.Hand.Add(_deck.Draw());
            }
        }

        private void DealFlop()
        {
            _communityCards.Add(_deck.Draw());
            _communityCards.Add(_deck.Draw());
            _communityCards.Add(_deck.Draw());
        }

        private void DealTurn()
        {
            _communityCards.Add(_deck.Draw());
        }

        private void DealRiver()
        {
            _communityCards.Add(_deck.Draw());
        }

        public List<Card> GetCommunityCards()
        {
            return _communityCards;
        }

        public List<Player> GetPlayers()
        {
            return _players;
        }
    }
}