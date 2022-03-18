using System;
using CoinTracker.Client.Models;
using CoinTracker.Models;

namespace CoinTracker.Client.Interfaces
{
    public interface IGeminiClientService
    {
        Task<CoinTrackerResponse<GeminiResponse>> TryGetSymbols();
        Task<CoinTrackerResponse<GeminiResponse>> TryGetTickerSymbol(string symbol);
        Task<CoinTrackerResponse<GeminiResponse>> TryGetCandles(string symbol, string interval);
    }
}

