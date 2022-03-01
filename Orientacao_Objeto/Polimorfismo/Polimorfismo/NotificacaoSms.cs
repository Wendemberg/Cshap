using System;

namespace Notificacoes
{
    public class NotificacaoSms : Notificacao
    {
        public NotificacaoSms(string destinatario, string menssagem) : base(destinatario, menssagem)
        {

        }
        public override void Enviar()
        {
            Console.WriteLine($"Enviando SMS para {Destinatario} com a menssagem {Menssagem}");
        }
    }
}