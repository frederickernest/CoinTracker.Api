using System;
namespace CoinTracker.Client.Gemini
{
    public class GeminiConstants
    {
        public GeminiConstants() { }

        public static string RootUrlV1 = "https://api.gemini.com/v1/";
        public static string RootUrlV2 = "https://api.gemini.com/v2/";

        //TODO: grab symbols, deserialize into enum or tuple
        //public enum CoinSymbols
        //{
        //    btcusd, ethbtc, ethusd, zecusd, zecbtc, zeceth, zecbch, zecltc, bchusd,
        //    bchbtc, bcheth, ltcusd, ltcbtc, ltceth, ltcbch, batusd, daiusd, linkusd,
        //    oxtusd, batbtc, linkbtc, oxtbtc, bateth, linketh, oxteth, ampusd, compusd,
        //    paxgusd, mkrusd, zrxusd, kncusd, manausd, storjusd, snxusd, crvusd, balusd,
        //    uniusd, renusd, umausd, yfiusd, btcdai, ethdai, aaveusd, filusd, btceur,
        //    btcgbp, etheur, ethgbp, btcsgd, ethsgd, sklusd, grtusd, bntusd, inchusd,
        //    enjusd, lrcusd, sandusd, cubeusd, lptusd, bondusd, maticusd, injusd,
        //    sushiusd, dogeusd, alcxusd, mirusd, ftmusd, ankrusd, btcgusd, ethgusd,
        //    ctxusd, xtzusd, axsusd, slpusd, lunausd, ustusd, mco2usd, efilfil, gusdusd,
        //    dogebtc, dogeeth, wcfgusd, rareusd, radusd, qntusd, nmrusd, maskusd, fetusd,
        //    ashusd, audiousd, api3usd, usdcusd, shibusd, rndrusd, mcusd, galausd, ensusd,
        //    kp3rusd, cvcusd, elonusd, mimusd, spellusd, tokeusd, ldousd, rlyusd, solusd,
        //    rayusd, sbrusd
        //}

        public enum Endpoints
        {
            ticker,
            symbols
        }

    }
}

