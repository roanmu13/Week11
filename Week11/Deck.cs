using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name:Rosa Munguia
 * Date: July 25 2017
 Description: This is the deck class
 version0.1-Created deck class
     */
namespace Week11
{

    public class Deck: List<Card>//composing list of type card
    {
        //Private instance variables
        //public properties

            /// <summary>
            /// this is the main constructor
            /// </summary>
        //Constructor
        public Deck()
        {
            this._initialize();
        }
        //Private methods
        /// <summary>
        /// This is the initializer method. It sets the values for private variables and public
        /// properties as well as 
        /// </summary>
        private void _initialize()
        {
            for(int suit=(int)Suit.Clubs; suit <= (int)Suit.Hearts; suit++)
            {
                for (int face=(int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face) face, (Suit) suit));
                }
            }

           
        }
        //Public methods
        /// <summary>
        /// This method overrides the built in to string method
        /// </summary>
        /// <returns>Returns the current cards in the deck</returns>
        public override string ToString()
        {
            string outputString = "";
            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
    }
}