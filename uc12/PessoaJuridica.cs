using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uc12
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public override void pagarimposto(float rendimento){}
    }
}