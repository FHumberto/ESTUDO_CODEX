using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1060 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Números Positivos");

        float[] numeros = new float[6];
        int positivos = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            
            if (numeros[i] > 0)
            {
                positivos++;
            }
        }

        Console.WriteLine($"{positivos} valores positivos");
    }
}
