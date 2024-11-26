using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;
internal class B1038 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Lanche");

        string[] linha = Console.ReadLine().Split(' ');
        int codigo = int.Parse(linha[0]);
        int quantidade = int.Parse(linha[1]);
        double total = 0;

        switch (codigo)
        {
            case 1:
                total = quantidade * 4;
                break;
            case 2:
                total = quantidade * 4.5;
                break;
            case 3:
                total = quantidade * 5;
                break;
            case 4:
                total = quantidade * 2;
                break;
            case 5:
                total = quantidade * 1.5;
                break;
        }

        Console.WriteLine($"Total: R$ {total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
