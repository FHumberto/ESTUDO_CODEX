using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1165 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Número Primo");

        int casos = int.Parse(Console.ReadLine());

        for (int i = 0; i < casos; i++)
        {
            int numero = int.Parse(Console.ReadLine());

            string texto = EhPrimo(numero) ? "eh primo" : "nao eh primo";

            Console.WriteLine($"{numero} {texto}");
        }
    }

    static bool EhPrimo(int numero)
    {
        // 1 não é primo
        if (numero <= 1)
            return false;

        // 2 e 3 não são primos
        if (numero == 2 || numero == 3)
            return true;

        //! divisibilidade de 2 e 3, for 0 não é primo
        if (numero % 2 == 0 || numero % 3 == 0)
            return false;

        //! se tem divisores ímpares de 5 até a potencia
        for (int i = 5; i * i <= numero; i += 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }

        return true;
    }
}