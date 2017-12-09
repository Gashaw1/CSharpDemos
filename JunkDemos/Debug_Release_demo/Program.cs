using System;
using System.Diagnostics;

namespace Debug_Release_demo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class CalcInterest
    {

        private static decimal cInterest(decimal loanAmount, int lonTerm, decimal loanRate)
        {
            decimal result = loanAmount * loanRate * loanRate;
#if DEBUG
            LogLine("Interest Amount : ", result.ToString("C"));
#endif
            return result;
        }
        [Conditional("DEBUG")]
        public static void LogLine(string message, string detail)
        {
            Console.WriteLine("Log: {0} = {1}", message, detail);
        }
    }
}
