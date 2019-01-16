namespace morriganscurse.Objects
{
  abstract class Item
  {
    public string Name { get; set; }
    public string Description { get; set; }
    abstract public void Use();
    public Item(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }

}