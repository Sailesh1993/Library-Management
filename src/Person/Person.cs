
public abstract class Person
{
    private string _name;
    private int _id;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int Id
    {
        get { return _id; }
    }
    public Person(string name, int id)
    {
        _name = name;
        _id = id;
    }
}



