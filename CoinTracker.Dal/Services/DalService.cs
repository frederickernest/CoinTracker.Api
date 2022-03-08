using System;
using CoinTracker.Dal.Models;

namespace CoinTracker.Dal.Services
{
    public class DalService : IDalService
    {
        public DalService(CoinTrackerDal coinTrackerDal)
        {
            _coinTrackerDal = coinTrackerDal;
        }

        private CoinTrackerDal _coinTrackerDal;

        public async Task<GenericCoinReading> TryWriteSingle(GenericCoinReading genericCoinReading)
        {
            var response = await _coinTrackerDal.WriteSingle(genericCoinReading);
            return response;
        }
        public async Task<List<GenericCoinReading>> TryWriteMany(List<GenericCoinReading> genericCoinReadingList)
        {
            var response = await _coinTrackerDal.WriteMany(genericCoinReadingList);
            return response;
        }
        public async Task<GenericCoinReading> TryReadSingle(DateTime date)
        {
            var response = await _coinTrackerDal.ReadSingle(date);
            return response;
        }
        public async Task<List<GenericCoinReading>> TryReadMany(DateTime startAt, DateTime endAt)
        {
            var response = await _coinTrackerDal.ReadMany(startAt, endAt);
            return response;
        }
    }
}

