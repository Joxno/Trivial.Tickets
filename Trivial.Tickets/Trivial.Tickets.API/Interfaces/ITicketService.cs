using Trivial.Tickets.API.Models;
using Trivial.Tickets.Utility;

namespace Trivial.Tickets.API.Interfaces
{
    public interface ITicketService
    {
        public Maybe<Ticket> GetTicketById(long Id);
    }
}
