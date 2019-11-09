using Capitulo05.Services;
using System;
using System.Collections.Generic;
using System.Text;

using Capitulo05.Models;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Capitulo05.ViewModels.Servicos
{
    public class CRUDViewModel : BaseViewModel
    {
        private IDataStore<Servico> DataStore = new ServicoDataStore();
        private Servico Servico { get; set; }
        public ICommand GravarCommand { get; set; }
        #region Construtores
        public CRUDViewModel(Servico servico)
        {
            this.Servico = servico;
            RegistrarCommands();
        }
        private void RegistrarCommands()
        {
            GravarCommand = new Command(async () =>
            {
                await Gravar();
                MessagingCenter.Send<string>("Atualização realizada com sucesso.", "InformacaoCRUD");
            }, () =>
            {
                return !string.IsNullOrEmpty(this.Servico.Nome) &&this.Servico.Valor > 0;
            });
        }
        /*private async Task<bool> Gravar()
        {
            await DataStore.UpdateAsync(this.Servico);
            return await Task.FromResult(true);
        }*/
        private async Task<bool> Gravar()
        {
            var ehNovoServico = (this.Servico.ServicoID == null ? true : false);
            await DataStore.UpdateAsync(Servico);
            if (ehNovoServico)
            {
                this.Servico = new Servico();
                this.Nome = string.Empty;
                this.Valor = string.Empty;
            }
            return await Task.FromResult(true);
        }


        //Nao sei se é aqui pag 24
        public string Nome
        {
            get { return this.Servico.Nome; }
            set
            {
                this.Servico.Nome = value;
                OnPropertyChanged();
                ((Command)GravarCommand).ChangeCanExecute();
            }
        }
        public string Valor
        {
            get { return Convert.ToString(this.Servico.Valor); }
            set {
                this.Servico.Valor = string.IsNullOrEmpty(value) ? 0 : Convert.ToDouble(value);
                OnPropertyChanged();
                ((Command)GravarCommand).ChangeCanExecute();
            }
        }
        #endregion
    }
}