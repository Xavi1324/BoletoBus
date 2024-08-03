using Newtonsoft.Json;
using System.Text;

namespace BoletoBus.Web.HelpController
{
    public class BaseHelp
    {
        private readonly HttpClient _httpClient;
        

        public BaseHelp(HttpClient httpClient)
        {
            _httpClient = httpClient;
            
        }
        public async Task<Response<T>> GetAsync<T>(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Response<T>>(jsonResponse);
            }
            else
            {
                return new Response<T>
                {
                    Success = false,
                    Message = $"Error al obtener datos de la API: {response.ReasonPhrase}"
                };
            }
        }

        public async Task<Response<T>> PostAsync<T>(string url, T data)
        {
            var jsonContent = JsonConvert.SerializeObject(data);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(url, contentString);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Response<T>>(jsonResponse);
            }
            else
            {
                return new Response<T>
                {
                    Success = false,
                    Message = $"Error al enviar datos a la API: {response.ReasonPhrase}"
                };
            }
        }

    }
}
