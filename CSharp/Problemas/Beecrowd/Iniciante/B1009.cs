using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

internal class B1009 : Problema
{
    public override void PMain(string problema)
    {
        ProcedureHelpers.Cabecalho("Salário com Bônus");

        _ = Console.ReadLine();
        double salarioFixoFuncionario = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double totalVendasFuncionario = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        double total = salarioFixoFuncionario + (totalVendasFuncionario * 0.15);

        Console.WriteLine($"TOTAL = R$ {total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
