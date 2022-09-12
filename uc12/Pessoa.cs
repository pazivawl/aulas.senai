
namespace uc12
{
    public abstract class Pessoa
    {
        public string nome {get; set;}

        public string endereco {get; set;}
        
        public bool enderecocomercial { get; set; }

        public void pagarimposto(){}
    }
}