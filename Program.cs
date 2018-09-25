using System;
using ConsoleTheater.Models;

namespace ConsoleTheater
{
  class Program
  {
    static void Main(string[] args)
    {
      Theater myTheater = new Theater("Movietown");
      myTheater.Initialize();
      Movie titanic = new Movie("Titanic");
      // myTheater.Movies.Add(titanic);
      System.Console.WriteLine($"Welcome to {myTheater.Name} Please select a movie:");
      myTheater.AddRoom(titanic, 100);
      myTheater.AddShowtime("12:00", 0);
      myTheater.AddShowtime("3:00", 0);
      myTheater.AddShowtime("5:20", 0);
      myTheater.AddShowtime("8:30", 0);
      Movie sing = new Movie("Sing");
      myTheater.AddRoom(sing, 80);
      myTheater.AddShowtime("12:00", 1);
      myTheater.AddShowtime("3:00", 1);
      myTheater.AddShowtime("5:20", 1);
      myTheater.AddShowtime("8:30", 1);
      Movie denofthieves = new Movie("Den of Thieves");
      myTheater.AddRoom(denofthieves, 50);
      myTheater.AddShowtime("11:30", 2);
      myTheater.AddShowtime("2:00", 2);
      myTheater.AddShowtime("5:15", 2);
      myTheater.AddShowtime("8:00", 2);
      myTheater.PrintMovies();
      var userInput = Console.ReadLine();
      if (Int32.TryParse(userInput, out int choice))
      {
        //   Theater.pickmovie(userInput)
        switch (choice)
        {
          case 1:
            // BuyTickets();
            Console.WriteLine("You chose Titanic -- What a classic!");
            Console.WriteLine("What showtime would you like?");
            break;
          case 2:
            // BuyTickets();
            Console.WriteLine("Sing -- A fun family movie!");
            Console.WriteLine("What showtime would you like?");
            break;
          case 3:
            // BuyTickets();
            Console.WriteLine("Den of Thieves -- Cops and Robbers!");
            Console.WriteLine("What showtime would you like?");
            break;
          case 4:
          default:
            System.Console.WriteLine("We are not showing that movie currently, please try again.");
            userInput = Console.ReadLine();
            break;
        }
      }
    }
  }
}
