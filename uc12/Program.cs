using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uc12
{
    class Program{
        static void Main(string[] args)
        {
            Endereco end = new Endereco();
            end.logradouro = "Rua x";
            end.numero = 100;
            end.complemento = "Qualquer coisa";
            end.enderecoComercial = false;

            PessoaFisica pf = new PessoaFisica();
            pf.endereco = end;
            pf.nome = " GABRIEL COSTA";
            pf.cpf = "98987812323";
            pf.dataNascimento = new DateTime (2010, 12, 25);
            //interpolação
            Console.WriteLine($"o {pf.nome} mora na {pf.endereco.logradouro} numero: {pf.endereco.numero}");
            //concatenação
            //Console.WriteLine("O "+ pf.nome );
            
            //bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);
            //if (idadeValida == true)
            //{
              //  System.Console.WriteLine("Cadastro Aprovado");
            //}
            //else
            //{
             //   System.Console.WriteLine("Cadastro Reprovado");
            //}
            
        }

    }
}