namespace Trivial.Tickets.API.Models
{
    public class Event
    {
        public long Id { get; set; }
        public DateTime EventTime { get; set; }
        public string EventType { get; set; } = "";

    }
}
