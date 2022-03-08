using System;
using CoinTracker.Dal.Models;

namespace CoinTracker.Dal.Services
{
    public interface IDalService
    {
        Task<GenericCoinReading> TryWriteSingle(GenericCoinReading genericCoinReading);
        Task<List<GenericCoinReading>> TryWriteMany(List<GenericCoinReading> genericCoinReading);
        Task<GenericCoinReading> TryReadSingle(DateTime date);
        Task<List<GenericCoinReading>> TryReadMany(DateTime startAt, DateTime endAt);
    }   
}

