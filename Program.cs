using CQRSTest;
using CQRSTest.Requests;
using FluentValidation;
using MediatR;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//mediatR
//builder.Services.AddMediatR(typeof(Application.AssemblyReference).Assembly);
//builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
//builder.Services.AddValidatorsFromAssembly(typeof(Application.AssemblyReference).Assembly);
//builder.Services.AddTransient<ExceptionHandlingMiddleware>();




//builder.Services.AddMediatR(x => x.AsScoped(),typeof(Program));
//https://www.youtube.com/watch?v=euUg_IHo7-s



var app = builder.Build();

//app.MapGet("exGetInProgram/{name}", ([AsParameters] ExRequest request) =>
//{
  

//);
//});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//app.MediateGet<ExampleRequest>("example/{name}");

app.Run();


