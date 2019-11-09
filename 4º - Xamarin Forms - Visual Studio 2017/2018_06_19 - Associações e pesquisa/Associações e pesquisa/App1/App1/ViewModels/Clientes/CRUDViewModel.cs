using SQLiteEF.DAL;
using SQLiteEF.DataAccess;
using Interfaces.DataAccess.Interfaces;
using App1.Models;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Interfaces.DataAccess;
using OficinaModels.Cadastros;

namespace App1.ViewModels.Clientes
{
    public class CRUDViewModel : BaseViewModel
    {
        private IDAL<Cliente> clientesDAL;
        private Cliente Cliente { get; set; }
        public ICommand GravarCommand { get; set; }
        public ICommand RegitrarCommands { get; set; }
        public CRUDViewModel(Cliente cliente)
        {
            clientesDAL = new ClienteDAL(new DatabaseContext(DependencyService.Get<IDBPath>().GetDbPath()));
            this.Cliente = cliente;
        }

        public string Nome
        {
            get { return this.Cliente.Nome; }
            set
            {
                this.Cliente.Nome = value;
                ((Command)GravarCommand).ChangeCanExecute();
                OnPropertyChanged();
            }
        }
        public string Telefone
        {
            get { return this.Cliente.Telefone; }
            set
            {
                this.Cliente.Telefone = value;
                ((Command)GravarCommand).ChangeCanExecute();
                OnPropertyChanged();
            }
        }
        public string EMail
        {
            get { return this.Cliente.EMail; }
            set
            {
                this.Cliente.EMail = value;
                ((Command)GravarCommand).ChangeCanExecute();
                OnPropertyChanged();
            }
        }

        private async Task<bool> Gravar()
        {
            var ehNovoCliente = (this.Cliente.ClienteID == null ? true :
            false);
            await clientesDAL.UpdateAsync(Cliente, Cliente.ClienteID);
            if (ehNovoCliente)
            {
                this.Cliente = new Cliente();
                this.Nome = string.Empty;
                this.Telefone = string.Empty;
                this.EMail = string.Empty;
            }
            return await Task.FromResult(true);
        }

        /*nao sei onde é
         * private void RegistrarCommands()
        {
            GravarCommand = new Command(async () =>
            {
                await Gravar();
                MessagingCenter.Send<string>("Atualização realizada com sucesso.", "InformacaoCRUD");
            }, () =>
            {
                return !string.IsNullOrEmpty(this.Cliente.Nome) && !string.IsNullOrEmpty(this.Cliente.Telefone) && !string.IsNullOrEmpty(this.Cliente.EMail);
            });
        }*/


    }
}
