using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Assessment_2___Program
{
    public class Deck
    {
        private int current;
        private Card[] deck;

        //Function to confirm if every card from the deck has been dealt
        public bool IsEmpty()
        {
            if (deck.Length == 0)
                return true;
            else
                return false;
        }

        //Function to shuffle the deck
        public void Shuffle()
        {
            current = 0;
            Random random = new Random();
            int next;
            for (int i = 0; i < deck.Length; i++)
            {
                //Program randomly selects another card and swaps with the current element (card) of deck
                next = random.Next(52);
                Card temp = deck[i];
                deck[i] = deck[next];
                deck[next] = temp;
            }
        }

        //Function to return (deal) the next card
        public Card Deal()
        {
            if (current < deck.Length)
                return deck[current++];
            else
            {
                return null;
            }

        }

        public Deck()
        {
            int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            string[] suits = new string[] { "Diamonds", "Clubs", "Spades", "Hearts" };
            string value;
            deck = new Card[52];
            for (int i = 0; i < deck.Length; i++)
            {
                //If statements to change the values (1, 11, 12, 13) to the corresponding word values
                if (i == 0 || i == 13 || i == 26 || i == 39)
                {
                    value = "Ace";
                }
                else if (i == 10 || i == 23 || i == 36 || i == 49)
                {
                    value = "Jack";
                }
                else if (i == 11 || i == 24 || i == 37 || i == 50)
                {
                    value = "Queen";
                }
                else if (i == 12 || i == 25 || i == 38 || i == 51)
                {
                    value = "King";
                }
                else
                {
                    //Assigns value to a number between 2 and 10
                    value = values[i % 13].ToString();
                }
                //The new instance of card is then added onto the end of the deck using the parameters established in the function
                //The suits[i/13] parameter is used to assign one of the 4 suits to the card
                deck[i] = new Card(value, suits[i / 13]);
            }
        }
    }
}
