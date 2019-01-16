using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using morriganscurse.Interfaces;
using morriganscurse.Models;
using morriganscurse.Objects;

namespace morriganscurse.Service
{
  class Bedroom : IGame
  {
    public Player currentPlayer { get; set; }
    public Dictionary<string, IGame> Rooms { get; set; } = new Dictionary<string, IGame>();
    public void Help()
    {
      Console.Clear();
      Console.WriteLine(@"Suggested commands:
Show Inventory
Inspect
Move
Open
Use
Talk");
    }

    public void Move(string door)
    {
      MainRoom mainRoom = new MainRoom(currentPlayer);
      if (door.Contains("door"))
      {
        mainRoom.Look();
        mainRoom.Start();
      }
    }
    public void Look()
    {
      Console.WriteLine(@"You're in a small, square room with a bed in the middle.
Directly across from the foot of the bed is the door.
The walls are a faded white, stained in places from years of wear. 
The floor is a series of wood panelling, or it was. 
Now it looks as though you might fall through it at any moment.");
    }
    public void Setup()
    {
    }

    public void Start()
    {
      string answer;
      bool action = true;
      while (action)
      {

        Knife knife = new Knife("Strange Knife", "A knife with a strange red handle a bronze blade.");
        answer = Console.ReadLine().ToLower();
        if (answer.Contains("sleep"))
        {
          Console.Clear();
          Console.WriteLine(@"As you start to go back to sleep, you hear the woman's voice again. 
'Don't wish to play? Then you have already lost.' ");
          Console.ReadKey();
          Console.Clear();
          Console.WriteLine("Game Over");
          break;
        }
        else if (currentPlayer.HasItem("knife") && answer.Contains("knife") && answer.Contains("use"))
        {
          Console.WriteLine("Where would you like to use the knife?");
          answer = Console.ReadLine();
          if (answer.Contains("door"))
          {
            currentPlayer.UseItem("knife");
          }
        }
        else if (!currentPlayer.HasItem("knife") && answer.Contains("knife") && answer.Contains("take"))
        {

          currentPlayer.addItem("knife", knife);
        }
        else if (!currentPlayer.Standing && answer.Contains("look") || answer.Contains("inspect") || answer.Contains("study"))
        {
          if (answer.Contains("bed") && answer.Contains("under"))
          {
            Console.Clear();
            Console.WriteLine(@"You look under the bed to see an inky blackness. 
For some reason you don't feel like you should go under there.");
          }
          else if (answer.Contains("bed"))
          {
            if (!currentPlayer.HasItem("knife"))
            {
              Console.Clear();
              Console.WriteLine(@"You notice a small bump on the side of the bed.
On after looking closer you see it's the handle of a knife.");
            }
            else
            {
              Console.Clear();
              Console.WriteLine(@"You don't see anything else unusual about the bed itself.");
            }
          }
          else if (currentPlayer.HasItem("knife") && answer.Contains("door"))
          {
            Console.WriteLine(@"The door is a dark grey and worn.
You can't see any visible way to open it.
On closer inspection, there seems to be a small hole, large enough for the knife's blade to fit in.");
          }
          else
          {
            Console.Clear();
            Console.WriteLine(@"You look around the room. 
The walls are a faded white, stained in places from years of wear. 
The floor is a series of wood panelling, or it was. 
Now it looks as though you might fall through it at any moment.");
          }
        }

        else if (answer.Contains("door"))
        {
          Console.Clear();
          Console.WriteLine("What would you like to do with the door?");
          currentPlayer.isStanding();
        }
        else if (!currentPlayer.Standing && answer.Contains("stand") || answer.Contains("get up") && answer.Contains("look") || answer.Contains("inspect") || answer.Contains("study"))
        {
          if (answer.Contains("bed") && answer.Contains("under"))
          {
            Console.Clear();
            Console.WriteLine(@"You look under the bed to see an inky blackness. 
For some reason you don't feel like you should go under there.");
          }
          else if (answer.Contains("bed"))
          {
            if (!currentPlayer.HasItem("knife"))
            {
              Console.Clear();
              Console.WriteLine(@"You notice a small bump on the side of the bed.
On after looking closer you see it's the handle of a knife.
You decide to take it with you.");
            }
            else
            {
              Console.Clear();
              Console.WriteLine(@"You don't see anything else unusual about the bed itself.");
            }
          }
          else if (answer.Contains("door"))
          {
            Console.Clear();
            Console.WriteLine(@"The door is a dark grey and worn.
You can't see any visible way to open it.
Nothing else seems remarkable about it.");
          }

          else
          {
            Console.Clear();
            Console.WriteLine(@"You look around the room. 
The walls are a faded white, stained in places from years of wear. 
The floor is a series of wood panelling, or it was. 
Now it looks as though you might fall through it at any moment.");
          }
        }
        else if (answer.Contains("door"))
        {
          Console.Clear();
          Console.WriteLine("What would you like to do with the door?");
        }
        else if (!currentPlayer.Standing && answer.Contains("stand") || answer.Contains("get up"))
        {
          Console.Clear();
          Console.WriteLine(@"You're already standing.
What would you like to do?");
        }
        else if (currentPlayer.Standing && answer.Contains("stand") || answer.Contains("get up"))
        {
          Console.Clear();
          Console.WriteLine(@"You get out of the bed and stand up.
What would you like to do?");
          currentPlayer.isStanding();
        }
        else if (!currentPlayer.Standing && answer.Contains("open") && answer.Contains("door"))
        {
          if (!currentPlayer.HasItem("knife"))
          {
            Console.WriteLine(@"There doesn't seem to be any way to open the door.
What would you like to do?");
          }
        }
        else if (answer.Contains("show inventory"))
        {
          ShowInventory();
        }
        else if (answer.Contains("help"))
        {
          Help();
        }
        else if (currentPlayer.Standing)
        {
          Console.Clear();
          Console.WriteLine(@"What's that supposed to mean...
Maybe you should start by getting up?
What do you want to do?");
        }
        else
        {
          Console.Clear();
          Console.WriteLine(@"What's that supposed to mean...
What do you want to do?");
        }
      }
    }
    public void Reset()
    {
    }
    public void ShowInventory()
    {
      currentPlayer.showInventory();
    }

    public Bedroom(Player player)
    {
      currentPlayer = player;
    }
  }

}


