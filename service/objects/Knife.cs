namespace morriganscurse.Objects
{
  class Knife : Item
  {
    public Knife(string name, string description) : base(name, description)
    {
      Name = name;
      Description = description;
    }
    override public bool Use()
    {
      Console.WriteLine(@"You go up to the door and notice a small hole on the door just large enough for the knife's blade.
You put the knife in the hole and the door swings outward, 
revealing a large septagonal room with six other doors.");
      Move("door");
    }
  }
}