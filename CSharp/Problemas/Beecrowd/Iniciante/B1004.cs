﻿using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

public class B1004 : Problema
{
    public override void PMain(string problema)
    {
        ProcedureHelpers.Cabecalho(problema, "Produto Simples");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"PROD = {a * b}");
    }
}