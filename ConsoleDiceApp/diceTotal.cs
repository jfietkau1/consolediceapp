using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiceApp
{
    internal class diceTotal
    {
        private int total = 0;
        private int name = 0;
        public string stars = "";
        public diceTotal(int totalname)
        {
            name = totalname;
            total = 0;
        }
        public int GetTotal()
        {
            return total;
        }
        public void AddToTotal()
        {
            total += 1;
        }
        public void calculateStars(int totalRolls)
        {
            //cast those integers as floats so I can divide
            float totalFloat = (float)total;
            float totalRollsFloat = (float)totalRolls;

            //calculate the total percent
            float percent = totalFloat / totalRollsFloat;

            percent = percent * 100;

            //round the percent to a whole number so I can put whole stars (instead of partial stars)
            int numStars = (int)Math.Round(percent);
            //add the stars to the string
            for (int i = 0; i < numStars; i++)
                stars = stars + "*";
            //write the stars to the console.
            System.Console.WriteLine($"{name}: {stars}");
            //System.Console.WriteLine(stars);

        }

        

    }
}
