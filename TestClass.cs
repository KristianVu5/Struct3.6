using System;
using System.Collections.Generic;
using System.Text;

namespace Struct3._6
{

    struct SimpleStruct
    {
        private int xval;
        public int X
        {
            get
            {
                return xval;
            }
            set
            {
                if (value < 100)
                {
                    xval = value;
                }
            }
        }


            public void DisplayX()
        {
            Console.WriteLine("The stored value is: {0}", xval);
        }
    }

  
    internal class TestClass
    {

        public static void Main()
        {
            SimpleStruct ss = new SimpleStruct();
            Console.WriteLine("Enter a number:");
            ss.X = int.Parse(Console.ReadLine());
            ss.DisplayX();
            Console.ReadLine();
        }
    }
}
