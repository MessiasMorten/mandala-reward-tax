namespace RewardTaxLibraries
{
    public class WebClientExtension
    {
        private readonly HttpClient _httpClient;

        public WebClientExtension(string baseAddress)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseAddress);
        }

        public HttpClient GetWebClient()
        {
            return _httpClient;
        }
    }
}
