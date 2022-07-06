using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    public class CheckPrimeNum
    {
        int Number;
        int Flag = 0;
        
        public void primeOrNot()
        {
            Console.Write("Enter The Number to Check Prime or Not : ");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nResult :- ");

            if (Number == 2)
            {
                Console.WriteLine("The Number You Enter is Prime Number");
            }
            for(int i = 2; i< Number / 2; i++)
            {
                if (Number %i == 0)
                {
                    Flag = 1;
                }
                
            }
            if (Flag == 1)
            {
                Console.WriteLine("The Number You Enter is not a Prime Number");
            }
            else
            {
                Console.WriteLine("The Number You Enter is  a Prime Number");
            }

        }
    }
}
