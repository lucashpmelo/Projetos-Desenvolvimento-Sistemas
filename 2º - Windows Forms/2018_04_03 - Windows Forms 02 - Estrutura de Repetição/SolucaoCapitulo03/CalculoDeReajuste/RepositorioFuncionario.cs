using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeReajuste
{
    public class RepositorioFuncionario
    {
        private IList<Funcionario> funcionarios = new BindingList<Funcionario>();

        public void Inserir(Funcionario funcaionario)
        {
            funcionarios.Add(funcaionario);
        }

        public IList<Funcionario> ObterTodos()
        {
            return this.funcionarios;
        }
    }
}
