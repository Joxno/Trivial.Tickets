using Trivial.Tickets.API.Interfaces;
using Trivial.Tickets.API.Models;

namespace Trivial.Tickets.API.Repositories
{
    public class InMemoryTicketRepository : ITicketRepository
    {
        private readonly List<Ticket> m_Tickets = new List<Ticket>();
        public IEnumerable<Ticket> GetTickets() =>
            m_Tickets;

        public void Save(Ticket Ticket)
        {
            m_Tickets.Add(Ticket);
        }
    }
}
