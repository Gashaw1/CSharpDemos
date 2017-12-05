using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateInteres calcInterest = new CalculateInteres(1300.0M, 3, 44.0M);

            CalculateInteres.CalculateInterest(calcInterest);

            Console.Read();
        }
    }
    public class CalculateInteres
    {
        decimal loanAmount { get; set; }
        int loanTerm { get; set; }
        decimal lonRate { get; set; }

        public CalculateInteres(decimal loanAmount, int loanTerm, decimal lonRate)
        {
            this.loanAmount = loanAmount;
            this.loanTerm = loanTerm;
            this.lonRate = lonRate;
        }

        public static decimal CalculateInterest(CalculateInteres calcInterest)
        {
            decimal interestAmount = calcInterest.loanAmount * calcInterest.lonRate * calcInterest.loanTerm;
            #if DEBUG
            LogLine("Intrest Amount : ", interestAmount.ToString("C"));
            #endif
            return interestAmount;
        }
        //get execute only debug mode
        public static void LogLine(string message, string detail)
        {
            Console.WriteLine("Log: {0} = {1} ", message, detail);
        }
    }
}
