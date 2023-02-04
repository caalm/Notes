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
            List<string[]> notes = new List<string[]>();

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
                    switch (selection)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.Write("Note: ");
                                string[] note = new string[2];
                                notes.Add(note);
                                note[0] = Console.ReadLine();
                                note[1] = DateTime.Now.ToString();
                                Console.WriteLine("Note has been saved.");
                                Console.ReadLine();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("Notes:");
                                foreach (string[] item in notes)
                                {
                                    Console.WriteLine("\n" + item[0]);
                                    Console.WriteLine(item[1]);
                                }
                                Console.ReadKey();
                                break;
                            }
                    }
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
