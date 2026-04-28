using System.Collections.Generic;

namespace PokerGame.Models
{

    public class Player
    {

        public string Id { get; private set; }
        public List<Card> Hand { get; private set; } = new List<Card>();
        public bool IsFolded { get; set; }

        public Player(string _Id)
        {
            Id = _Id;
        }
    }
}

