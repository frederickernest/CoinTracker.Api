using System;
using CoinTracker.Client.Interfaces;
using CoinTracker.Client.Models;
using Newtonsoft.Json;

namespace CoinTracker.Client.Gemini
{
    public class GeminiClient : IGeminiClient
    {
        private HttpClient _client;

        public GeminiClient(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task<List<string>> GetSymbols()
        {
            _client.BaseAddress = new Uri(GeminiConstants.RootUrlV1);
            var response = await _client.GetAsync(GeminiConstants.Endpoints.symbols.ToString());
            return JsonConvert.DeserializeObject<List<string>>(response.Content.ToString());
        }

        public async Task<GeminiResponse> GetTickerSymbol(string symbol)
        {
            _client.BaseAddress = new Uri(GeminiConstants.RootUrlV2);
            var response = await _client.GetAsync(GeminiConstants.Endpoints.ticker.ToString() + symbol);
            return JsonConvert.DeserializeObject<GeminiResponse>(response.Content.ToString());
        }

        public void PostData()
        {

        }
    }
}