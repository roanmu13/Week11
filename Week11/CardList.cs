using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Rosa Munguia
 Date: July 27 2017
 Description: Abstract super class Card List
 Version 0.1. Created abstract cardList*/
namespace Week11
{
    public abstract class CardList: List<Card>
    {
        //private instant variables


        //public properties

        //constructors
        /// <summary>
        /// this is the main constructor
        /// </summary>
      
        public CardList()
        {
            this._initialize();
        }
        //private methods
        protected abstract void _initialize();
        //public methods
    }
}