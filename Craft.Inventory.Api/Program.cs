using Craft.Inventory.Infastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


#region DbContext Connection
var InventoryDbContext = builder.Configuration.GetSection("ConnectionStrings:InventoryDBConnection");
builder.Services.AddInventoryDbContext(InventoryDbContext.Value!);
#endregion

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
