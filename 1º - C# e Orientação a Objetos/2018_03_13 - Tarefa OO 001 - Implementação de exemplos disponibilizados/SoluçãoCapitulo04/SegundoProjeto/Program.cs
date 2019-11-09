﻿using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var iesUTFPR = new Instituicao()
            {
                Nome = "UTFPR",
                Endereco = new Endereco()
                {
                    Rua = "Brasil",
                    Numero = "1000"
                }

            };

            var iesCC = new Instituicao()
            {
                Nome = "Casa do Código",
                Endereco = new Endereco()
                {
                    Bairro = "Liberdade"
                }
            };

            var dptoEnsino = new Departamento("Computação");

            var dptoAlimentos = new Departamento("Alimentos");

            var dptoRevisao = new Departamento("Revisão Escrita");

            iesUTFPR.RegistrarDepartamento(dptoEnsino);
            iesUTFPR.RegistrarDepartamento(dptoAlimentos);

            iesCC.RegistrarDepartamento(dptoRevisao);

            Console.WriteLine("UTFPR\n");
            for (int i = 0; i < iesUTFPR.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}\n");
            }

            Console.WriteLine("Casa do Código\n");
            for (int i = 0; i < iesCC.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesCC.Departamentos[i].Nome}\n");
            }

            Console.Write("Pressione qualquer tecla para continuar\n");
            Console.ReadKey();

            dptoAlimentos.RegistrarCurso(new Curso { Nome = "Tecnologia em Alimentos", CargaHoraria = 2000 });

            dptoAlimentos.RegistrarCurso(new Curso { Nome = "Engenharia de Alimentos", CargaHoraria = 3000 });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Cursos no departamento de {dptoAlimentos.Nome}");

            foreach (var curso in dptoAlimentos.Cursos)
            {
                Console.WriteLine($"==> {curso.Nome} ({curso.CargaHoraria})h");
            }

            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();

            dptoAlimentos.FecharDepartamento();
            dptoAlimentos = null;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("O departamento do alimentos foi fechado");
            Console.ReadKey();


            Console.WriteLine();
            var cursoCC = new Curso() { Nome = "Ciência da Computação", CargaHoraria = 3000 };
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Algoritmos", CargaHoraria = 80 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Orientação a Objetos", CargaHoraria = 60 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Orientação a Objetos", CargaHoraria = 80 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Estrutura de Dados", CargaHoraria = 80 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Programação para Web", CargaHoraria = 80 });

            Console.WriteLine($"O curso {cursoCC.Nome} possui {cursoCC.Disciplinas.Count} disciplinas:");
            foreach (var d in cursoCC.Disciplinas)
            {
                Console.WriteLine($"==> {d.Nome} ({d.CargaHoraria})");
            }
            Console.ReadKey();
        }
    }
}