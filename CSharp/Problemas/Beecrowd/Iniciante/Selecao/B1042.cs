﻿using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Selecao;

internal class B1042 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Sort Simples");

        int[] valores = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] valoresDigitados = new int[valores.Length];

        Array.Copy(valores, valoresDigitados, valores.Length);
        Array.Sort(valores);

        foreach (int valor in valores)
        {
            Console.WriteLine(valor);
        }

        Console.WriteLine();

        foreach (int valor in valoresDigitados)
        {
            Console.WriteLine(valor);
        }
    }
}
