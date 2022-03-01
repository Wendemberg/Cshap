using System;

namespace Notificacoes
{
    public abstract class Notificacao
    {
        public string? Destinatario { get; set; }

        public string? Menssagem { get; set; }

        public Notificacao(string destinatario, string menssagem)
        {
            Destinatario = destinatario;
            Menssagem = menssagem;
        }

        public abstract void Enviar();
    }
}