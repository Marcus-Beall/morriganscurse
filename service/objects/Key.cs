namespace morriganscurse.Objects
{
  class Key : Item
  {

    public Key(string name, string description) : base(name, description)
    {

    }

    public override bool Use()
    {
      return true;
    }
  }
}