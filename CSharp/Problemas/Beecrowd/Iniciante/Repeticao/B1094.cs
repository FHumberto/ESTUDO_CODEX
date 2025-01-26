using System.Globalization;

using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1094 : Problema
{
    public override void PMain()
    {
        const int Rato = 0;
        const int Sapo = 1;
        const int Coelho = 2;

        int casos = int.Parse(Console.ReadLine());
        int[] experimentos = new int[3];

        for (int i = 0; i < casos; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int qtd = int.Parse(linha[0]);
            char cobaia = char.Parse(linha[1]);

            switch (cobaia)
            {
                case 'R':
                    experimentos[Rato] += qtd;
                    break;

                case 'S':
                    experimentos[Sapo] += qtd;
                    break;

                case 'C':
                    experimentos[Coelho] += qtd;
                    break;
            }
        }

        int totalExperimentos = experimentos[Coelho] + experimentos[Rato] + experimentos[Sapo];

        Console.WriteLine($"Total: {totalExperimentos} cobaias");
        Console.WriteLine($"Total de coelhos: {experimentos[Coelho]}");
        Console.WriteLine($"Total de ratos: {experimentos[Rato]}");
        Console.WriteLine($"Total de sapos: {experimentos[Sapo]}");
        Console.WriteLine($"Percentual de coelhos: {((experimentos[Coelho] / (float)totalExperimentos) * 100).ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {((experimentos[Rato] / (float)totalExperimentos) * 100).ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {((experimentos[Sapo] / (float)totalExperimentos) * 100).ToString("F2", CultureInfo.InvariantCulture)} %");
    }
}
