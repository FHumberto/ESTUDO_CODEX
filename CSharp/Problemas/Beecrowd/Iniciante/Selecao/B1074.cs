using Beecrowd.Template;

namespace Beecrowd.Iniciante.Selecao;

public class B1074 : Problema
{
    public override void PMain()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(VerificaNumero(int.Parse(Console.ReadLine())));
        }
    }

    public static string VerificaNumero(int number)
    {
        string tipo = (number % 2 == 0) ? "EVEN" : "ODD";
        string positivo = (number > 0) ? "POSITIVE" : "NEGATIVE";

        if (number == 0)
        {
            return "NULL";
        }
        else
        {
            return $"{tipo} {positivo}";
        }
    }
}