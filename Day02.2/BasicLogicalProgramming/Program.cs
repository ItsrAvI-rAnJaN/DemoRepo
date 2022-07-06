using System;

namespace BasicLogicalProgramming
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t####################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO BASIC LOGICAL PROGRAMMING");
            Console.WriteLine("\t\t\t\t####################################################");
            Console.WriteLine("Enter Question Number You Want to Execute");
            Console.WriteLine("Enter 0 to 'Exit' ");
            Console.WriteLine("1.Program To Check Entered Number is Even or Odd");
            Console.WriteLine("2.program To Check Entered Number is Prime or Not\n");
            Console.Write("Enter Your Choice : ");
            int Choice =Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    CheckEvenOdd objEvenOdd = new CheckEvenOdd();
                    objEvenOdd.checkEvenOrOdd();
                    break;
                case 2:
                    CheckPrimeNum objPrimeOrNot =new CheckPrimeNum();
                    objPrimeOrNot.primeOrNot();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Please Enter Correct Choice");
                    break;

            }
            
            Console.ReadKey();


        }
    }
}