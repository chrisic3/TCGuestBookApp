using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCGuestBook
{
    public static class Party
    {
        public static Dictionary<string, int> GetPartyInfo()
        {
            bool isDone = false;
            Dictionary<string, int> guestBook = new Dictionary<string, int>();

            do
            {
                Console.Write("\nEnter the name of the party: ");
                string name = Console.ReadLine();

                Console.Write("How many are in your party: ");
                string partyCountString = Console.ReadLine();

                bool isInt = int.TryParse(partyCountString, out int partyCountInt);
                
                if (!isInt)
                {
                    Console.WriteLine($"\"{partyCountString}\" is not a number. " +
                        $"Please try again");
                }

                guestBook[name] = partyCountInt;

                Console.Write("\nIs there another party to enter? (y/n): ");
                string anotherParty = Console.ReadLine();

                if (anotherParty.ToLower() == "n")
                {
                    isDone = true;
                }
            } while (!isDone);

            return guestBook;
        }

        public static void PrintGuestBookInfo(Dictionary<string, int> guestBook)
        {
            Console.WriteLine();

            foreach (string name in guestBook.Keys)
            {
                Console.WriteLine(name);
            }

            int total = 0;

            foreach (int count in guestBook.Values)
            {
                total += count;
            }

            Console.WriteLine($"\nTotal guests: {total}");
        }
    }
}
