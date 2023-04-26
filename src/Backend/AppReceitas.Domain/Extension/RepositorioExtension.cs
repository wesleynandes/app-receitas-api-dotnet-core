using Microsoft.Extensions.Configuration;

namespace AppReceitas.Domain.Extension;

public static class RepositorioExtension
{
    public static string GetNomeDataBase(this IConfiguration configurationManager)
    {
        var nomeDataBase = configurationManager.GetConnectionString("NomeDataBase");

        return nomeDataBase;
    }

    public static string GetConexao(this IConfiguration configurationManager)
    {
        var conexao = configurationManager.GetConnectionString("Conexao");

        return conexao;
    }
}
