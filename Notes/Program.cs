using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool meny = true;

            while (meny)
            {
                Console.WriteLine("[1] New note");
                Console.WriteLine("[2] See all notes");
                Console.WriteLine("[3] Search note");
                Console.WriteLine("[4] Remove note");
                Console.WriteLine("[5] Exit");
                Console.Write("Choose: ");
            }
        }
    }
}
