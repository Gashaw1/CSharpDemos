using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug_Demo
{
    class Program
    {
        static void Main(string[] args)
        {


            TestCast test = new TestCast();
            TestCast.DoWorkd(test);

            //Product pr = new Product();
            var result = Product.ValidatesRes();
            CalculateInteres calcInterest = new CalculateInteres(1300.0M, 3, 44.0M);

            CalculateInteres.Calculate(2.22F);

            CalculateInteres.CalculateInterest(calcInterest);

            Console.Read();
        }
    }
    #region
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
        //this get execute only debug mode
        [Conditional("mDebug")]
        public static void LogLine(string message, string detail)
        {
            Console.WriteLine("Log: {0} = {1} ", message, detail);
        }

        public static void Calculate(float amount)
        {
            object amountRef = amount;
            float amonFloat = (float)amountRef;
            int balance = (int)amonFloat;
            //int balance = (int)(float)amountRef;
            Console.WriteLine(amonFloat);
        }
    }
    #endregion
    #region validatin demo
    public class Product
    {
        public static int Id = 3;
        public static string Name = null;

        public static bool IsValid { get; set; }


        public static bool Validate()
        {
            if (IsValid = Id > 0 && !string.IsNullOrEmpty(Name))
            {
                return IsValid;
            }
            else
            {
                return false;
            }

        }
        //needs to return a multiple result
        public static ValidationResult Validateion()
        {
            ValidationResult valR = null;
            if (Id <= 0)
            {
                valR = new ValidationResult("Id required");
            }
            if (string.IsNullOrEmpty(Name))
            {
                valR = new ValidationResult("Naem required");
            }
            return valR;

        }

        //
        public static IEnumerable<ValidationResult> ValidatesRes()
        {
            if (Id <= 0)
            {
                yield return new ValidationResult("Id required ", new[] { "Id" });
            }
            if (string.IsNullOrEmpty(Name))
            {

                yield return new ValidationResult("Name equired ", new[] { "Name" });

            }


        }
    }
    #endregion
    #region collectio demo
    public class Loan
    {

    }
    public class LoanCollection : IEnumerable
    {
        private readonly Loan[] _loanCollection;

        public LoanCollection(Loan[] loanArray)
        {
            _loanCollection = new Loan[loanArray.Length];

            for (int i = 0; i < loanArray.Length; i++)
            {
                _loanCollection[i] = loanArray[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _loanCollection.GetEnumerator();
        }
    }
    #endregion

    public interface IDataContainer
    {
        string Data { get; set; }
    }
    public class TestCast
    {
        public string Data
        {
            get
            {
                return "test";
            }

            set
            {
                Data = value;
            }
        }

        public static void DoWorkd(object obj)
        {
            var dataContaier = obj as IDataContainer;
            if (dataContaier != null)
            {
                Console.WriteLine(dataContaier.Data);
            }
        }
    }
}
 

