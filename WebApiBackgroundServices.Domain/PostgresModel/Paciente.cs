using System;
using WebApiBackgroundServices.Domain.SQLiteModel;

namespace WebApiBackgroundServices.Domain.PostgresModel
{
    public class Paciente
    {
        public string Mensagem { get; private set; }
        public string Nomedopaciente { get; set; }
        public string Nomedocliente { get; set; }
        public DateTime? Diaehoradoatendimento { get; set; }
        public string Endereçodocliente { get; set; }
        public string Cpfdopaciente { get; set; }
        public string Emaildopaciente { get; set; }
        public string Senhadopaciente { get; set; }
        public string TelefonePaciente { get; set; }
        public string LinkWebDoCliente { get; set; }

        public void SetMensagem(string mensagemOriginal, string tipoMensagem)
        {
            if (tipoMensagem == "ResultadoExame")
            {
                Mensagem = mensagemOriginal.Replace("{Nomedopaciente}", Nomedopaciente)
                    .Replace("{Nomedocliente}", Nomedocliente)
                    .Replace("{LinkWebDoCliente}", LinkWebDoCliente)
                    .Replace("{Cpfdopaciente}", Cpfdopaciente)
                    .Replace("{Emaildopaciente}", Emaildopaciente)
                    .Replace("{Senhadopaciente}", Senhadopaciente);
            }
            else
            {
                Mensagem = mensagemOriginal.Replace("{Nomedopaciente}", Nomedopaciente)
                    .Replace("{Nomedocliente}", Nomedocliente)
                    .Replace("{Diaehoradoatendimento}", Diaehoradoatendimento.ToString())
                    .Replace("{Endereçodocliente}", Endereçodocliente);
            }


        }
    }



}
