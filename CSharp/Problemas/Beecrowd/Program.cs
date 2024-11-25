using Beecrowd.Data;
using Beecrowd.Util;

ProblemasRegistrados problemasRegistrados = new();

string? comando;

try
{
    do
    {
        Console.WriteLine("Informe o número do problema: [1000, 1001, ...]");

        string? problema = Console.ReadLine();

        Console.WriteLine();

        ProcedureHelpers.ExecutarProblema(problemasRegistrados.GetlistaProblemas(), problema);

        Console.WriteLine();

        ProcedureHelpers.Mensagem(1);

        comando = Console.ReadLine();

    } while (comando is "S" or "s");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
