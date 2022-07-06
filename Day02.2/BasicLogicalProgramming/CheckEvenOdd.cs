using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    public class CheckEvenOdd
    {
        public void checkEvenOrOdd()
        {
            int Number;
            Console.WriteLine("Enter A Number to Check Even or Odd");
            Number = Convert.ToInt32(Console.ReadLine());

            if (Number / 2 == 0)
            {
                Console.WriteLine("The Number You Enter is an Even Number");
            }
            else
            {
                Console.WriteLine("The you Enter is an Odd Number");
            }
        }
    }
}
