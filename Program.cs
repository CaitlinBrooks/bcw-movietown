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
      myTheater.AddRoom(denofthieves, 80);
      myTheater.AddShowtime("11:30", 2);
      myTheater.AddShowtime("2:00", 2);
      myTheater.AddShowtime("5:15", 2);
      myTheater.AddShowtime("8:00", 2);
      myTheater.PrintMovies();

    }
  }
}
