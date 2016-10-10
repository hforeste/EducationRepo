using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sketch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Canvas");
        }

        public static void Draw()
        {

        }
    }

    public abstract class DrawObject
    {
        protected abstract string Illustration { get; set; }
        public override string ToString()
        {
            return Illustration;
        }
    }
}
