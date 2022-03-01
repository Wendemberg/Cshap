using System;

namespace Notificacoes
{
    public class NotificacaoWhatsApp : Notificacao
    {
        public NotificacaoWhatsApp(string destinatario, string menssagem) : base(destinatario, menssagem)
        {

        }
        public override void Enviar()
        {
            Console.WriteLine($"Enviando menssagem no WhatsApp para {Destinatario} com a menssagem {Mensagem}");
        }
    }
}