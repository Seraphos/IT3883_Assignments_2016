using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal userEnteredHomeSalePrice = 0m;
            decimal totalCommission = 0m;

            while (userEnteredHomeSalePrice != -1)
            {

                Console.WriteLine("Please enter the dollar amount of the home sale price. Press -1 to exit. ");
                userEnteredHomeSalePrice = Convert.ToDecimal(Console.ReadLine());

                if (userEnteredHomeSalePrice == -1)
                {
                    Console.WriteLine("The total commission on all home sales entered is: " + totalCommission);
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    break;
                }

                else if (userEnteredHomeSalePrice < 100000)
                {
                    decimal commissionOne = userEnteredHomeSalePrice * .05m;
                    Console.WriteLine("The commission on that sale is: " + commissionOne);
                    Console.ReadLine();
                    totalCommission += commissionOne;
                }

                else if (userEnteredHomeSalePrice >= 100000 && userEnteredHomeSalePrice <= 250000)
                {
                    decimal commissionTwo = userEnteredHomeSalePrice * .06m;
                    Console.WriteLine("The commission on that sale is: " + commissionTwo);
                    Console.ReadLine();
                    totalCommission += commissionTwo;
                }

                else if (userEnteredHomeSalePrice > 250000)
                {
                    decimal commissionThree = userEnteredHomeSalePrice * .07m;
                    Console.WriteLine("The commission on that sale is: " + commissionThree);
                    Console.ReadLine();
                    totalCommission += commissionThree;
                    
                }





            }//end while loop






        }//end client method
    }//end program
}//end class
