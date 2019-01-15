using System;
using morriganscurse.Models;
using morriganscurse.Service;

namespace morriganscurse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Morrigan's Curse";
      Console.Clear();
      Console.WriteLine(@"'What have we here?' A woman's voice asks coldly.
'A new plaything?'
'What is your name?'");
      string name = Console.ReadLine();
      bool standing = false;
      Player newPlayer = new Player(name, standing);
      Console.Clear();
      Console.WriteLine($@"'{newPlayer.Name}...'
'You'll join the others.'");
      Console.ReadKey();
      Console.Clear();
      Console.WriteLine(@"You wake up in a small room, laying on a bed barely large enough to fit you. 
As far you can tell there is nothing else in the room besides a door directly in front of you.
What would you like to do?");
      Bedroom game = new Bedroom(newPlayer);
      game.Start();
    }
  }
}
