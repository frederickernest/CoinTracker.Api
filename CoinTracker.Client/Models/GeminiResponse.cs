using System;
namespace CoinTracker.Client.Models
{
    public class GeminiResponse
    {
        public GeminiResponse()
        {

        }

        public GeminiResponse(List<string> symbolsList)
        {
            SymbolsList = symbolsList;
        }

        public GeminiResponse(string symbol, string open, string high, string low,
            string close, List<string> changes, string bid, string ask)
        {
            Symbol = symbol;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Changes = changes;
            Bid = bid;
            Ask = ask;
        }

        public List<string>? SymbolsList { get; set; }

        public string? Symbol { get; set; }
        public string? Open { get; set; }
        public string? High { get; set; }
        public string? Low { get; set; }
        public string? Close { get; set; }
        public List<string>? Changes { get; set; }
        public string? Bid { get; set; }
        public string? Ask { get; set; }
        public string? TimeFrame { get; set; }
    }
}

