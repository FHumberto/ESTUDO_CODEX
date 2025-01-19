using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Selecao;

internal class B1052 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Mês");

        int valor = int.Parse(Console.ReadLine());

        Dictionary<int, string> meses = new Dictionary<int, string>();

        meses.Add(1, "January");
        meses.Add(2, "February");
        meses.Add(3, "March");
        meses.Add(4, "April");
        meses.Add(5, "May");
        meses.Add(6, "June");
        meses.Add(7, "July");
        meses.Add(8, "August");
        meses.Add(9, "September");
        meses.Add(10, "October");
        meses.Add(11, "November");
        meses.Add(12, "December");

        if (meses.ContainsKey(valor))
        {
            Console.WriteLine(meses[valor]);
        }
    }
}
