using System;
using CoinTracker.Models;
using CoinTracker.Client.Models;

namespace CoinTracker.Client.Interfaces
{
    public interface IGeminiClient
    {
        Task<CoinTrackerResponse<GeminiResponse>> GetSymbols();
        Task<CoinTrackerResponse<GeminiResponse>> GetTickerSymbol(string symbol);
    }
}

