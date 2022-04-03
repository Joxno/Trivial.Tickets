using Trivial.Tickets.API;

var t_Builder = WebApplication.CreateBuilder(args);


t_Builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
t_Builder.Services.AddEndpointsApiExplorer();
t_Builder.Services.AddSwaggerGen();

DIBindings.ApplyBindings(t_Builder);

var t_App = t_Builder.Build();

if (t_App.Environment.IsDevelopment())
{
    t_App.UseSwagger();
    t_App.UseSwaggerUI();
}

t_App.UseHttpsRedirection();

t_App.UseAuthorization();

t_App.MapControllers();

t_App.Run();
