// this pnject will automactically handle the HTTP pipeline and routes for us
//which would be extremely difficult to do manually


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IPizzaRepositroy, PizzaRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


// all this swagger stuff is what auto creates your documents 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
