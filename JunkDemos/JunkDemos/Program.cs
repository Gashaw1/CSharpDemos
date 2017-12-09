using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JunkDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Scorecard sCard = new Scorecard();
            var result = sCard["player2"];
        }
    }
    public class Scorecard
    {

        private Dictionary<string, int> palyers = new Dictionary<string, int>();
        //{
        //    {"player1", 1},
        //    {"player2", 2 },
        //    {"player3",3 }

        //};

        public void Add(string name, int score)
        {
            palyers.Add(name, score);
        }


        //index
        public int this[string name]
        {
            get
            {
                return palyers[name];
            }
        }

    }
}

