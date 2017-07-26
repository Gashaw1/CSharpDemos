using BusinessLayer;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApplicationUserPresentionLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Users ur = new Users();

            var result = (from r in ur.ReturnUsers()
                          select r).ToArray();


            foreach (var re in result)
            {
                //Console.WriteLine("{0} {1}", re.UserName, re.UserEmail);
                Console.WriteLine("Name  {0} Email {1}", re.UserName, re.UserEmail);
            }
            Console.Read();

        }
    }
}
