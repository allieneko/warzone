using System;
// using Card;

namespace DeckofCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play?");
            string InputLine = Console.ReadLine();
            //Updated to cover more variations
            while (InputLine.ToLower() == "y" || InputLine.ToLower() == "yes") {
                //Initialize after confirming they are playing
                Deck myDeck = new Deck();
                myDeck.shuffle();

                Player player1 = new Player("Dave");
                Player player2 = new Player("Computer");
                myDeck.DealEntireDeck(player1, player2);
                
                while(player1.hand.Count > 0 && player2.hand.Count > 0) {
                    //Immediately hold the top card for each player
                    Card p1Card = player1.PlayTopCard();
                    Card p2Card = player2.PlayTopCard();

                    Console.WriteLine("Player 1 has " + p1Card + " worth " + p1Card.numVal);
                    Console.WriteLine("Player 2 has " + p2Card + " worth " + p2Card.numVal);


                    if (p1Card.numVal > p2Card.numVal) {
                        Console.WriteLine("Player 1 wins!"); 
                        player1.AddToHand(p1Card);
                        player1.AddToHand(p2Card);
                        Console.WriteLine("Player 1 has " + player1.hand.Count + " cards in their deck! Player 2 has " + player2.hand.Count + " cards in their deck!");
                    }
                    else if (p1Card.numVal < p2Card.numVal) {
                        Console.WriteLine("Player 2 wins!");
                        player2.AddToHand(p1Card);
                        player2.AddToHand(p2Card); 
                    Console.WriteLine("Player 1 has " + player1.hand.Count + " cards in their deck! Player 2 has " + player2.hand.Count + " cards in their deck!"); }
                    else {
                        Console.WriteLine("There's a tie! Each player gets their card back.");
                        player1.AddToHand(p1Card);
                        player2.AddToHand(p2Card); 
                        Console.WriteLine("Player 1 has " + player1.hand.Count + " cards in their deck! Player 2 has " + player2.hand.Count + " cards in their deck!"); 
                    }

                    if (player1.hand.Count == 0) {
                        Console.WriteLine("Player 2 wins! Game Over!"); 
                    }
                    if (player2.hand.Count == 0) {
                        Console.WriteLine("Player 1 wins! Game Over!"); 
                    }
                    Console.WriteLine("Press enter to flip next card!\n");
                    Console.ReadLine();
                }

                Console.WriteLine("Do you want to play again?"); 
                InputLine = Console.ReadLine();
            }
            Console.WriteLine("Doot!");
        }
    }
}

//This was all really good and you were right there were your implementation
//Just needed to add that while loop to check if either player's hand had run out!
//Need to still add War logic though, since games will never end without it (if both sides have an ace)
    
