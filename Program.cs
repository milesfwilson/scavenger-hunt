using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ScavengerHunt
{

  interface IOpenable
  {
    void open();
  }


  public class Item
  {
    public Item(string name)
    {
      Name = name;
    }
    public string Name { get; set; }
  }

  public class Player
  {
    public Player(string name)
    {
      Name = name;
    }

    public string Name { get; set; }

    public List<Item> Inventory { get; set; }

    public string move()
    {
      return $"{Name} Moved!";
    }

    public string addItemToInventory(Item item)
    {
      //   Inventory.Add(item);
      return $"{item.Name} has been added to your inventory";
    }

  }

  public class Location
  {
    public string Name { get; set; }

    public List<Item> Inventory { get; set; }

  }


  public class Neighborhood
  {
    public List<Item> itemMasterList { get; set; }

    public void addItemsToMasterInventory()
    {
      string[] items = { "Penny Collection", "iMac", "Laptop", "Guitar", "Cowboy Hat" };
      for (int i = 0; i < items.Length; i++)
      {
        Item item = new Item(items[i]);
        itemMasterList.Add(item);
      }

    }

  }

  public class PlayGame
  {


    public static void sayHello()
    {
      Console.WriteLine("What is your name?");
      string userInput = Console.ReadLine();

      //   Neighborhood neighborhood = new Neighborhood();
      //   neighborhood.addItemsToMasterInventory();

      Player player = new Player(userInput);
      Console.WriteLine($"Hello {player.Name}!");

      bool running = true;
      while (running)
      {

        Console.WriteLine("What would you like to do?");
        string action = Console.ReadLine();

        switch (action)
        {
          case "q":
            running = false;
            break;
          case "m":
            Console.WriteLine(player.move());
            break;
          case "a":
            Item item = new Item("Pie");
            Console.WriteLine(player.addItemToInventory(item));
            break;
          default:
            Console.WriteLine("Please Enter a valid key");
            break;
        }
      }
      Console.WriteLine("Game Over!");

    }

  }


  public class Program
  {
    public static void Main(string[] args)
    {
      PlayGame.sayHello();
    }
  }
}
