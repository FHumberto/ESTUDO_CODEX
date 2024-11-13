using Beecrowd.Data;
using Beecrowd.Util;

namespace Beecrowd;

internal class Program
{
    static void Main(string[] args)
    {
        var problemasRegistrados = new ProblemasRegistrados();

        string? comando;
        do
        {
            Console.WriteLine("Informe o número do problema: [1000, 1001, ...]");
            string? problema = Console.ReadLine();

            //* Encontra e executa o problema informado.
            Console.WriteLine();
            ProcedureHelpers.ExecutarProblema(problemasRegistrados.GetlistaProblemas(), problema);
            Console.WriteLine();

            ProcedureHelpers.Mensagem(1);
            comando = Console.ReadLine();
        } while (comando is "S" or "s");
    }
}
