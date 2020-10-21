namespace ComitLibrary
{
    public class Patron
    {
        public Patron(long id, string firstName, string lastName) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public long Id { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

    }
}