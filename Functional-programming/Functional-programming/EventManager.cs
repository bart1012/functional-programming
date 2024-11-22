namespace Functional_programming
{
    public class EventManager
    {
        public List<LiveEvent> Events { get; private set; }

        public void AddEvent(LiveEvent eventInfo)
        {

            Events.Add(eventInfo);
            Console.WriteLine("Event added successfully.");
        }

        public string RetrieveEventInformation(string name)
        {
            return Events.Where(obj => obj.Name == name).ToList()[0].ToString();
        }
    }
}
