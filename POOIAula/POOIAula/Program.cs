namespace POOIAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garrafa garrafa = new Garrafa();
            garrafa.cor = "preto";
            garrafa.material = "plastico";
            garrafa.termica = true;
            garrafa.capacidade = 750;

            Garrafa garrafa2 = new();
            garrafa2.cor = "rosa";

            Garrafa garrafa3 = new()
            {
                cor = "preto",
                material = "plastico",
                capacidade = 0,
                termica = true
            };

            Console.WriteLine(garrafa.cor);
            Console.WriteLine(garrafa.material);


            List<Garrafa> garrafas = new();
            garrafas.Add(garrafa);
            garrafas.Add(garrafa2);
            garrafas.Add(garrafa3);

            garrafas.Add(new Garrafa() {
                capacidade = 1000,
                cor = "azul",
                material = "plastico" ,
                termica = false
            });

            var garrafaTeste = new Garrafa()
            {
                capacidade = 1000,
                cor = "azul",
                material = "plastico",
                termica = false
            };

            var garrafaBuscada = garrafas.FirstOrDefault(x => x.cor == "preto");

            Garrafa garrafaBuscada2 = garrafas.FirstOrDefault(x => x == garrafaTeste);
            //Console.WriteLine(garrafaBuscada2.cor);

            foreach (var garrafaDaLista in garrafas)
            {
                Console.WriteLine(garrafaDaLista.capacidade);
                Console.WriteLine(garrafaDaLista.cor);
                Console.WriteLine(garrafaDaLista.material);
                Console.WriteLine(garrafaDaLista.termica);
            }

            //garrafas = null; exception no foreach 
            garrafas = new();

            foreach (var garrafaDaLista in garrafas)
            {
                Console.WriteLine(garrafaDaLista.capacidade);
                Console.WriteLine(garrafaDaLista.cor);
                Console.WriteLine(garrafaDaLista.material);
                Console.WriteLine(garrafaDaLista.termica);
            }



            List<string> nomes2 = new()
            {
                "Eduardo", //0
                "Vanessa", //1
                "Amanda", //2
                "AdicionarNome", //3
                "Amanda", //4
                "Ewerson", //5
                "Adicionar", //6
                /* nao permitido no Insert
                null,
                null,
                null,
                null,
                "Adicionar" //10*/
            };
            //F5 - solta o código, libera a execução para o proximo BreakPoint ou até o fim do programa.
            //F10 - percorre o código junto com a execução, sem entrar em métodos
            //F11 - percorre o código junto com a execução, entrando em métodos

            List<string> nomes = new();
            nomes.Add("Amanda");

            nomes.AddRange(nomes2);

            nomes.Remove("Amanda");

            var tamanho = nomes.Count;

            nomes.Sort();

            nomes.RemoveAll(nome => nome == "Eduardo");

            nomes.RemoveAt(1);

            nomes.Insert(3, "Paulo");
            
            var nomesConcatenados = string.Join(",", nomes);
            Console.WriteLine(nomesConcatenados);

            //nomes.Sum();

            //IEnumerable

            nomes.ElementAt(1);
            var teste2 = nomes[1];

            var nomeBuscado = nomes.IndexOf("Amanda");
            nomes[nomeBuscado] = "Alterado";
            
            string nomeEncontrado = nomes.FirstOrDefault(x => x.Contains("a"));
            nomeEncontrado = "Teste";

            List<string> nomesEncontrados = nomes.Where(x => x.Contains("a")).ToList();

            foreach(var nome in nomes)
            {
                Console.WriteLine(nome);
            }




        }
    }
}