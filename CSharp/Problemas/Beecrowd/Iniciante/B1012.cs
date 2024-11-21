using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

internal class B1012 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Área");

        string[] linha = Console.ReadLine().Split(' ');

        double a = double.Parse(linha[0], System.Globalization.CultureInfo.InvariantCulture);
        double b = double.Parse(linha[1], System.Globalization.CultureInfo.InvariantCulture);
        double c = double.Parse(linha[2], System.Globalization.CultureInfo.InvariantCulture);

        double triangulo = a * c / 2;
        double circulo = 3.14159 * Math.Pow(c, 2);
        double trapezio = (a + b) * c / 2;
        double quadrado = Math.Pow(b, 2);
        double retangulo = a * b;

        Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {circulo.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
