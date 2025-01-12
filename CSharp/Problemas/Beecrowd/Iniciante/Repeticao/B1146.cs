using System.Text;

using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1146 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Sequências Crescentes");

        while (true)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
                break;

            //! console.write é menos eficiente que o string builder
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i <= numero; i++)
            {
                resultado.Append(i);

                if (i < numero)
                    resultado.Append(' ');
            }

            Console.WriteLine(resultado.ToString());
        }
    }
}
