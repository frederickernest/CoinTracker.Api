using System;
namespace CoinTracker.Dal.Models
{
    public class GenericCoinReading : IGenericCoinReading
    {
        public GenericCoinReading(string origin, string name, int priceUsd, DateTime timeRecorded)
        {
            Id = Guid.NewGuid();
            Origin = origin;
            Name = name;
            PriceUsd = priceUsd;
            TimeRecorded = timeRecorded;
            TimeRelayed = DateTime.Now;
        }

        public enum DataSources
        {
            Gemini,
            TinyMan,
            Coinbase

        }

        public int GenericCoinReadingId { get; set; }
        public Guid Id { get; set; }
        public string Origin { get; set; }
        public string Name { get; set; }
        public int PriceUsd { get; set; }
        public DateTime TimeRecorded { get; set; }
        public DateTime TimeRelayed { get; set; }
    }
}

