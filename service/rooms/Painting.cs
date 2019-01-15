using morriganscurse.Interfaces;
using morriganscurse.Models;

namespace morriganscurse.Service
{
  class Painting : IGame
  {
    public Player currentPlayer { get; set; }
    public void Help()
    {
      throw new System.NotImplementedException();
    }

    public void Move(string direction)
    {
      throw new System.NotImplementedException();
    }

    public void Setup()
    {
      throw new System.NotImplementedException();
    }

    public void ShowInventory()
    {
      throw new System.NotImplementedException();
    }

    public void Start()
    {
      throw new System.NotImplementedException();
    }
    public Painting(Player player)
    {
      currentPlayer = player;
    }
  }
}