using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormaters
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(2015, 8, 28, 6, 0, 0);

            decimal[] temps = { 873.452m, 68.98m, 72.6m, 69.24563m, 74.1m, 72.156m, 72.228m };

            Console.WriteLine("{0,-20} {1,11}\n", "Date", "Temperature");

            for (int ctr = 0; ctr < temps.Length; ctr++)
            {
                Console.WriteLine("{0,-20:g} {1:N3}", startDate.AddDays(ctr), temps[ctr]);
            }

            Console.Read();
        }
    }
}
