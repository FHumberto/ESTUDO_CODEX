using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Selecao;

internal class B1037 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Intervalo");

        float ponto = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        string intervalo = VerificarIntervalo(ponto);
        Console.WriteLine(intervalo);
    }

    static string VerificarIntervalo(float ponto)
    {
        if (ponto < 0)
            return "Fora de intervalo";
        if (ponto <= 25f)
            return "Intervalo [0,25]";
        if (ponto <= 50f)
            return "Intervalo (25,50]";
        if (ponto <= 75f)
            return "Intervalo (50,75]";
        if (ponto <= 100f)
            return "Intervalo (75,100]";

        return "Fora de intervalo";
    }
}
