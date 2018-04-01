

namespace HomeTask3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;
        }
    }
}
