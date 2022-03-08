using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CoinTracker.Dal;
using CoinTracker.Dal.Services;
using CoinTracker.Client.Services;
using CoinTracker.Client.Interfaces;
using CoinTracker.Client.Gemini;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CoinTrackerDbContext>(
    options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("AzureSqlEdge"),
            x => x.MigrationsAssembly("CoinTracker.Api")));

//TODO: Configure redis cache.
//builder.Services.AddStackExchangeRedisCache(options =>
//{
//    options.Configuration = builder.Configuration.GetConnectionString("RedisConStr");
//    options.InstanceName =  $"RedisCacheId: {Guid.NewGuid}";
//});

builder.Services.AddSingleton<IDalService>(services =>
{
    var optsBuilder = new DbContextOptionsBuilder<CoinTrackerDbContext>();
    var coinTrackerDal = new CoinTrackerDal(new CoinTrackerDbContext(optsBuilder.Options));
    return new DalService(coinTrackerDal);
});

builder.Services.AddSingleton<IGeminiClientService>(services =>
{
    var httpClient = new HttpClient();
    var geminiClient = new GeminiClient(httpClient);
    return new GeminiClientService(geminiClient);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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



