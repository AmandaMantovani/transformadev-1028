namespace Aula6
{
    public class Carro : Veiculo
    {
        public bool CambioAutomatico { get; set; }
        public int QuantidadePortas { get; set; }
        public string Direcao { get; set; }

        public void TestePrivateProtected()
        {
            // acesso private
            //this.condutor = "Teste"; não acessa private
            this.Condutor = "Teste";

            // acesso protected
            this.combustivel = "Teste3";
            this.Combustivel = "Teste2";
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando o Carro");
        }

        public void Freiar()
        {
            Console.WriteLine("Freiando o carro");
        }
    }
}
