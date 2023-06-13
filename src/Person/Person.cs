public abstract class Person
{
    private string _name; 
    private int _id;

    public Person(string Name, int Id)
    {
        _name = Name;
        _id = Id;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string value)
    {
        _name = value;
    }
  
}

