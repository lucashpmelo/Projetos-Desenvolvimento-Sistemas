namespace SegundoProjeto
{
    class Instituicao
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        public Departamento[] Departamentos { get; } = new Departamento[10];

        private int quantidadeDepartamento = 0;

        public void RegistrarDepartamento(Departamento d) {
            if (quantidadeDepartamento < 10) {
                Departamentos[quantidadeDepartamento++] = d;
            }
        }
        
        public int ObterQuantidadeDepartamentos() {
            return quantidadeDepartamento;
        }
    }
}
