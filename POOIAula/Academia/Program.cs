using Aula1;

namespace Academia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aula2
            Garrafa garrafa = new Garrafa(); //internal
            garrafa.cor = "preto"; // private
            garrafa.capacidade = 750; // protected
            garrafa.material = "plastico"; //public
            garrafa.termica = true; //public

            Peso peso = new(); // public
            peso.capacidadeMaxima = 10; //internal
            peso.tipo = "Halter"; // public

            /*
                Objetos:
                Classe: Peso - tipo/modelo, kilos, cor, revestimento
                Anilha
                Halter
                Kettlebell ou Querobel

                Classe: EquipamentoCardio -> marca, cor, velocidade, energia, carga
                Esteira
                Bicicleta
            
                Classe: Pessoa -> nome, idade, funcao, turno, identificacao
                Aluno
                Funcionario

                Classe: MaterialApoio -> tipo, cor, quantidade, utilidade
                Elastico
                Bancos
                Step
                Box
                
                Classe Patrimonios -> tipo, marca, quantidade, numeroControle, valor
                Bebedouro
                Espelho
                Luz
                
                Classe: Equipamentos -> marca, agrupamentoMuscular, cargaMaxima, kiloPorBarra, bool pesoFixo, cor, bool articulado
                LegPress
                Cadeira abdutora
                Cadeira estensora
                Barra
            */
        }
    }
}