using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Debug_Release_demo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    #region
    interface IHome
    {
        void Start();
    }
    interface IOffice
    {
        void Start();
    }
    class UserStart : IOffice, IHome
    {

        //void IHome.Start()
        //{
        //    throw new NotImplementedException();
        //}

        //void IOffice.Start()
        //{
        //    throw new NotImplementedException();
        //}

        public void rESULT()
        {
            var starter = new UserStart();
            ((IHome)starter).Start();
            
            ((IOffice)starter).Start();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }

    
    public class TheaterCustomer
    {
        public int custmerID { get; set; }
        public string custmerName { get; set; }
        public static Stack stack = new Stack();

        public Stack customerstack(TheaterCustomer tobj)
        {
            stack.Push(tobj);
            return stack;
        }
    }

    #region calc intrest
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
    #endregion
    #region TestWebsite
    public class TestWebSites
    {


        public static List<string> TestWebsiteUrl(string url)
        {
            const string pattern = @"http://(www\.)?([^\.]+)\.com";

            List<string> result = new List<string>();
            MatchCollection myMatches = Regex.Matches(url, pattern);
            result = (from System.Text.RegularExpressions.Match m in myMatches
                      select m.Value).ToList<string>();

            return result;
        }

        public static async void ProcessWritle()
        {
            string filePath = @"C:\Users\User\Desktop\Csharp-demos\JunkDemos\JunkDemos\temp2.Text";
            string text = "Hello this Gashaw";

            await WrtieTextAsync(filePath, text);

        }

        private static async Task WrtieTextAsync(string filePath, string text)
        {
            byte[] encodedText = System.Text.Encoding.Unicode.GetBytes(text);

            using (FileStream sourceStream = new FileStream(filePath, FileMode.Append, FileAccess.Write,
                FileShare.None, bufferSize: 4096, useAsync: true))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            }
            //throw new NotImplementedException();
        }
        private static void CastsRef()
        {
            int var1 = 10;
            int var2;
            ArrayList arylist = new ArrayList();
            arylist.Add(var1);
            var2 = (int)arylist[0];


        }
    }
    #endregion
    class lists
    {
        public static void orderItems()
        {
            List<int> items = new List<int>()
            {
                100,
                33,
                4
                ,555,
                45,
                80
            };

            //var reslt = from r in items
            //            orderby r descending
            //            where r > 80
            //            select r;

            //or 


        }
    }

    abstract class BaseLogger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine("Base : " + message);
        }
        public void LogCompleted()
        {
            Console.WriteLine("Completed");
        }
    }
    class Logger : BaseLogger
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }
        public new void LogCompleted()
        {
            Console.WriteLine("finshed");
        }

    }
    #endregion

    public class MachesNum
    {
        public static List<string> GetValidPhoneNumber(string input, string pattern)
        {
            var ValidNum = new List<string>();

            var maches = regex.Matches(input);

            return ValidNum;
        }
    }
}

