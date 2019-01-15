using morriganscurse.Models;

namespace morriganscurse.Interfaces
{
  public interface IGame
  {
    void Start();
    void Setup();
    void Move(string direction);
    void Help();
    void ShowInventory();
  }
}