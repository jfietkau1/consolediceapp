using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiceApp
{
    public class Die
    {
        private string name = "";
        private int num = 0;
        private Random random = new Random();
       
        public Die(string temp)
        {
            name = temp;
        }
        public void rollDie()
        {
            num = random.Next(1, 7); // Generates a random number between 1 (inclusive) and 7 (exclusive)
            //Console.WriteLine($"Rolled a {num} on die '{name}'.");

        }
        public int getNum()
        {
            return num;
        }



    }
}

