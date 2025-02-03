using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

public class B1131 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Grenais");

        int operacao = 0, inter = 0, gremio = 0, empates = 0, grenais = 0;
        while (operacao != 2)
        {
            string[] linha = Console.ReadLine().Split(' ');
            inter = int.Parse(linha[0]);
            gremio = int.Parse(linha[1]);

            if (inter == gremio)
                empates++;

            string resultado = inter == gremio ? "Nao houve vencedor" : inter > gremio ? "Inter venceu mais" : "Gremio venceu mais";

            grenais++;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            operacao = int.Parse(Console.ReadLine());

            if (operacao == 2)
            {
                Console.WriteLine($"{grenais} grenais");
                Console.WriteLine($"Inter:{inter}");
                Console.WriteLine($"Gremio:{gremio}");
                Console.WriteLine($"Empates:{empates}");
                Console.WriteLine($"{resultado}");
            }
        }
    }
}
