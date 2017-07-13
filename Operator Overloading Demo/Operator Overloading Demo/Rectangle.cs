using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Demo
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle()
        { }
        Rectangle(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public static Rectangle operator +(Rectangle recOne, Rectangle recTwo)
        {
            Rectangle newRec = new Rectangle(recOne.Height + recTwo.Height, recOne.Width + recTwo.Width);
            return newRec;
        }
        //join big 
        public void JoinedRectangle()
        {
            Rectangle recOne = new Rectangle(20, 30);
            Rectangle recTwo = new Rectangle(10, 20);
            Rectangle extendedRectangel = recOne + recTwo;

            Console.WriteLine("The new Rctangle is : " + extendedRectangel.Height.ToString() + "  by  " + extendedRectangel.Width.ToString());

        }

    }
}
