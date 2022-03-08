using System;
using CoinTracker.Client.Gemini;
using CoinTracker.Client.Interfaces;
using CoinTracker.Client.Models;

namespace CoinTracker.Client.Services
{
    public class GeminiClientService : IGeminiClientService
    {
        private GeminiClient _geminiClient;

        public GeminiClientService(GeminiClient geminiClient)
        {
            _geminiClient = geminiClient;
        }

        public async Task<List<string>> TryGetSymbols()
        {
            return await _geminiClient.GetSymbols();
        }

        public async Task<GeminiResponse> TryGetTickerSymbol(string symbol)
        {
            return await _geminiClient.GetTickerSymbol(symbol);
        }
    }
}

