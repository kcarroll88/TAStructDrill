using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAStructDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 2.34m;
            Console.WriteLine(number.Amount);

            Console.ReadLine();
        }       
    }  
}
