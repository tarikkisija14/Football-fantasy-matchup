using FootballFantasyMatchup;
using FootballFantasyMatchup.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<FootballFantasyMatchup.FootballApiSettings>(
    builder.Configuration.GetSection("FootballApi"));

var allowedOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>() ?? Array.Empty<string>();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("DevCors", p =>
        p.WithOrigins(allowedOrigins)
         .AllowAnyHeader()
         .AllowAnyMethod());
});
builder.Services.AddSwaggerGen();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddHttpClient<FootballApiClient>();
builder.Services.AddScoped<IPlayerService, PlayerService>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseCors("DevCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
