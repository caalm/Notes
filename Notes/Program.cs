using System;
using System.Collections;
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
            bool menu = true;

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("[1] New note");
                Console.WriteLine("[2] See all notes");
                Console.WriteLine("[3] Search note");
                Console.WriteLine("[4] Remove note");
                Console.WriteLine("[5] Exit");
                Console.Write("Choose: ");

                if (Int32.TryParse(Console.ReadLine(), out int selection))
                {

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Choose 1-5");
                    Console.ReadLine();
                }
            }
        }
    }
}
