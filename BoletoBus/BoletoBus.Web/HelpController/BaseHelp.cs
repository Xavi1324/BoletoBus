using System.Net.Http;
using System.Text.Json;

namespace BoletoBus.Web.HelpController
{
    public class BaseHelp
    {
        private readonly HttpClientHandler httpClientHandler;
        private readonly string _ApiUrl;

        public BaseHelp(string ApiUrl)
        {
            httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => true;
            _ApiUrl = ApiUrl;
        }
        public async Task<T> GetApiResult<T>(string endpoint) where T : class
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"{_ApiUrl}{endpoint}");
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    try
                    {
                        return JsonSerializer.Deserialize<T>(apiResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    }
                    catch (JsonException)
                    {

                    }
                }
            }
            return null;
        }
        public async Task<bool> PostsApiResult<T>(string endpoint, T model, bool isPut = false) where T : class
        {
            using (var httpClient = new HttpClient(httpClientHandler))
            {
                var jsonContent = JsonSerializer.Serialize(model);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response;

                if (isPut)
                {
                    response = await httpClient.PutAsync($"{_ApiUrl}{endpoint}", content);
                }
                else
                {
                    response = await httpClient.PostAsync($"{_ApiUrl}{endpoint}", content);
                }

                return response.IsSuccessStatusCode;
            }
        }
    }
}
