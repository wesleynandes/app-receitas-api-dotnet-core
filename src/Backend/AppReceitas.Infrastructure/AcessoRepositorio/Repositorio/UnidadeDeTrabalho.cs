﻿using AppReceitas.Domain.Repositorios;

namespace AppReceitas.Infrastructure.AcessoRepositorio.Repositorio;

public sealed class UnidadeDeTrabalho : IDisposable, IUnidadeDeTrabalho
{
    private readonly AppReceitasContext _contexto;
    private bool _disposed;

    public UnidadeDeTrabalho(AppReceitasContext contexto)
    {
        _contexto = contexto;
    }

    public async Task Commit()
    {
        await _contexto.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
    }

    private void Dispose(bool disposing)
    {
        if (!_disposed && disposing)
        {
            _contexto.Dispose();
        }
        _disposed = true;
    }
}
