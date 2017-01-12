using System;
// using Card;

namespace DeckofCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Card myCard = new Card("Clubs", 6);
            // Card myCard2 = new Card("Hearts", 1);
            Deck myDeck = new Deck();
            myDeck.shuffle();
            // Console.WriteLine(myDeck);
            // myDeck.deal();
            // Console.WriteLine(myDeck.deal());
            // Console.WriteLine(myDeck);
            Player player1 = new Player("Dave");
            Player player2 = new Player("Computer");
            player1.Deal(myDeck);
            player2.Deal(myDeck);
            // Game myGame = new Game();
            // player1.Game(player2);
            Console.WriteLine("Do you want to play?");
            string InputLine = Console.ReadLine();
            while (InputLine == "Y") {
            
            Console.WriteLine("Player 1 has " + player1.hand[0] + " worth " + player1.hand[0].numVal);
            Console.WriteLine("Player 2 has " + player2.hand[0] + " worth " + player2.hand[0].numVal);
            if (player1.hand[0].numVal > player2.hand[0].numVal) {
            Console.WriteLine("Player 1 wins!"); 
                Card p1 = player1.hand[0];
                Card p2 = player2.hand[0];
                player1.hand.RemoveAt(0);
                player2.hand.RemoveAt(0);
                player1.AddToHand(p1);
                player1.AddToHand(p2);
                Console.WriteLine("Player 1 has " + player1.hand.Count + " cards in their deck! Player 2 has " + player2.hand.Count + " cards in their deck!");
            }
            else if (player1.hand[0].numVal < player2.hand[0].numVal) {
                Console.WriteLine("Player 2 wins!");
                Card p1 = player1.hand[0];
                Card p2 = player2.hand[0];
                player1.hand.RemoveAt(0);
                player2.hand.RemoveAt(0);
                player2.AddToHand(p1);
                player2.AddToHand(p2); 
            Console.WriteLine("Player 1 has " + player1.hand.Count + " cards in their deck! Player 2 has " + player2.hand.Count + " cards in their deck!"); }
            else { Console.WriteLine("There's a tie! Each player gets their card back.");
                Card p1 = player1.hand[0];
                Card p2 = player2.hand[0];
                player1.hand.RemoveAt(0);
                player2.hand.RemoveAt(0);
                player1.AddToHand(p1);
                player2.AddToHand(p2); 
                    Console.WriteLine("Player 1 has " + player1.hand.Count + " cards in their deck! Player 2 has " + player2.hand.Count + " cards in their deck!"); 
                }
            if (player1.hand.Count == 0) {
            Console.WriteLine("Player 2 wins! Game Over!"); 
            break; }
            if (player2.hand.Count == 0) {
            Console.WriteLine("Player 1 wins! Game Over!"); 
            break; }

            Console.WriteLine("Do you want to play?"); 
            InputLine = Console.ReadLine();
            }
            Console.WriteLine("Doot!");
            }
        }
    }
    
