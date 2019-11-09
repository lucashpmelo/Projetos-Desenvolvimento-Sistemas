using Capitulo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo1.Data
{
    public static class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (context.Departamentos.Any())
            {
                return;
            }
            var departamentos = new Departamento[]
            {
                new Departamento { Nome="Ciência da Computação", InstituicaoID = 1},
                new Departamento {Nome="Ciência de Alimentos", InstituicaoID = 2}
            };
            foreach (Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }

            if (context.Instituicoes.Any())
            {
                return;
            }
            var instituicoes = new Instituicao[]
           {
                new Instituicao { Nome="UniTeste",Endereco="Medianeira"},
                new Instituicao {Nome="UniTeste2",Endereco="Curitiba"}
           };
            foreach (Instituicao d in instituicoes)
            {
                context.Instituicoes.Add(d);
            }

            context.SaveChanges();
        }
    }
}
