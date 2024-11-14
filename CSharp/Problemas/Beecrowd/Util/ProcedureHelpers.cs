using Beecrowd.Template;

namespace Beecrowd.Util;

internal static class ProcedureHelpers
{
    public static void ExecutarProblema(Dictionary<string, Problema> problemas, string problema)
    {
        string? comando;

        do
        {
            if (problemas.TryGetValue(problema, out Problema? problemaEncontrado))
            {
                Console.WriteLine();

                problemaEncontrado.PMain(problema);

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"O problema informado não existe.");
                return;
            }

            Console.WriteLine();

            Mensagem(0, problema);

            comando = Console.ReadLine();

        } while (comando is "S" or "s");
    }

    public static void Mensagem(int operacao, string? problema = null)
    {
        if (operacao == 0)
        {
            Console.WriteLine($"Deseja executar o problema B{problema} novamente? [S/N]");
        }
        else
        {
            Console.WriteLine("Deseja executar o todo o programa novamente? [S/N]");
        }
    }

    public static void Cabecalho(string problema, string titulo)
    {
        Console.WriteLine($"B{problema} - {titulo}\n");
    }
}