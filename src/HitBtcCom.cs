using System;
using System.Net.Http;
using System.Threading.Tasks;
using s1d0r.marketplace;

namespace s1d0r.HitBtcComAPI
{
    public class HitBtcCom : IMarketPlace
    {
        public string TikerUrl { get; set; } = "https://api.hitbtc.com/api/2/public/ticker";

        public HitBtcCom(string publicKey, string privateKey, HttpClient httpClient)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
            HttpClient = httpClient;
        }

        public HitBtcCom(string publicKey, string privateKey)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }

        public string PublicKey { get; set; }

        public string PrivateKey { get; set; }

        public HttpClient HttpClient { get; set; }

        public Task<string> GetBalance()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetTiker()
        {
            throw new NotImplementedException();
        }

        public Task<string> PlaseBuyOrder()
        {
            throw new NotImplementedException();
        }

        public Task<string> PlaseSellOrder()
        {
            throw new NotImplementedException();
        }

        public Task<string> RemoveOrder()
        {
            throw new NotImplementedException();
        }

        public Task<string> StatusOrder()
        {
            throw new NotImplementedException();
        }

        public static async Task<string> GetTikerCertainSymbolAsync(HttpClient httpClient, string url, string symbol)
        {
            var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, url + "/" + symbol));
            return await response.EnsureSuccessStatusCode().Content.ReadAsStringAsync();
        }

        public Task<string> GetTikerCertainSymbolAsync(string symbol)
        {
            return HitBtcCom.GetTikerCertainSymbolAsync(this.HttpClient, this.TikerUrl, symbol);
        }
    }
}
