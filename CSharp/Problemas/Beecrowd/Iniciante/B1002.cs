using Beecrowd.Template;
using Beecrowd.Util;
using System.Globalization;

namespace Beecrowd.Iniciante;

internal class B1002 : Problema
{
    public override void PMain(string problema)
    {
        ProcedureHelpers.Cabecalho("Áreea do Circulo");

        const double pi = 3.14159;
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double calculo = pi * Math.Pow(raio, 2);

        Console.WriteLine($"A={calculo.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}
