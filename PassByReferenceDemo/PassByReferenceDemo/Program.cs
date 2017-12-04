using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bValidInteger = false;
            int value = 0;
            do
            {
                Console.WriteLine("Enter an integer:");
                bValidInteger = GetValidInteger(ref value);
            }
            while (!bValidInteger);
            {
                Console.WriteLine("You entered a valide integer", +value);

            }
            Console.Read();

        }

        static bool GetValidInteger(ref int val)
        {
            string strLine = Console.ReadLine();
            int number;

            if (!int.TryParse(strLine, out number))
            {
                return false;
            }
            else
            {
                val = number;
                return true;
            }
        }
    }
}
