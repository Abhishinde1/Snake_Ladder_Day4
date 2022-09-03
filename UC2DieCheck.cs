using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class UC2DieCheck
    {
        public static void dieCheck()
        {
            int START_POSITION = 0;

            //Die Check
            Random random = new Random();
            int dieCheck = random.Next(0, 7);
            if (dieCheck == 0)
            {
                dieCheck = dieCheck + 1;

            }
            Console.WriteLine("Number on die is: " + dieCheck);
        }
    }
}
