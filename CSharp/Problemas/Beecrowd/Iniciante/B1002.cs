using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante;

internal class B1002 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Área do Círculo\n");

        const double PI = 3.14159;
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double calculo = PI * Math.Pow(raio, 2);

        Console.WriteLine($"A={calculo.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}
