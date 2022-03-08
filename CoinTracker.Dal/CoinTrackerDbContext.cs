using System;
using CoinTracker.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace CoinTracker.Dal
{
	public class CoinTrackerDbContext : DbContext
	{
        public CoinTrackerDbContext(DbContextOptions<CoinTrackerDbContext> options) : base(options) { }
        public DbSet<GenericCoinReading> CoinReadings { get; set; }
	}
}