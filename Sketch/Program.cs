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
            
            if (args.Any(a => a.Equals("-h", StringComparison.CurrentCultureIgnoreCase)))
            {
                Help();
                return;
            }

            Console.WriteLine("Hello Canvas");
        }

        public static void Draw()
        {

        }

        static void Help()
        {
            Console.WriteLine("This is Help");
        }
    }

    public class RectangleDrawObject : DrawObject
    {
        protected override string Illustration
        {
            get
            {
                return @"
*********
*********
*********
";
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
    public class SquareDrawObject : DrawObject
    {
        protected override string Illustration
        {
            get
            {
                return @"
****
****
****
";
            }
            set
            {
                throw new NotImplementedException();
            }
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
