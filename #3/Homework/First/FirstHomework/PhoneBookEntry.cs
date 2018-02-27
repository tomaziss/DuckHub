namespace FirstHomework
{
    public class PhoneBookEntry
    {
        public PhoneBookEntry(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; }
        public int Number { get; }
    }
}
