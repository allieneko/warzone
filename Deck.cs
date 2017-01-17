using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Deck
    {
        public List<Card> cards;
        //Constructor function
        public Deck()
        {
            reset();
        }

        public void reset()
        {
            cards = new List<Card>();
            string[] suits = new string[4] {"Hearts", "Clubs", "Spades", "Diamonds"};
            for(int i = 0; i < suits.Length; i++)
            {
                for (int n = 2; n < 15; n++)
                {
                    cards.Add(new Card(suits[i], n));
                }
            }
        }

        public Card draw()
        {
            Card toReturn = cards[0];
            cards.RemoveAt(0);
            return toReturn;
            
        }

        public void shuffle()
        {
            Random rand = new Random();
            for (var i = cards.Count - 1; i > 0; i--)
            {
                //fischer yates - everything in a different spot  
                int randIdx = rand.Next(cards.Count - i);
                Card swap = cards[i];
                cards[i] = cards[randIdx];
                cards[randIdx] = swap;
            }
            
        }

        //Deals entire deck to 2 players
        public void DealEntireDeck(Player p1, Player p2) {
            //Make sure deck is full
            int remainingCards = cards.Count;
            for (int turn = 0; turn < remainingCards; turn++) {
                if(turn % 2 == 0) {
                    p1.AddToHand(draw());
                } else {
                    p2.AddToHand(draw());
                }
            }
        }

        //Deals entire deck across a list of players
        public void DealEntireDeck(List<Player> players) {
            int remainingCards = cards.Count;
            for (int turn = 0; turn < remainingCards; turn++) {
                players[turn % players.Count].AddToHand(draw());
            }
        }

        public override string ToString()
        {
            //build to display all cards
            string str = "";
            foreach(Card card in cards)
            {
                str += card + "\n";
            }
            //here?
            return str;
        }
    }
}