using AppReceitas.Domain.Entidades;
using AppReceitas.Domain.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace AppReceitas.Infrastructure.AcessoRepositorio.Repositorio;

public class UsuarioRepositorio : IUsuarioReadOnlyRepositorio, IUsuarioWriteOnlyRepositorio
{
    private readonly AppReceitasContext _contexto;

    public UsuarioRepositorio(AppReceitasContext contexto)
    {
        _contexto = contexto;
    }
    public async Task Adicionar(Usuario usuario)
    {
        await _contexto.Usuarios.AddAsync(usuario);
    }

    public async Task<bool> ExisteUsuarioComEmail(string email)
    {
        return await _contexto.Usuarios.AnyAsync(c => c.Email.Equals(email));
    }
}
