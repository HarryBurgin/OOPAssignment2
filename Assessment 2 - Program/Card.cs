using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assessment_2___Program
{
    public class Card
    {
        private string _suit;
        private string _value;

        public string suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        public string value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Card(string value, string suit)
        {
            _value = value;
            _suit = suit;
        }

        //Assembles the card name as shown in output
        public override string ToString()
        {
            return value + " of " + suit;
        }
    }    
}
