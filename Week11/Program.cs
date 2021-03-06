﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Rosa Munguia
 Date: July 25 2017
 Description: Demo for Lesson 11
 Version 0.3- test shuffle method of the deck class*/
namespace Week11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck deck = new Deck();
            Hand hand = new Hand();
           // Console.WriteLine("Original Deck:  # of Cards: " + deck.Count);
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
           // Console.WriteLine("Shuffled Deck:   # of Cards: " + deck.Count);
            deck.Shuffle();
            Console.WriteLine(deck.ToString());

          //  hand.Add(deck.Deal1());
          //  Console.WriteLine(hand.ToString());
           // Console.WriteLine();
           // hand.Add(deck.Deal1());
          //  Console.WriteLine(hand.ToString());
            Console.WriteLine();

          //  hand.Add(deck.Deal5());
            Console.WriteLine(hand.ToString());
            hand = deck.Deal5(); // moves the top 5 cards from the deck to the hand object
            Console.WriteLine(hand.ToString());
        }
    }
}
