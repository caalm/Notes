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
        static void WrongInput()
        {
            Console.Clear();
            Console.WriteLine("Choose 1-5 in the menu.");
            Console.ReadLine();
        }

        static void Remove(List<string[]>notes)
        {
            Console.Write("\nType note to remove: ");
            string remove = Console.ReadLine();
            for (int i = 0; i < notes.Count; i++)
            {
                if (remove == notes[i][0])
                {
                    notes.RemoveAt(i);
                    Console.WriteLine("Note has been removed.");
                    Console.ReadLine();
                }
            }
        }

        static void WriteNotes(string[] item, List<string[]> notes, User user1)
        {
            Console.WriteLine("\n" + item[0]);
            Console.WriteLine(item[1]);
            Console.WriteLine("Created by " + user1.Name + ".");
        }

        static void Main(string[] args)
        {
            List<string[]> notes = new List<string[]>();

            bool menu = true;

            Console.Write("Name: ");
            User user1 = new User();
            user1.Name = Console.ReadLine();

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Notes");
                Console.WriteLine("\n[1] New note");
                Console.WriteLine("[2] See all notes");
                Console.WriteLine("[3] Search note");
                Console.WriteLine("[4] Remove note");
                Console.WriteLine("[5] Exit");
                Console.Write("\nChoose: ");

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
                                string dateTime = DateTime.Now.ToString();
                                note[1] = dateTime;
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
                                    WriteNotes(item, notes, user1);
                                }
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                Console.Write("Search: ");
                                string search = Console.ReadLine();
                                for (int i = 0; i < notes.Count; i++)
                                {
                                    if (notes[i][0] == search)
                                    {
                                        Console.WriteLine("\n" + notes[i][0]);
                                        Console.WriteLine(notes[i][1]);
                                        Console.WriteLine("Created by " + user1.Name + ".");
                                        Console.ReadLine();
                                    }
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                Console.WriteLine("Notes:");
                                foreach (string[] item in notes)
                                {
                                    WriteNotes(item, notes, user1);
                                }
                                Remove(notes);
                                break;
                            }
                        case 5:
                            {
                                Console.Clear();
                                Console.WriteLine("Closing notes.");
                                menu = false;
                                System.Threading.Thread.Sleep(1000);
                                break;
                            }
                        default:
                            {
                                WrongInput();
                                break;
                            }
                    }
                }
                else
                {
                    WrongInput();
                }
            }
        }
    }
}
