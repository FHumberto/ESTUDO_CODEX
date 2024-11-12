using Beecrowd.Iniciante;
using Beecrowd.Template;

namespace Beecrowd.Data;
internal class ProblemasRegistrados
{
    private readonly Dictionary<string, Problema> listaProblemas1 = new()
    {
       { "1000", new B1000() },
       { "1001", new B1001() },
       { "1002", new B1002() },
    };

    public Dictionary<string, Problema> GetlistaProblemas()
    {
        return listaProblemas1;
    }
}
