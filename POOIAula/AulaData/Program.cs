namespace AulaData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataOntem = new DateTime(2023, 09, 20);
            Console.WriteLine(dataOntem);

            DateTime dataHoje = new DateTime(2023, 09, 25);
            Console.WriteLine(dataHoje);

            DateTime dataComHora = new DateTime(2023, 09, 25, 21, 51, 20);
            Console.WriteLine(dataComHora);

            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);

            var minutos = dataHoje.Minute;
            var ano = dataHoje.Year;

            Console.WriteLine(dataComHora.Date);

            Console.WriteLine(dataComHora.ToShortDateString());
            Console.WriteLine(dataComHora.ToShortTimeString());

            dataComHora.AddDays(1);
            dataComHora.AddDays(-5);

            var teste = dataHoje.Subtract(dataOntem);
            Console.WriteLine(teste);

            Console.WriteLine(dataComHora.ToString("yyyy-MM-dd hh:mm:ss"));
        }
    }
}