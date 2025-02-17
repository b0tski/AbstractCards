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
        public abstract int rank { get; set; }
        public abstract string type { get; set; }

        // Methods 
        public abstract string Display();

        public void GameInfo()
        {
            Console.WriteLine("Rank: Determins how powerful the card is \nExample: (1 weakest - 10 strongest)\n" +
                "\nType: Determines what kind of card \nExample: (Attack, Defense, Heal)\n");
        }
    }
        
    internal class Program
    {

        class Suit : Cards
        {
            public override int rank { get; set; }
            public override string type { get; set; } 

            public Suit()
            {
                rank = 0;
                type = string.Empty;
            }

            public Suit(int number, string type)
            {
                this.rank = number;
                this.type = type;
            }

            public override string Display() 
            {
                return $"Rank: {rank} \nType: {type}";
            }
        }

        static void Main(string[] args)
        {
            Suit card1 = new Suit(8, "Attack");
            card1.GameInfo();
            Console.WriteLine(card1.Display());
        }
    }
}
