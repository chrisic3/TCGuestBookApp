using TCGuestBook;

Party.WelcomeUser();

Dictionary<string, int> guestBook = Party.GetPartyInfo();

Party.PrintGuestBookInfo(guestBook);

Party.Goodbye();

Console.ReadLine();