using System;
using CoinTracker.Dal.Models;

namespace CoinTracker.Dal
{
    public interface ICoinTrackerDal
    {
        Task<GenericCoinReading> WriteSingle(GenericCoinReading genericCoinReading);
        Task<List<GenericCoinReading>> WriteMany(List<GenericCoinReading> genericCoinReading);
        Task<GenericCoinReading> ReadSingle(DateTime date);
        Task<List<GenericCoinReading>> ReadMany(DateTime startAt, DateTime endAt);
    }
}

