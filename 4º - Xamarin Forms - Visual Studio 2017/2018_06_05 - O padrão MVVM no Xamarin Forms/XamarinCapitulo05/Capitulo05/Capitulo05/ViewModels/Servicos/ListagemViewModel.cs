using Capitulo05.Models;
using Capitulo05.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Capitulo05.ViewModels.Servicos
{
    public class ListagemViewModel
    {
        public IDataStore<Servico> DataStore = new ServicoDataStore();
        public ICommand NovoCommand { get; set; }

        public ICommand EliminarCommand { get; set; }
        

        public ObservableCollection<Servico> Servicos
        {
            get; set;
        }
        public ListagemViewModel()
        {
            Servicos = new ObservableCollection<Servico>();
            RegistrarCommands();

            /*var servicos = DataStore.GetAllAsync();
            foreach (var s in servicos.Result)
            {
                this.Servicos.Add(s);
            }*/
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

        public async Task AtualizarServicos()
        {
            this.Servicos.Clear();
            var servicos = await DataStore.GetAllAsync();
            foreach (var s in servicos)
            {
                this.Servicos.Add(s);
            }
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
            await DataStore.DeleteAsync(servico);
        }
    }
}
