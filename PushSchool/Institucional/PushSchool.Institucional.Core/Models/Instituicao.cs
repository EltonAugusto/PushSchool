using PushSchool.Kernel.Core.Models;
using PushSchool.Kernel.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSchool.Institucional.Core.Models
{
    public class Instituicao : Entidade
    {
        public Instituicao(string nome, string cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
        }

        public string Nome { get; private set; }
        public string Cnpj { get; private set; }
        public Pessoa Responsavel { get; private set; }

        public void AtribuirResponsavel(Pessoa responsavel)
        {
            Responsavel = responsavel;
        }
    }
}
