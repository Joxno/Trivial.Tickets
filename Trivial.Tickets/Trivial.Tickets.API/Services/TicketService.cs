using Trivial.Tickets.API.Interfaces;
using Trivial.Tickets.API.Models;
using Trivial.Tickets.Utility;

namespace Trivial.Tickets.API.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository m_Repo;
        public TicketService(ITicketRepository Repo) => m_Repo = Repo;
        public Maybe<Ticket> GetTicketById(long Id) =>
            m_Repo.GetTickets().FirstOrDefault(T => T.Id == Id);

    }
}
