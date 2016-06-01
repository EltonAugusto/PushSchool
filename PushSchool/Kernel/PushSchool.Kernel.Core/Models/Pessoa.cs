using PushSchool.Kernel.Core.ValueObjects;

namespace PushSchool.Kernel.Core.Models
{
    public class Pessoa : Entidade
    {
        public Pessoa(string nome, string email, string celular)
        {
            Nome = nome;
            Email = email;
            Celular = celular;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Celular { get; private set; }
    }
}