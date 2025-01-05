using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1134 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Tipo de Combustível");

        bool iterator = false;
        int[] contagem = new int[3];

        while (!iterator)
        {
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    contagem[0]++;
                    break;
                case 2:
                    contagem[1]++;
                    break;
                case 3:
                    contagem[2]++;
                    break;
                case 4:
                    iterator = true;
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine($"Alcool: {contagem[0]}");
                    Console.WriteLine($"Gasolina: {contagem[1]}");
                    Console.WriteLine($"Diesel: {contagem[2]}");
                    break;
            }
        }
    }
}
