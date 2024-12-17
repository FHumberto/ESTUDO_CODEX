using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1064 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Positivos e Média");

        float[] valores = new float[6];
        int positivos = 0;
        float total = 0;
        float media = 0;

        for(int i = 0; i < valores.Length; i++)
        {
            valores[i] = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            if (valores[i] > 0)
            {
                positivos++;
                total += valores[i];
            }
        }

        media = total / positivos;

        Console.WriteLine($"{positivos} valores positivos");
        Console.WriteLine($"{media.ToString("F1", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
