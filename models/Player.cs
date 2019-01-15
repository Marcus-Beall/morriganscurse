using System;
using System.Collections.Generic;
using morriganscurse.Objects;

namespace morriganscurse.Models
{
  class Player
  {
    public string Name { get; set; }
    public string Color { get; set; }
    public string Place { get; set; }
    public string Animal { get; set; }
    public bool Standing { get; set; }
    public Dictionary<string, Item> Inventory { get; set; } = new Dictionary<string, Item>();
    public Player(string name, bool standing)
    {
      Name = name;
      Standing = standing;
    }
    public void addItem(string type, Item item)
    {
      Inventory.Add(type, item);
    }
    public void showInventory()
    {
      Console.Clear();
      foreach (var item in Inventory)
      {
        if (Inventory.Count == 0)
        {
          Console.WriteLine("You don't have any items yet.");
        }
        else
        {
          Console.WriteLine($"{item.Value.Name} - Description: {item.Value.Description}");
        }

      }
    }
    public void changeColor(Player player, string color)
    {
      player.Color = color;
    }
    public void changePlace(Player player, string place)
    {
      player.Place = place;
    }
    public void changeAnimal(Player player, string animal)
    {
      player.Animal = animal;
    }
    public bool isStanding()
    {
      return Standing = !Standing;
    }
    public bool HasItem(string type)
    {
      if (Inventory.ContainsKey(type))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

}