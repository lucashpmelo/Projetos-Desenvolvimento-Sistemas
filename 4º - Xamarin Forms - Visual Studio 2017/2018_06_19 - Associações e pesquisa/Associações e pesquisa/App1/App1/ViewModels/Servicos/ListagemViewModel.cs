using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using Interfaces.DataAccess;
using OficinaModels.Cadastros;
using SQLiteEF.DAL;
using SQLiteEF.DataAccess;
using Interfaces.DataAccess.Interfaces;

namespace App1.ViewModels.Servicos
{
    public class ListagemViewModel
    {
        private IDAL<Servico> servicosDAL;
        public ObservableCollection<Servico> Servicos
        {
            get; set;
        }
        public ICommand NovoCommand { get; set; }
        public ICommand EliminarCommand { get; set; }
        public ListagemViewModel()
        {
            servicosDAL = new ServicoDAL(new DatabaseContext(DependencyService.Get<IDBPath>().GetDbPath()));
            Servicos = new ObservableCollection<Servico>();
            RegistrarCommands();
        }
        private Servico servicoSelecionado;
        public Servico ServicoSelecionado
        {
            get { return servicoSelecionado; }
            set
            {
                if (value != null)
                {
                    servicoSelecionado = value;
                    MessagingCenter.Send<Servico>(servicoSelecionado, "Mostrar");
                }
            }
        }
        public async Task<bool> AtualizarServicos()
        {
            this.Servicos.Clear();
            var servicos = await servicosDAL.GetAllAsync();
            foreach (var c in servicos)
            {
                this.Servicos.Add(c);
            }
            return await Task.FromResult(true);
        }
        private void RegistrarCommands()
        {
            NovoCommand = new Command(() =>
            {
                MessagingCenter.Send<Servico>(new Servico(), "Mostrar");
            });
            EliminarCommand = new Command<Servico>((servico) =>
            {
                MessagingCenter.Send<Servico>(servico, "Confirmação");
            });
        }
        public async Task EliminarServico(Servico servico)
        {
            await servicosDAL.DeleteAsync(servico);
        }
    }
}
