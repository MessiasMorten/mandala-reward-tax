using Newtonsoft.Json.Linq;
using RewardTaxLibraries.Entities;
using RewardTaxLibraries.Interfaces;

namespace RewardTaxLibraries
{
    public class RewardTaxService: IRemoteTaxService
    {
        private HttpClient client;
        public RewardTaxService() {
            var clientExtension = new WebClientExtension("https://api.trade.mandala.exchange");
            client = clientExtension.GetWebClient();
        }

        public MDXHistory GetHistoryData(string ticker, DateTime date)
        {
            var rewardDate = date.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            var datePlusOne = date.AddDays(1).ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            string relativePath = $"/api/3/public/price/history?from={ticker}&to=USDT&since={rewardDate}&until={datePlusOne}&period=M1";

            var response = client.GetAsync(relativePath).Result;
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
              throw new HttpRequestException("API encountered a bew");
             
            var result = response.Content.ReadAsStringAsync().Result;
            JObject jObject = JObject.Parse(result);
            var history = jObject.SelectToken("MDX", false).ToObject<MDXHistory>();

            return history;
        }

    }
}
