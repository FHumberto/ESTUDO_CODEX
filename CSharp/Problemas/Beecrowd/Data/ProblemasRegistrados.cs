using Beecrowd.Iniciante;
using Beecrowd.Template;

namespace Beecrowd.Data;
internal class ProblemasRegistrados
{
    private readonly Dictionary<string, Problema> _listaProblemas = new()
    {
       { "1000", new B1000() },
       { "1001", new B1001() },
       { "1002", new B1002() },
       { "1003", new B1003() },
       { "1004", new B1004() },
    };

    public Dictionary<string, Problema> GetlistaProblemas()
    {
        return _listaProblemas;
    }
}
