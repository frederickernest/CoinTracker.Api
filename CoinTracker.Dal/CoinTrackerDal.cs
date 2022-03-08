using System;
using CoinTracker.Dal.Models;

namespace CoinTracker.Dal
{
    public class CoinTrackerDal : ICoinTrackerDal
    {
        public readonly CoinTrackerDbContext _context;

        public CoinTrackerDal(CoinTrackerDbContext coinTrackerDbContext)
        {
           _context = coinTrackerDbContext;
        }

        public async Task<GenericCoinReading> WriteSingle(GenericCoinReading genericCoinReading)
        {
            return genericCoinReading;
        }

        public async Task<List<GenericCoinReading>> WriteMany(List<GenericCoinReading> genericCoinReadings)
        {
            genericCoinReadings.ForEach(async cr =>
            {
                await _context.AddAsync(cr);
            }
            );
            return genericCoinReadings;
        }

        public async Task<GenericCoinReading> ReadSingle(DateTime date)
        {
            return _context
                .CoinReadings
                .Single(c => c.TimeRecorded == date);
               
        }

        public async Task<List<GenericCoinReading>> ReadMany(DateTime startAt, DateTime endAt)
        {
            return _context
                .CoinReadings.Where(cr => cr.TimeRecorded >= startAt && cr.TimeRecorded <= endAt)
                .ToList();
        }
    }
}