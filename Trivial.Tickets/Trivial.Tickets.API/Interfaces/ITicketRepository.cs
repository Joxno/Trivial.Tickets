using Trivial.Tickets.API.Models;

namespace Trivial.Tickets.API.Interfaces
{
    public interface ITicketRepository
    {
        void Save(Ticket Ticket);
        IEnumerable<Ticket> GetTickets();
    }
}
