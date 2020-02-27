using System;
using System.Collections.Generic;
using Park.Models;

namespace Park 
{
  public class Program
  {
    public static void Main()
    {
      Animal giraffe = new Animal("land", "Bridgette", 13, "Africa", "Acacia");
      Animal flamingo = new Animal("sky", "Pinkerton", 14,"South America", "shrimp");
      Animal octopus = new Animal("sea", "Socrates", 32, "Greece", "fish");

      List<Animal> Animals = new List<Animal>() { giraffe, flamingo, octopus };

      Console.WriteLine("Search by Name");
      string nameInput = Console.ReadLine();

      List<Animal> SearchingByName = new List<Animal>(0);

      foreach(Animal wildlife in Animals)
      {
        if (wildlife.SearchAnimal(nameInput))
        {
          SearchingByName.Add(wildlife);
        }
      }

      foreach(Animal wildlife in SearchingByName)
      {
        Console.WriteLine("___________________");
        Console.WriteLine(wildlife.GetName());
        Console.WriteLine(wildlife.GetType());
        Console.WriteLine(wildlife.GetAge());
        Console.WriteLine(wildlife.GetNative());
        Console.WriteLine(wildlife.GetFood());
      }
  
      Console.WriteLine("Do you want to search an animal? Select 1 for yes or 2 for no");
      string answer = Console.ReadLine();
      if (answer == "1")
      {
        SearchAnimal();
      }
       else Console.WriteLine("Would you like to add an animal? Select 1 for yes or select 2 for no");
       string addAnswer = Console.ReadLine();
       if (answer == "1")
       {
         AddAnimal();
       }
       else 
       {
         Console.WriteLine("Are you finished with this program? 1 for yes, 2 for no");
         string doneAnswer = Console.ReadLine();
        if (doneAnswer == "1")
        {
          Console.WriteLine("See ya never!");
        }
        else
        {
          Main();
        }
       }
      public void AddAnimal()
      {
          Console.WriteLine("NEW ANIMAL");
          Console.WriteLine("Enter animal's type:");
          string type = Console.ReadLine();
          Console.WriteLine("Enter animal's name");
          string name = Console.Readline();
          Console.WriteLine("Enter animal's age");
          int age = Console.ReadLine();
          Console.WriteLine("Enter animal's native");
          string native = Console.ReadLine();
          Console.WriteLine("Enter animal's food");
          string food = Console.ReadLine();
        if (animals.ContainsKey(name))
        {
          animals.add(type, name, age, native, food);
        }
        else
        {
          Main();
        }
      }
    }
  }
}