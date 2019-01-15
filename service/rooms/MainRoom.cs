using System;
using morriganscurse.Interfaces;
using morriganscurse.Models;

namespace morriganscurse.Service
{
  class MainRoom : IGame
  {
    public Player currentPlayer { get; set; }
    public void Help()
    {
      throw new System.NotImplementedException();
    }

    public void Move(string door)
    {
      Bedroom one = new Bedroom(currentPlayer);
      Girl two = new Girl(currentPlayer);
      End three = new End(currentPlayer);
      Man four = new Man(currentPlayer);
      Painting five = new Painting(currentPlayer);
      Body six = new Body(currentPlayer);
      Woman seven = new Woman(currentPlayer);
      switch (door)
      {
        case "one":
          one.Start();
        case "two":
          two.Start();
        case "three":
          three.Start();
        case "four":
          four.Start();
        case "five":
          five.Start();
        case "six":
          six.Start();
        case "seven":
          seven.Start();
      }
    }

    public void Setup()
    {
      throw new System.NotImplementedException();
    }

    public void ShowInventory()
    {
      currentPlayer.showInventory();
    }
    public void Look()
    {
      Console.WriteLine(@"The room has seven doors.
      Each one has its own wall and a large number on it from 1-7.
      In the center of the room is a small table with a statue of a bird.
      From a distance it's hard to make out any details about the bird or doors.");
    }
    public void Start()
    {
      string answer;
      bool action = true;
      while (action)
      {
        answer = Console.ReadLine().ToLower();
        if (answer.Contains("look") || answer.Contains("inspect") || answer.Contains("study") || answer.Contains("go") && answer.Contains("bird") || answer.Contains("statue"))
        {
          Console.WriteLine(@"You look more closely at the statue.
Up close, you can see it is a statue of a raven.
Its wings are spread and it appears to be staring at the door with a large number 3 on it.
Both of its eyes have indents that seem to be missing pieces.
What would you like to do?");
        }
        else if (answer.Contains("look") || answer.Contains("inspect") || answer.Contains("study") && answer.Contains("door"))
        {
          if (answer.Contains("3") || answer.Contains("three"))
          {
            Console.WriteLine(@"You go up to the door with the number 3 on it.
It's a darker grey than the other doors and it doesn't have a handle anywhere.
It also looks newer than any of the other doors.");
          }
          else if (answer.Contains("1") || answer.Contains("one"))
          {
            Console.WriteLine(@"The door with the number 1 is the door you went through.
It remains open. Would you like to go back through?");
            answer = Console.ReadLine();
            if (answer.Contains("yes") || answer.Contains('y'))
            {
              Move(one);
            }
          }
          else if (answer.Contains("2") || answer.Contains("two"))
          {
            Console.WriteLine(@"The door is a faded grey.
It's largely unremarkable.
You can't see a way to open it from this side.
You can hear the faint sound of humming coming from behind the door.");
          }
          else if (answer.Contains("4") || answer.Contains("four"))
          {
            Console.WriteLine(@"The door is a faded grey.
It's largely unremarkable.
Would you like to go inside?");
          }
          else if (answer.Contains("5") || answer.Contains("five"))
          {
            Console.WriteLine(@"The door is a faded grey.
It's largely unremarkable.
Would you like to go inside?");
          }
          else if (answer.Contains("6") || answer.Contains("six"))
          {
            Console.WriteLine(@"The door is a faded grey.
It's largely unremarkable.
Would you like to go inside?");
          }
          else if (answer.Contains("7") || answer.Contains("seven"))
          {
            Console.WriteLine(@"The door is a faded grey.
It's largely unremarkable.
You can't seem to find a way to open it from this side.
You can hear the faint sound of crying on the other side.");
          }
        }
      }
    }

    public MainRoom(Player player)
    {
      currentPlayer = player;
    }
  }
}