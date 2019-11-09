namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Instituicao instituicao = new Instituicao();

            System.Console.Write("Informe o nome da instituição\n");
            instituicao.Nome = System.Console.ReadLine();

            System.Console.Write("Informe o endereço da instituição\n");
            instituicao.Endereco = System.Console.ReadLine();

            System.Console.Write("===================================\n");
            System.Console.Write($"Obrigado por informar os dados para a {instituicao.Nome}\n");
            System.Console.Write("Precione qualquer tecla para encerrar.\n");

            System.Console.ReadKey();
        }
    }
}
