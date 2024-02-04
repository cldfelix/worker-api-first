using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiBackgroundServices.Services
{
    public interface IMessageService
    {
        Task<string> GetMessageResultado();
        Task<string> GetMessageConsulta();
    }
}
