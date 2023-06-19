namespace LibraryManagement
{
    public abstract class Person
    {
        private string name;
        private int id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Person(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}




