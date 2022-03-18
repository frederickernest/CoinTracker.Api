using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoinTracker.Client.Interfaces;
using CoinTracker.Client.Models;
using CoinTracker.Client.Services;
using CoinTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoinTracker.Api.Controllers
{
    [Route("api/gemini")]
    public class GeminiController : Controller
    {
        private readonly IGeminiClientService _geminiClientService;

        public GeminiController(IGeminiClientService geminiClientService)
        {
            _geminiClientService = geminiClientService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<CoinTrackerResponse<GeminiResponse>> TryGetSymbols()
        {
            try
            {
                return await _geminiClientService.TryGetSymbols();
            }
            catch (Exception ex)
            {
                return CoinTrackerResponse<GeminiResponse>
                    .WithException(ex);
            }
        }

        // GET api/values/5
        [HttpGet("{symbol}")]
        public async Task<CoinTrackerResponse<GeminiResponse>> TryGetTickerSymbol(string symbol)
        {
            try
            {
                return await _geminiClientService.TryGetTickerSymbol(symbol);
            }
            catch (Exception ex)
            {
                return CoinTrackerResponse<GeminiResponse>
                    .WithException(ex);
            }
        }
        [HttpGet("{symbol}/{interval}")]
        public async Task<CoinTrackerResponse<GeminiResponse>> TryGetCandles(string symbol, string interval)
        {
            try
            {
                return await _geminiClientService.TryGetCandles(symbol, interval);
            }
            catch (Exception ex)
            {
                return CoinTrackerResponse<GeminiResponse>
                    .WithException(ex);
            }
        }

    }
}

