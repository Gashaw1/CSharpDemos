using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass classdemo = new MyClass();
            string result = classdemo.operation("addNum", 2, 2);
            Console.WriteLine(result);

            Console.Read();
        }
    }
    public class MyClass
    {
        public int addNum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int subNum(int num1, int num2)
        {
            return num1 - num2;
        }
        public double divNum(int num1, int num2)
        {
            return num1 / num2;
        }
        public string operation(string opName, int num1, int num2)
        {
            object[] mParam = new object[] { num1, num2 };


            MyClass myClassObje = new MyClass();

            Type myTypeObj = myClassObje.GetType();

            MethodInfo myMethodInof = myTypeObj.GetMethod(opName);

            return myMethodInof.Invoke(myClassObje, mParam).ToString();



            // return mParam.ToString();
        }
    }
}


