using TCGuestBook;

Console.WriteLine("Welcome to the Guest Book App");
Console.WriteLine("-----------------------------------------------");

Dictionary<string, int> guestBook = Party.GetPartyInfo();

Party.PrintGuestBookInfo(guestBook);

Console.WriteLine("\nThank you for using the Guest Book App");
Console.WriteLine("Goodbye");

Console.ReadLine();