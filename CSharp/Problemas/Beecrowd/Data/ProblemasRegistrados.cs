using Beecrowd.Template;
using System.Reflection;

namespace Beecrowd.Data;

internal class ProblemasRegistrados
{
    private readonly Dictionary<string, Problema> _listaProblemas;

    public ProblemasRegistrados()
    {
        _listaProblemas = [];
        PreencherListaProblemas();
    }

    private void PreencherListaProblemas()
    {
        Type problemaType = typeof(Problema);

        Assembly assembly = Assembly.GetAssembly(problemaType)
            ?? throw new InvalidOperationException("Erro ao encontrar o assemby contendo o tipo Problema.");

        //* busca por todas as classes de derivação do tipo Problema
        IEnumerable<Type> problemaTypes = assembly.GetTypes()
                                    .Where(t => t.IsSubclassOf(problemaType) && !t.IsAbstract);

        //* itera e cria a instância das classes
        foreach (Type? type in problemaTypes)
        {
            if (Activator.CreateInstance(type) is Problema instance)
            {
                _listaProblemas.Add(type.Name.Substring(1), instance);
            }
        }
    }

    public Dictionary<string, Problema> GetlistaProblemas()
    {
        return _listaProblemas;
    }
}
