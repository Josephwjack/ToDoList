using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Models;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      List<Item> toDoList = new List<Item>{};
      Console.WriteLine("Welcome to To Do List!");
      Console.WriteLine("Would you like to add an item to your list or view your list?(add/view)");
      string response = Console.ReadLine();
      if (response == "add")
      {
        Console.WriteLine("Please enter the description for the new item:");
        string task = Console.ReadLine();
        Item newItem = new Item(task);
        Console.WriteLine("" + newItem.Description +""+ " has been added to the list. Would you like to add to or view your list?(add/view)");
        
      }
      else if (response == "view")
      {

        Console.WriteLine("Here is your current list");
        var listItems = Item.GetAll();
        // List<Item> fullList = Item.GetAll();
        foreach (Item element in listItems)
        {
          Console.WriteLine(element.Description);
        }   
      }
      else {
        Console.WriteLine("Restart Program");
      }
      Main();
    }
  }
}