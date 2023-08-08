using System;
using System.Drawing;
using System.Xml;
namespace Lesson2
{
    public class App
    {
        public static void Main()
        {
            byte a = 0b00001111;
            byte b = (byte)(a<<7);

            Console.WriteLine(Convert.ToString(b,16));
            Console.WriteLine(b);
        }
    }
}