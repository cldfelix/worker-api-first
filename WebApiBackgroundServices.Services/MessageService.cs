using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WebApiBackgroundServices.Services;

public class MessageService : IMessageService
{
    private readonly IConfiguration _configuration;
    public MessageService(IConfiguration configuration)
    {
        _configuration = configuration;
    }


    public async Task<string> GetMessageResultado()
    {
        return await Task.FromResult(_configuration["Messages:Resultado"]);
    }

    public async Task<string> GetMessageConsulta()
    {
        return await  Task.FromResult(_configuration["Messages:Consulta"]);
    }

     
}