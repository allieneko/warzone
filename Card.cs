using System;


namespace DeckofCards 
{
    public class Card {
        public int numVal;
        public string val { get{
                //don't use a variable here - because its super easier to get infinite loops.
                if (numVal > 1 && numVal < 11)
                {
                    return numVal.ToString();
                } else if (numVal == 11) {
                    //how to do the face cards?
                    return "Jack";
                } else if (numVal == 12) {
                    return "Queen";
                } else if (numVal == 13) {
                    return "King";
                } else if (numVal == 14) {
                    return "Ace";
                } else {
                    return "Joker";
                }
            }
        }
        //this allows you to change ways these values are accessed.
        //get - defines the way you ever get the value.
        //if you run - myCard.value

        public string suit;

        public Card(string s, int num){
            suit = s;
            numVal = num;
            
        }

        public override string ToString(){
            return val + " of " + suit;
            
        }
    }

}