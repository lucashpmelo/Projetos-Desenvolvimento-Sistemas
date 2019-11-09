using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var iesUTFPR = new Instituicao() {
                Nome = "UTFPR",
                Endereco = new Endereco() {
                    Rua = "Brasil",
                    Numero = "1000"
                }
                
        };

            var iesCC = new Instituicao() {
                Nome = "Casa do Código",
                Endereco = new Endereco() {
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
            for (int i = 0; i < iesUTFPR.ObterQuantidadeDepartamentos(); i++) {
                Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}\n");
            }

            Console.WriteLine("Casa do Código\n");
            for (int i = 0; i < iesCC.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesCC.Departamentos[i].Nome}\n");
            }

            Console.Write("Pressione qualquer tecla para continuar\n");
            Console.ReadKey();
        }
    }
}