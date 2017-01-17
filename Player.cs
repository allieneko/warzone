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

        //Adding this method to deck
        // public void Deal(Deck deck) {
        //     for (int i=0; i < 26; i++) {
        //         hand.Add(deck.draw());
        //     }
        // }

        public Card PlayTopCard(){
            Card toPlay = hand[0];
            hand.RemoveAt(0);
            return toPlay;
        }

         public void AddToHand(Card card)
            {
                hand.Add(card);
            }
    }
}
