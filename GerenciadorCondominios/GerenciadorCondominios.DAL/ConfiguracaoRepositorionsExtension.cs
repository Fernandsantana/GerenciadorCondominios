﻿using GerenciadorCondominios.DAL.Interfaces;
using GerenciadorCondominios.DAL.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorCondominios.DAL
{
    public static class ConfiguracaoRepositoriosExtension
    {
        public static void ConfigurarRepositorios(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();

            services.AddTransient<IFuncaoRepositorio, FuncaoRepositorio>();

            services.AddTransient<IVeiculoRepositorio, VeiculoRepositorio>();

            services.AddTransient<IEventoRepositorio, EventoRepositorio>();

        }
    }
}