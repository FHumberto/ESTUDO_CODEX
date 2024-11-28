using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Selecao;

internal class B1041 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Coordenadas de um Ponto");

        string[] linha = Console.ReadLine().Split(' ');
        float x = float.Parse(linha[0], System.Globalization.CultureInfo.InvariantCulture);
        float y = float.Parse(linha[1], System.Globalization.CultureInfo.InvariantCulture);

        System.Console.WriteLine(VerificarCoordenada(x, y));
    }

    public static string VerificarCoordenada(float x, float y)
    {
        if (x > 0 && y > 0)
            return "Q1";
        if (x < 0 && y > 0)
            return "Q2";
        if (x < 0 && y < 0)
            return "Q3";
        if (x > 0 && y < 0)
            return "Q4";
        if (x == 0 && y != 0)
            return "Eixo Y";
        if (x != 0 && y == 0)
            return "Eixo X";
        return "Origem";
    }
}