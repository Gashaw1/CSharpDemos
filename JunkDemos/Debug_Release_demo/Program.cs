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
            TestWebSites.ProcessWritle();
            TestWebSites.TestWebsiteUrl("http://gashaw.somee.com/TestMvc/Home/Contact");
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
    #region WriteFiles
    #endregion
}
