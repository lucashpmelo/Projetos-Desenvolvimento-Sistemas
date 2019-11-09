
using System.Collections.ObjectModel;
using Xamarin.Forms;
using OficinaModels.Atendimentos;
using Interfaces.DataAccess;
using SQLiteEF.DAL;
using System.Threading.Tasks;
using SQLiteEF.DataAccess;
using Interfaces.DataAccess.Interfaces;
using System.Windows.Input;
using System;

namespace App1.ViewModels.Atendimentos
{
    public class ListagemViewModel
    {
        private IDAL<Atendimento> atendimentoDAL;

        public ObservableCollection<Atendimento> Atendimentos { get; set; }

        public ListagemViewModel()
        {
            atendimentoDAL = new AtendimentoDAL(DatabaseContext.GetContext(DependencyService.Get<IDBPath>().GetDbPath()));
            Atendimentos = new ObservableCollection<Atendimento>();
        }

        public ICommand NovoCommand { get; set; }

        private void RegistrarCommands()
        {
            NovoCommand = new Command(() =>
            {
                MessagingCenter.Send<Atendimento>(new Atendimento(), "Mostrar");
            });
        }


        public async Task<bool> AtualizarAtendimentos()
        {
            this.Atendimentos.Clear();
            var atendimentos = await atendimentoDAL.GetAllAsync();

            foreach (var a in atendimentos)
            {
                this.Atendimentos.Add(a);
            }
            return await Task.FromResult(true);
        }

        private Atendimento atendimentoSelecionado;
        public Atendimento AtendimentoSelecionado
        {
            get { return atendimentoSelecionado; }
            set
            {
                if (value != null)
                {
                    atendimentoSelecionado = value;
                    MessagingCenter.Send<Atendimento>(atendimentoSelecionado, "MostrarOpcoes");
                }
            }
        }

        public async Task RegistrarEntrega(Atendimento atendimento)
        {
            atendimento.DataHoraEntrega = DateTime.Now;
            await atendimentoDAL.UpdateAsync(atendimento, atendimento.AtendimentoID);
        }
        public async Task EliminarAtendimento(Atendimento atendimento)
        {
            await atendimentoDAL.DeleteAsync(atendimento);
        }



    }
}