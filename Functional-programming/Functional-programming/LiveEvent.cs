namespace Functional_programming
{
    public class LiveEvent
    {
        private static int IDGenerator = 0;
        public int ID { get; }
        public string Name { get; private set; }
        public string Date { get; private set; }
        public string Venue { get; private set; }
        public int TicketAvailability { get; private set; }

        public LiveEvent(string name, string date, string venue)
        {
            IDGenerator++;
            ID = IDGenerator;
            Name = name;
            Date = date;
            Venue = venue;
        }

        public override string? ToString()
        {
            return $"Name: {Name}\nDate: {Date}\n Venue: {Venue}\n";
        }
    }
}
