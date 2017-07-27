using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name:Rosa Munguia
 * Date: July 25 2017
 Description: This is the deck class
 it inherits 
 Version 0.6- Added deal1 method to deck class 
     */
namespace Week11
{

    public class Deck: CardList//composing list of type card
    {
        //Private instance variables
        private Random _random;
        //public properties

       
        //Private methods
        /// <summary>
        /// This is the initializer method. It sets the values for private variables and public
        /// properties as well as 
        /// </summary>
        protected override void _initialize()
        {
            //initialize the pseudo-random number generator
            this._random = new Random();

            //this builds the deck- fills it with cards
            for(int suit=(int)Suit.Clubs; suit <= (int)Suit.Hearts; suit++)
            {
                for (int face=(int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face) face, (Suit) suit));
                }
            }

           
        }
        //constructor

        //Public methods
        /// <summary>
        /// This method overrides the built in to string method
        /// </summary>
        /// <returns>Returns the current cards in the deck</returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "Deck Contains  Number of Cards: " + this.Count + "\n";
            Console.WriteLine("******************************************");
            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// this method shuffles the deck by using random indices
        /// to select two cards at a time
        /// it uses a fisher-yates like algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
           Card tempCard;

            for (int card=0; card < this.Count; card++)
            {
                firstCard = this._random.Next(0, this.Count);
                secondCard = this._random.Next(0, this.Count);

                tempCard =(Card)this[secondCard].Clone();

                Card.Overwrite(this[secondCard], this[firstCard]);
                Card.Overwrite(this[firstCard], tempCard);
                
            }
        }
        /// <summary>
        /// This method returns the top card of the deck
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0); //this removes top card form deck

            //for testing/debugging only
            Console.WriteLine("Dealt 1 card - Size of Deck: " + this.Count);
            return topCard;
        }

        public Hand Deal5()
        {
           
            Hand fivecards = new Hand();
            for(int i =0; i <= 4; i++)
            {
               Card card = this[0];
                this.RemoveAt(0);
                fivecards.Add(card);
            }
            Console.WriteLine("Dealt 5 cars New deck size: " + this.Count);
            return fivecards;
        }
    }
}