using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1114 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Senha Fixa");

        int senhaCorreta = 2002;

        while (true)
        {
            int valor = int.Parse(Console.ReadLine());

            if (valor == senhaCorreta)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else
            {
                Console.WriteLine("Senha Invalida");
            }
        }
    }
}
