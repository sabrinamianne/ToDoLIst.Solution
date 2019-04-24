using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Greeting()
    {
      Console.WriteLine("Welcome to the To Do List");
    }
    public static void Main()
    {

        Console.WriteLine("Would you like to add an item to your list, view your list or leave the program?(Add/View/Q)");
        string userAnswer = Console.ReadLine();

        if (userAnswer =="add" || userAnswer == "Add")
        {
          Console.WriteLine("Please enter the description:  ");
          string descriptionUser = Console.ReadLine();
          Item newItem = new Item(descriptionUser);
          Console.WriteLine(descriptionUser+" has been added to your list.");
          Main();
        }
        else if (userAnswer == "view"||userAnswer == "View")
        {
          List<Item> result  = Item.GetAll();
          for (int i=0;i<result.Count; i++)
          Console.WriteLine("- "+result[i].GetDescription());
          Main();
        }
        else
        {
          Console.WriteLine("Good Bye");
        }
      }
    }
}
