using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAndAsOperatorsDemo
{
    class Parent
    {
        int parentID { get; set; }
        string parentMiddleName { get; set; }
    }
    class Child : Parent
    {
        int childId { get; set; }
        string childLastName { get; set; }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();
            //return true because Child class inherited Parent class
            bool IsChild = child is Parent;
            //this time return false because the base class can't be an object to the chld class
            bool IsPrent = parent is Child;

            //return false
            castToObject(parent);

            //return ture
            castToObject(child);

        }
        public static bool castToObject(object obj)
        {
            Child parent = obj as Child;

            if (parent != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
