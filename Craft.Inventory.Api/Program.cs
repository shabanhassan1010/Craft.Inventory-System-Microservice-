using Craft.Inventory.Infastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen(); // ?? Add this


#region DbContext Connection
var InventoryDbContext = builder.Configuration.GetSection("ConnectionStrings:InventoryDBConnection");
builder.Services.AddInventoryDbContext(InventoryDbContext.Value!);
builder.Services.AddInfrastructureRegistrations();

#endregion

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();       // ?? Must come first
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API v1");
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
