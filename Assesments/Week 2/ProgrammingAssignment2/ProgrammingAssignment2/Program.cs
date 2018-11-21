using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("-------------------------.::Welcome to Casino::.------------------------");
            // create and shuffle a deck
            Deck deck=new Deck();
            deck.Shuffle();
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player
            Card card_1_for_player_1 = deck.TakeTopCard();
            Card card_1_for_player_2 = deck.TakeTopCard();
            Card card_1_for_player_3 = deck.TakeTopCard();
            Card card_2_for_player_1 = deck.TakeTopCard();
            Card card_2_for_player_2 = deck.TakeTopCard();
            Card card_2_for_player_3 = deck.TakeTopCard();
            Card card_3_for_player_1 = deck.TakeTopCard();
            Card card_3_for_player_2 = deck.TakeTopCard();
            Card card_3_for_player_3 = deck.TakeTopCard();

            // flip all the cards over
            card_1_for_player_1.FlipOver();
            card_1_for_player_2.FlipOver();
            card_1_for_player_3.FlipOver();
            card_2_for_player_1.FlipOver();
            card_2_for_player_2.FlipOver();
            card_2_for_player_3.FlipOver();
            card_3_for_player_1.FlipOver();
            card_3_for_player_2.FlipOver();
            card_3_for_player_3.FlipOver();
            // print the cards for player 1
            Console.WriteLine("Player 1 :");
            Console.WriteLine(card_1_for_player_1.Rank + " of " + card_1_for_player_1.Suit);
            Console.WriteLine(card_2_for_player_1.Rank + " of " + card_2_for_player_1.Suit);
            Console.WriteLine(card_3_for_player_1.Rank + " of " + card_3_for_player_1.Suit);
            Console.WriteLine();
            // print the cards for player 2
            Console.WriteLine("Player 2 :");
            Console.WriteLine(card_1_for_player_2.Rank + " of " + card_1_for_player_2.Suit);
            Console.WriteLine(card_2_for_player_2.Rank + " of " + card_2_for_player_2.Suit);
            Console.WriteLine(card_3_for_player_2.Rank + " of " + card_3_for_player_2.Suit);
            Console.WriteLine();
            // print the cards for player 3
            Console.WriteLine("Player 3 :");
            Console.WriteLine(card_1_for_player_3.Rank + " of " + card_1_for_player_3.Suit);
            Console.WriteLine(card_2_for_player_3.Rank + " of " + card_2_for_player_3.Suit);
            Console.WriteLine(card_3_for_player_3.Rank + " of " + card_3_for_player_3.Suit);

            Console.WriteLine();
        }
    }
}
