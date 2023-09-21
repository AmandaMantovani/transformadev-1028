namespace POOIAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nome = 0;

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

        }
    }
}