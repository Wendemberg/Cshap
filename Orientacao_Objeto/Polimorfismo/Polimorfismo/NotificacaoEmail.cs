using System;

namespace Notificacoes
{
    public class NotificacaoEmail : Notificacao
    {
        public NotificacaoEmail(string destinatario, string menssagem) : base(destinatario, menssagem)
        {

        }
        public override void Enviar()
        {
            Console.WriteLine($"Enviando e-mail para {Destinatario} com a menssagem {Menssagem}");
        }
    }
}