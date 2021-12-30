using e_coach_dal.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddCommandLine(args);

builder.Services.AddDbContext<CoachContext>(opts =>
{
    var connectionString = builder.Configuration.GetConnectionString("ecoachconn");
    opts.UseSqlServer(connectionString);
});

var app = builder.Build();
app.Run();
