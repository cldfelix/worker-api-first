using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiBackgroundServices.Domain.PostgresModel;

namespace WebApiBackgroundServices.Services
{
    public interface IConsultaService
    {
        Task<List<Paciente>> GetListaConsultaDias();
        Task<List<Paciente>> GetListaConsultaMamografia();
        Task<List<Paciente>> GetListaExamesConcluidos();
    }
}
