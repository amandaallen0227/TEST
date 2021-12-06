using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WATERLAB
{
    class Program
    {
        static void Main(string[] args)
        {

            double galWater = 8.33;            

            Console.WriteLine("How many gallons of water do you drink in a year?");

            string gallonString = Console.ReadLine();
            double gallonDouble = double.Parse(gallonString);        
            double gallonToPounds = gallonDouble * galWater;    
          
            Console.WriteLine("WOW! That means that you drink {0} pounds of water every year!", + gallonToPounds); 

        } //ENDMAIN
    } //ENDCLASS
} //ENDNAMESPACE
