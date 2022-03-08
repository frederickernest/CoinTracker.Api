using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoinTracker.Client.Interfaces;
using CoinTracker.Client.Models;
using CoinTracker.Client.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoinTracker.Api.Controllers
{
    [Route("api/gemini/symbols")]
    public class GeminiController : Controller
    {
        private readonly GeminiClientService _geminiClientService;

        public GeminiController()
        {
            _geminiClientService = new GeminiClientService();
        }

        // GET: api/values
        [HttpGet]
        public async Task<List<string>> TryGetSymbols()
        {
            return await _geminiClientService.TryGetSymbols();
        }

        // GET api/values/5
        [HttpGet("{symbol}")]
        public async Task<GeminiResponse> TryGetTickerSymbol(string symbol)
        {
            return await _geminiClientService.TryGetTickerSymbol(symbol);
        }

    }
}

