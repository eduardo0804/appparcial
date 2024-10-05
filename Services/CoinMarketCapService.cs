using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace appparcial.Services
{
    public class CoinMarketCapService
    {
        private readonly string _apiKey = "d8dd4cee-d2b5-4c68-bc66-af2a24aa6ced";
        private readonly HttpClient _client;

        public CoinMarketCapService()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", _apiKey);
        }

        public async Task<decimal> ConvertUsdToBtcAsync(decimal amountInUsd)
        {
            var response = await _client.GetStringAsync("https://pro-api.coinmarketcap.com/v1/cryptocurrency/quotes/latest?symbol=BTC&convert=USD");
            var json = JObject.Parse(response);
            decimal btcPrice = json["data"]["BTC"]["quote"]["USD"]["price"].Value<decimal>();
            return amountInUsd / btcPrice;
        }

        public async Task<decimal> ConvertBtcToUsdAsync(decimal amountInBtc)
        {
            var response = await _client.GetStringAsync("https://pro-api.coinmarketcap.com/v1/cryptocurrency/quotes/latest?symbol=BTC&convert=USD");
            var json = JObject.Parse(response);
            decimal btcPrice = json["data"]["BTC"]["quote"]["USD"]["price"].Value<decimal>();
            return amountInBtc * btcPrice;
        }
    }
}