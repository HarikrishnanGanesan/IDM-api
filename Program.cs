using Microsoft.EntityFrameworkCore;
using IDMApi.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddLogging();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Configure Database

  var DefaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");
  builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(DefaultConnection));

#endregion
builder.Services.AddCors(options =>
{
    options.AddPolicy("Mypolicy",a => a.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
  });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(option => 
{
  option.AllowAnyOrigin().
  AllowAnyMethod().
  AllowAnyHeader();
});

app.UseCors("Mypolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
