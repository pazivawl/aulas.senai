using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uc12
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set;}

        public DateTime dataNascimento { get; set;}
        public override void pagarimposto(float rendimento){}
        public bool ValidarDataNascimento(DateTime dataNascimento){
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNascimento).TotalDays /365;
            //REVER ISSO DEPOIS//
            if(anos >= 18){
                return true;
                //System.Console.WriteLine("Cadastro Aprovado");
            }else{
                return false;
               // Console.WriteLine("Cadastro Reprovado");
            }
        }
    }
}
