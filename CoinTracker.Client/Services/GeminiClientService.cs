using System;
using CoinTracker.Client.Gemini;
using CoinTracker.Client.Interfaces;
using CoinTracker.Client.Models;
using CoinTracker.Models;

namespace CoinTracker.Client.Services
{
    public class GeminiClientService : IGeminiClientService
    {
        private readonly IGeminiClient _geminiClient;

        public GeminiClientService(GeminiClient geminiClient)
        {
            _geminiClient = geminiClient;
        }

        public async Task<CoinTrackerResponse<GeminiResponse>> TryGetSymbols()
        {
            return await _geminiClient.GetSymbols();
        }

        public async Task<CoinTrackerResponse<GeminiResponse>> TryGetTickerSymbol(string symbol)
        {
            return await _geminiClient.GetTickerSymbol(symbol);
        }
    }
}

