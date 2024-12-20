﻿using Beecrowd.Template;
using Beecrowd.Util;
using System.Globalization;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1006 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Média 2");

        double notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double notaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (notaA * 2 + notaB * 3 + notaC * 5) / 10;

        Console.WriteLine($"MEDIA = {media.ToString("F1", CultureInfo.InvariantCulture)}");
    }
}
