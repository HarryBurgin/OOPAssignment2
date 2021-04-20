using System;
using System.Dynamic;

namespace Assessment_2___Program
{
    class Program
    {
        //public string[] unshuffledDeck;
        static void Main(string[] args)
        {
            Deck deckB = new Deck();
            deckB.Shuffle();
            Boolean stop = false;
            Boolean validInp = false;
            string cont;
            //While the user doesn't want to stop dealing cards
            while (stop == false)
            {
                for (int i = 0; i < 52; i++)
                {
                    //Displays the card
                    Console.WriteLine(deckB.Deal());
                    //While loop to confirm if user wants to continue or not
                    while (validInp == false)
                    {
                        Console.WriteLine("Would you like to deal the next card (Y or N)");
                        cont = Console.ReadLine();
                        cont = cont.ToUpper();
                        if (cont == "Y")
                            validInp = true;
                        else if (cont == "N")
                        {
                            stop = true;
                            validInp = true;
                        }
                        else
                            Console.WriteLine("Invalid input: please enter 'Y' or 'N'");
                    }
                    validInp = false;
                    //If every card has been dealt or the user has asked to stop, the program stops dealing cards
                    if (deckB.IsEmpty() || stop == true)
                    {
                        break;
                    }
                }
                stop = true;
            }
            Console.WriteLine("Thanks for playing");
        }
    }
}
