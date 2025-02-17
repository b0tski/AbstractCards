using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCards
{
    abstract class Cards
    {
        // Properties 
        public abstract int number { get; set; }
        public abstract string type { get; set; }

        // Methods 
        public abstract string Display();
    }
        
    internal class Program
    {

        class Suit : Cards
        {
            public override int number { get; set; }
            public override string type { get; set; } 

            public Suit()
            {
                number = 0;
                type = string.Empty;
            }

            public Suit(int number, string type)
            {
                this.number = number;
                this.type = type;
            }

            public override string Display() 
            {
                return $"Card: {type} \nNumber: {number}";
            }
        }

        static void Main(string[] args)
        {
            Suit card1 = new Suit(5, "Spade");
            Console.WriteLine(card1.Display());
        }
    }
}
