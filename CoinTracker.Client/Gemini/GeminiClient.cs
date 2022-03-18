using System;
using CoinTracker.Client.Interfaces;
using CoinTracker.Client.Models;
using CoinTracker.Models;
using Newtonsoft.Json;

namespace CoinTracker.Client.Gemini
{
    public class GeminiClient : IGeminiClient
    {
        private readonly HttpClient _client;

        public GeminiClient(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task<CoinTrackerResponse<GeminiResponse>> GetSymbols()
        {
            var url = GeminiConstants.V1 + GeminiConstants.Symbols;
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var geminiResponse = new GeminiResponse(JsonConvert.DeserializeObject<List<string>>(await response.Content.ReadAsStringAsync()));
                return CoinTrackerResponse<GeminiResponse>.WithOk(geminiResponse);
            }
            return CoinTrackerResponse<GeminiResponse>.WithException(response);

        }

        public async Task<CoinTrackerResponse<GeminiResponse>> GetTickerSymbol(string symbol)
        {
            var url = GeminiConstants.V2 + GeminiConstants.Ticker + "/" + symbol;
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var geminiResponse = JsonConvert.DeserializeObject<GeminiResponse>(await response.Content.ReadAsStringAsync());
                return CoinTrackerResponse<GeminiResponse>.WithOk(geminiResponse);
            }
            return CoinTrackerResponse<GeminiResponse>.WithException(response);
        }

        public async Task<CoinTrackerResponse<GeminiResponse>> GetCandles(string symbol, string interval)
        {
            var url = GeminiConstants.V2 + GeminiConstants.Candles + "/" + symbol + "/" + interval;
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var geminiResponse = new GeminiResponse(JsonConvert.DeserializeObject<List<List<double>>>(await response.Content.ReadAsStringAsync()));
                return CoinTrackerResponse<GeminiResponse>.WithOk(geminiResponse);
            }
            return CoinTrackerResponse<GeminiResponse>.WithException(response);
        }


    }
}