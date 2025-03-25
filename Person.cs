namespace libraryManagementSystem
{
    public class Person
    {
        static void Main(string[] args)
        {
            public class Person
        {
            public string Name;
            public string Email;
            public string ID;

            public Person(string name, string email, string id)
            {
                Name = name;
                Email = email;
                ID = id;
            }


            public virtual string ToPatronString()
            {
                return $"Name: {Name}, ID: {ID}";
            }


            public override string ToString()
            {
                return $"Name: {Name}, Email: {Email}, ID: {ID}";
            }

        }
    }
    }
}
