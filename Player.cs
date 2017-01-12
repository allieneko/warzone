using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Player
    {
        public string name {get; set;}
        public List<Card> hand = new List<Card>();
        // public List<Card> hand2 = new List<Card>();
        public Player(string n)
        {
            name = n;
        }

        public void Deal(Deck deck) {
            for (int i=0; i < 26; i++) {
            hand.Add(deck.draw());
            }
        }

         public void AddToHand(Card card)
            {
                hand.Add(card);
            }
    }
}
