namespace RH
{
    public class Funcionario
    {
        public string? Nome;

        private string? cpf;

        public string? CPF
        {
            get
            {
                return cpf.Replace(".", "").Replace("-", "");
            }
            
        }

        public Funcionario(string _nome, string _cpf)
        {
            Nome = _nome;
            cpf = _cpf;
        }
        
    }


}