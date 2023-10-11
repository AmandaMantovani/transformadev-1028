namespace Aula6
{
    public sealed class Carro : Veiculo
    {
        public bool CambioAutomatico { get; set; }
        public int QuantidadePortas { get; set; }
        public string Direcao { get; set; }

        public Carro(string condutorCC, string combustivel, int capacidade, double velocidade,
            bool cambio, int quantidade, string direcao) : base(condutorCC, combustivel, capacidade, velocidade)
        {
            this.CambioAutomatico = cambio;
            this.QuantidadePortas = quantidade;
            this.Direcao = direcao;
        }

        public void TestePrivateProtected()
        {
            // acesso private
            //this.condutor = "Teste"; não acessa private
            this.Condutor = "Teste";

            // acesso protected
            this.combustivel = "Teste3";
            this.Combustivel = "Teste2";
        }

        public override void Mover()
        {
            //base.Mover(); caso eu queira q a classe pai seja executada também
            Console.WriteLine("Acelerando o carro - classe filho");
        }

        public override void Parar()
        {
            Console.WriteLine("Freiando o carro - classe filho");
        }
    }
}
