using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHANGELAB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that will:
            // Prompt the user to enter a number of dollars and cents.            
            // Display the number of quarters, dimes, nickels, and pennies to make that amount.

            int quarter = 25;
            int dime = 10;            
            int nickel = 5;
            int penny = 1;

            //Step 1 Prompt user to enter  number of dollars and cents

            Console.WriteLine("Please enter in the total amount of money you spent (down to the decimal) at your last grocery store run: ");

            Console.Write("$"); string moneyString = Console.ReadLine();
        
            decimal moneyDecimal = Convert.ToDecimal(moneyString);
            Console.WriteLine(moneyString + " Wow! That is a lot of money!");
            moneyDecimal = moneyDecimal * 100;

            int moneyInt = Convert.ToInt32(moneyDecimal);
          
            //Step 2 Display the number of q, d, n, and p to make that amount.

            int intQuarters = moneyInt / quarter;
            int leftoverQuarter = moneyInt % quarter;

            int intDimes = leftoverQuarter / dime;
            int leftoverDime = moneyInt % dime;

            int intNickels = leftoverDime / nickel;
            int leftoverNickel = moneyInt % nickel;

            int intTotalPennys = leftoverNickel /= penny;

            Console.WriteLine($" Did you know that if you paid in change that would be: {intQuarters} in Quarters, {intDimes} in Dimes, {intNickels} in Nickels and {intTotalPennys} in Pennies?!");
            

        } //END MAIN
    } //END CLASS
} //END NAMESPACE
