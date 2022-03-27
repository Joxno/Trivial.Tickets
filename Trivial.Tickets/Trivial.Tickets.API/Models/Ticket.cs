namespace Trivial.Tickets.API.Models
{
    public class Ticket
    {
        public long Id { get; set; } = 0;
        public TicketType Type { get; set; } = new TicketType { Id = -1, Name = "DEFAULT" };
        public TicketTemplate Template { get; set; } = new TicketTemplate();
        public TicketData Data { get; set; } = new TicketData();
    }
}
