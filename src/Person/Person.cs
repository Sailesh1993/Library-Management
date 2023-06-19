namespace LibraryManagement
{
    public abstract class Person
    {
        private static int nextId = 1;
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

        public int Id { get; internal set; }

        public Person(string name)
        {
            Name = name;
            ID = nextId++;
        }
    }
}




