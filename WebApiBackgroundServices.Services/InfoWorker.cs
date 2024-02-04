using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebApiBackgroundServices.Repository;

namespace WebApiBackgroundServices.Services
{
    public class InfoWorker : IHostedService
    {
        private Timer _timer;
        private ICommandRepository _commandRepository;
        private IMessageService _messageService;
        private IConsultaService _consultaService;

        string _consultaMsg = "Hello World!";
        string _exameMsg = "Hello World!";



        public InfoWorker(
            ICommandRepository commandRepository, 
            IMessageService messageService,
            IConsultaService consultaService
            )
        {
            _commandRepository = commandRepository; 
            _messageService = messageService;
            _consultaService = consultaService;

           
        }

   


        public Task StartAsync(CancellationToken cancellationToken)
        {
            //pegar as mensagens padráo
            _consultaMsg = _messageService.GetMessageConsulta().Result;
            _exameMsg = _messageService.GetMessageResultado().Result;


            Console.WriteLine($"Process started {nameof(InfoWorker)}");

            _timer = new Timer(DoWork, null, TimeSpan.FromSeconds(5), TimeSpan.FromHours(1));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            Console.WriteLine($"{DateTime.Now:o} =>  {_commandRepository.GetMessage()}");

            var pacientesExamesConcluido = _consultaService.GetListaExamesConcluidos().Result;
            var pacientesEComConsulta = _consultaService.GetListaConsultaDias().Result;
            
            foreach (var paciente in pacientesExamesConcluido)
            {
                paciente.SetMensagem(_exameMsg, "ResultadoExame"); 
                Console.WriteLine($"Mensagem: {paciente.Mensagem}");
            }

            foreach (var paciente in pacientesEComConsulta)
            {
                paciente.SetMensagem(_consultaMsg, "Consulta");
                Console.WriteLine($"Mensagem: {paciente.Mensagem}");
            }




        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Process finished {nameof(InfoWorker)}");

            return Task.CompletedTask;
        }
    }
}
