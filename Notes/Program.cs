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
        // Jag skapar en metod till när användaren skriver in något fel i menyn.
        static void WrongInput()
        {
            Console.Clear();
            Console.WriteLine("Choose between 1 and 5 in the menu.");
            Console.ReadLine();
        }

        // Jag skapar en metod till att ta bort anteckningar för att minska koden och göra den mer läsbar.
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

        // Jag skapar en metod för att skriva ut anteckningar.
        static void WriteNotes(string[] item, List<string[]> notes, User user1)
        {
            Console.WriteLine("\n" + item[0]);
            Console.WriteLine(item[1]);
            Console.WriteLine("Created by " + user1.Name + ".");
        }

        static void Main(string[] args)
        {
            // Jag skapar en lista som innehåller arrayer med anteckningar.
            List<string[]> notes = new List<string[]>();

            // Jag deklarerar en bool som är sann tills användaren väljer att stänga av programmet.
            bool menu = true;

            // Användaren skriven in sitt namn som sparas i en klass.
            Console.Write("Name: ");
            User user1 = new User();
            user1.Name = Console.ReadLine();

            // En while loop som loopas boolen menu blir falsk då användaren väljer att stänga av programmet.
            while (menu)
            {
                // Programmets meny skrivs ut.
                Console.Clear();
                Console.WriteLine("Notes");
                Console.WriteLine("\n[1] New note");
                Console.WriteLine("[2] See all notes");
                Console.WriteLine("[3] Search note");
                Console.WriteLine("[4] Remove note");
                Console.WriteLine("[5] Exit");
                Console.Write("\nChoose: ");

                // Om användaren skriver in något som inte stämmer med menyn så kommer man tillbaka till menyn.
                if (Int32.TryParse(Console.ReadLine(), out int selection))
                {
                    // Jag valde en switch för att det passar bra att använda till en meny.
                    switch (selection)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.Write("Note: ");
                                // När användaren vill skapa en ny anteckning skapas en ny array med två element som innehåller anteckningen och datum.
                                string[] note = new string[2];
                                // Anteckningen läggs till i listan notes.
                                notes.Add(note);
                                // Användaren skriver in sin anteckning och den sparas i arrayen.
                                note[0] = Console.ReadLine();
                                // Datumet sparas i en string som sen sparas i arrayen.
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
                                // För varje array i notes loopas kodblocket.
                                foreach (string[] item in notes)
                                {
                                    // En metod för att skriva ut anteckningar.
                                    WriteNotes(item, notes, user1);
                                }
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                Console.Write("Search: ");
                                // Programmet läser in användarens sökning.
                                string search = Console.ReadLine();
                                // Kodblocket loopas tills i är lika med antalet arrayer i listan notes.
                                for (int i = 0; i < notes.Count; i++)
                                {
                                    // Om sökningen stämmer med en av titlarna så skrivs den anteckningen ut.
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
                                // En metod för att ta bort anteckningar.
                                Remove(notes);
                                break;
                            }
                        case 5:
                            {
                                Console.Clear();
                                Console.WriteLine("Closing notes.");
                                // Boolen menu blir falsk och programmet avslutas.
                                menu = false;
                                System.Threading.Thread.Sleep(1000);
                                break;
                            }
                        default:
                            {
                                // En metod till när användaren skriver in något fel.
                                WrongInput();
                                break;
                            }
                    }
                }
                else
                {
                    // En metod till när användaren skriver in något fel.
                    WrongInput();
                }
            }
        }
    }
}
