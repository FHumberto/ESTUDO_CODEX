﻿using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1001 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Extremamente Básico");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"X = {a + b}");
    }
}