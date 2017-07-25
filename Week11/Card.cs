using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Rosa Munguia
 Date: July 25 2017
 Description: This is the card class
 Version 0.3- Added the overwrite method*/
namespace Week11
{
    public class Card: ICloneable   
    {
        //PRIVATE INSTANCE VARIABLES-these are integers; using enums as a datatype
        private Face _face;
        private Suit _suit;

        //PUBLIC PROPERTIES
        public Face Face { get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }

        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            { this._suit = value; }
        }
        //CONSTRUCTORS
        /// <summary>
        /// this is the main constructor
        /// it takes two arguments: face(Face) and suit (Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        //PRIVATE METHODS
        
        //PUBLIC METHODS
        /// <summary>
        /// This method overrides the built-in Clone method
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }

        /// <summary>
        /// This method overwrites the first card  properties
        /// of the second card
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void Overwrite (Card first, Card second)
        {
            first.Face = second.Face;
            first.Suit = second.Suit;
        }
    }
}