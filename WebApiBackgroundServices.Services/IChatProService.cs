using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace WebApiBackgroundServices.Services
{

    public interface IChatProService
    {
        Task GetTokenMessage();
    }

    public class ChatProService : IChatProService
    {
        private readonly string _urlBase ;
        private readonly string _email;
        private readonly string _password;
        private string _token ;
        private readonly IConfiguration _configuration;

        public ChatProService(IConfiguration configuration)
        {
            _configuration = configuration;
            _urlBase = _configuration["ChatProParams:UrlBase"];
            _email = _configuration["ChatProParams:Email"];
            _password = _configuration["ChatProParams:Password"];
        }

        private async Task GetToken()
        {
            Console.WriteLine(_email);
            Console.WriteLine(_password);

            var options = new RestClientOptions($"{_urlBase}/painel/ws/endpoint.php?action=token");
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddJsonBody("{\"email\":\"claudinei.felix@usp.br\",\"senha\":\"RfZ!sni93Xkcv.C\"}", false);
            var response = await client.PostAsync(request);
            
            _token = response.Content;
        }

        public async Task GetTokenMessage()
        {
            if (string.IsNullOrEmpty(_token))
            {
                await GetToken();
            }

        }
    }
}
