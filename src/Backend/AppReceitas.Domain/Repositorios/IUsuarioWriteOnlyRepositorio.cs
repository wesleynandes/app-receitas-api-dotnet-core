using AppReceitas.Domain.Entidades;

namespace AppReceitas.Domain.Repositorios;

public interface IUsuarioWriteOnlyRepositorio
{
    Task Adicionar(Usuario usuario);
}
