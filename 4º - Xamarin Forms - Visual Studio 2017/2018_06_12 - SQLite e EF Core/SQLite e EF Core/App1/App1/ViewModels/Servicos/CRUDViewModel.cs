using System;
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
    public class CRUDViewModel : BaseViewModel
    {
        private IDAL<Servico> servicosDAL;
        private Servico Servico { get; set; }
        public ICommand GravarCommand { get; set; }
        public CRUDViewModel(Servico servico)
        {
            servicosDAL = new ServicoDAL(new DatabaseContext(DependencyService.Get<IDBPath>().GetDbPath()));
            this.Servico = servico;
            RegistrarCommands();
        }
        public string Nome
        {
            get { return this.Servico.Nome; }
            set
            {
                this.Servico.Nome = value;
                ((Command)GravarCommand).ChangeCanExecute();
                OnPropertyChanged();
            }
        }
        public string Valor
        {
            get { return Convert.ToString(this.Servico.Valor); }
            set
            {
                this.Servico.Valor = string.IsNullOrEmpty(value)
                ? 0 : Convert.ToDouble(value);
                ((Command)GravarCommand).ChangeCanExecute();
                OnPropertyChanged();
            }
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
        private async Task<bool> Gravar()
        {
            var ehNovoServico = (this.Servico.ServicoID == null ?
            true : false);
            await servicosDAL.UpdateAsync(Servico, Servico.ServicoID);
            if (ehNovoServico)
            {
                this.Servico = new Servico();
                this.Nome = string.Empty;
                this.Valor = string.Empty;
            }
            return await Task.FromResult(true);
        }
    }
}
