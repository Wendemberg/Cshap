using System;
using Notificacoes;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de notificação: 1-Email | 2-SMS | 3 - Whatsapp");
            var tipo = Console.ReadLine();

            Console.WriteLine("Digite o destinatário:");
            var destinatario = Console.ReadLine();

            Console.WriteLine("Digite a mensagem:");
            var menssagem = Console.ReadLine();

            Notificacao notificacao;

            notificacao = new NotificacaoWhatsApp(destinatario, menssagem);
            notificacao.Enviar();
        }
    }
}