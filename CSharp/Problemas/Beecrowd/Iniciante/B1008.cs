using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

internal class B1008 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Salário");

        int funcionarioId = int.Parse(Console.ReadLine());
        int horasTrabalhadas = int.Parse(Console.ReadLine());
        float valorHora = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        float salario = horasTrabalhadas * valorHora;

        Console.WriteLine($"NUMBER = {funcionarioId}");
        Console.WriteLine($"SALARY = U$ {salario.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
