using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Rosa Munguia
 Date: July 27 2017
 Description: Hand Class that inherits from abstract CardList
 Version 0.1. Created Hand Class*/
namespace Week11
{
    public class Hand : CardList
    {
        //private instant variables


        //public properties

        //constructors

        //private method
        protected override void _initialize()
        {
            //stub
            //this method is empty
        }


        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

       
    }
}