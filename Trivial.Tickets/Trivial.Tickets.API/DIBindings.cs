using Trivial.Tickets.API.Interfaces;
using Trivial.Tickets.API.Repositories;
using Trivial.Tickets.API.Services;

namespace Trivial.Tickets.API
{
    public static class DIBindings
    {
        public static void ApplyBindings(WebApplicationBuilder Builder)
        {
            Builder.Services.AddScoped<ITicketService, TicketService>();
            Builder.Services.AddSingleton<ITicketRepository, InMemoryTicketRepository>();
        }
    }
}
