using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace esapm.Services
{
    public interface IExternalService
    {
        Boolean userExists(string firstName);
    }

    public class ExternalService: IExternalService
    {
        private readonly string URL = "https://gorest.co.in";
        private readonly HttpClient _httpClient;

        public ExternalService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(URL);
            // Add an Accept header for JSON format.
            _httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public bool userExists(string firstName)
        {
            /* Blocking call! Program will wait here until a response is
            received or a timeout occurs.*/

            HttpResponseMessage response = _httpClient
                .GetAsync("public-api/users").Result;

            return response.IsSuccessStatusCode;
        }
    }
}
