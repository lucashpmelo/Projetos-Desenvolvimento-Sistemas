using SQLiteEF.DAL;
using SQLiteEF.DataAccess;
using Interfaces.DataAccess.Interfaces;
using IDPropertiesEF.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

using Interfaces.DataAccess;
using OficinaModels.Cadastros;
using System.Threading.Tasks;

namespace App1.ViewModels.Clientes
{
    public class ListagemViewModel
    {
        private IDAL<Cliente> clientesDAL = new ClienteDAL(new DatabaseContext(DependencyService.Get<IDBPath>().GetDbPath()));
        private Cliente clienteSelecionado;
        public ObservableCollection<Cliente> Clientes
        {
            get; set;
        }
        public ListagemViewModel()
        {
            Clientes = new ObservableCollection<Cliente>();
            RegistrarCommands();
        }
 
        public ICommand NovoCommand { get; set; }
        public ICommand EliminarCommand { get; set; }

        private void RegistrarCommands()
        {
            NovoCommand = new Command(() =>
            {
                MessagingCenter.Send<Cliente>(new Cliente(), "Mostrar");
            });
            EliminarCommand = new Command<Cliente>((cliente) =>
            {
                MessagingCenter.Send<Cliente>(cliente, "Confirmação");
            });
        }
        public async Task<bool> AtualizarClientes()
        {
            this.Clientes.Clear();
            var clientes = await clientesDAL.GetAllAsync();
            foreach (var c in clientes)
            {
                this.Clientes.Add(c);
            }
            return await Task.FromResult(true);
        }

        public Cliente ClienteSelecionado
        {
            get { return clienteSelecionado; }
            set
            {
                if (value != null)
                {
                    clienteSelecionado = value;
                    MessagingCenter.Send<Cliente>(clienteSelecionado, "Mostrar");
                }
            }
        }
        public async Task EliminarCliente(Cliente cliente)
        {
            await clientesDAL.DeleteAsync(cliente);
        }
    }
}
