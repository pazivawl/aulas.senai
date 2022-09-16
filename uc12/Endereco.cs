using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uc12
{
    public class Endereco
    {
        public string logradouro { get; set; }
        
        public int numero { get; set; }
        
        public string complemento { get; set; }
        
        public bool enderecoComercial { get; set; }
        
        public string cep { get; set;}
    }
}