using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBackgroundServices.Domain.PostgresModel;

namespace WebApiBackgroundServices.Services
{
    public class ConsultaService: IConsultaService
    {

        public async Task<List<Paciente>> GetListaConsultaDias(){
            var p = await GetFakePacientes();


            return await Task.FromResult(p);
        }

        public async Task<List<Paciente>> GetListaConsultaMamografia()
        {
            var p = await GetFakePacientes();


            return await Task.FromResult(p);
        }

        public async Task<List<Paciente>> GetListaExamesConcluidos()
        {

            var p = await GetFakePacientes();
            

            return await Task.FromResult(p);
        }




        private async Task<List<Paciente>>  GetFakePacientes()     {
            var l = new List<Paciente>
            {
                    new()
                    {
                        Nomedopaciente = "Paciente 1",
                        Nomedocliente = "Cliente 1",
                        Diaehoradoatendimento = DateTime.Now,
                        Endereçodocliente = "Endereço 1",
                        Cpfdopaciente = "11111111111",
                        Emaildopaciente = "paciente1@example.com",
                        Senhadopaciente = "senha1",
                        TelefonePaciente = "11111111111",
                        LinkWebDoCliente = "http://www.cliente1.com.br"
                    },
                    new()
                    {
                        Nomedopaciente = "Paciente 2",
                        Nomedocliente = "Cliente 2",
                        Diaehoradoatendimento = DateTime.Now,
                        Endereçodocliente = "Endereço 2",
                        Cpfdopaciente = "22222222222",
                        Emaildopaciente = "paciente2@example.com",
                        Senhadopaciente = "senha2",
                        TelefonePaciente = "22222222222",
                        LinkWebDoCliente = "http://www.cliente2.com.br"
                    },
                    new()
                    {
                        Nomedopaciente = "Paciente 3",
                        Nomedocliente = "Cliente 3",
                        Diaehoradoatendimento = DateTime.Now,
                        Endereçodocliente = "Endereço 3",
                        Cpfdopaciente = "33333333333",
                        Emaildopaciente = "paciente3@example.com",
                        Senhadopaciente = "senha3",
                        TelefonePaciente = "33333333333",
                        LinkWebDoCliente = "http://www.cliente3.com.br"

                    },
                    new()
                    {
                        Nomedopaciente = "Paciente 4",
                        Nomedocliente = "Cliente 4",
                        Diaehoradoatendimento = DateTime.Now,
                        Endereçodocliente = "Endereço 4",
                        Cpfdopaciente = "44444444444",
                        Emaildopaciente = "paciente4@example.com",
                        Senhadopaciente = "senha4",
                        TelefonePaciente = "44444444444",
                        LinkWebDoCliente = "http://www.cliente4.com.br"
                    },
                    new()
                    {
                        Nomedopaciente = "Paciente 5",
                        Nomedocliente = "Cliente 5",
                        Diaehoradoatendimento = DateTime.Now,
                        Endereçodocliente = "Endereço 5",
                        Cpfdopaciente = "55555555555",
                        Emaildopaciente = "paciente5@example.com",
                        Senhadopaciente = "senha5",
                        TelefonePaciente = "55555555555",
                        LinkWebDoCliente = "http://www.cliente5.com.br"
                    }
        };

            return await Task.FromResult( l);
        }
    }


}
