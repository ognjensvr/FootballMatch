var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddMvc()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.WriteIndented = true;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(b => b.AllowAnyHeader().AllowAnyMethod().AllowCredentials().SetIsOriginAllowed(o => true));
app.UseAuthentication();
app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();