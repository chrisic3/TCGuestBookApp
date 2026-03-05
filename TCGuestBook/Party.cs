using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCGuestBook
{
    public static class Party
    {
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("-----------------------------------------------");
        }

        public static Dictionary<string, int> GetPartyInfo()
        {
            Dictionary<string, int> guestBook = new Dictionary<string, int>();

            do
            {
                string name = GetPartyName();

                int partyCount = GetPartyCount();

                guestBook.Add(name, partyCount);

                // Optional way without variables
                //guestBook.Add(GetPartyName(), GetPartyCount());
            } while (AskToContinue());

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

        public static void Goodbye()
        {
            Console.WriteLine("\nThank you for using the Guest Book App");
            Console.WriteLine("Goodbye");
        }

        private static string GetPartyName()
        {
            Console.Write("\nEnter the name of the party: ");
            string output = Console.ReadLine();

            return output;
        }

        private static int GetPartyCount()
        {
            bool isValid = false;
            int output = 0;

            do
            {
                Console.Write("How many are in your party: ");
                string partyCountString = Console.ReadLine();

                isValid = int.TryParse(partyCountString, out output);

                if (!isValid)
                {
                    Console.WriteLine($"\"{partyCountString}\" is not a valid " +
                        $"number. Please try again");
                }
            } while (!isValid);

            return output;
        }

        private static bool AskToContinue()
        {
            Console.Write("\nIs there another party to enter? (y/n): ");
            string output = Console.ReadLine();

            return output.ToLower() == "y";
        }
    }
}
