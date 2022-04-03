using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trivial.Tickets.API.Repositories;
using Trivial.Tickets.API.Services;

namespace Trivial.Tickets.API.Tests
{
    [TestClass]
    public class TicketServiceTests
    {
        [TestMethod]
        public void EmptyServiceShouldNotReturnATicket()
        {
            var t_Service = new TicketService(new InMemoryTicketRepository());

            var t_Ticket = t_Service.GetTicketById(0);

            t_Ticket.Should().NotBeNull();
            t_Ticket.HasValue.Should().BeFalse();
        }
    }
}