using App1.ViewModels.Servicos;
using OficinaModels.Cadastros;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Servicos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListagemView : ContentPage
    {
        private ListagemViewModel viewModel = new ListagemViewModel();
        public ListagemView()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.AtualizarServicos();
            if (listView.SelectedItem != null)
                listView.SelectedItem = null;
            MessagingCenter.Subscribe<Servico>(this, "Mostrar",async (msg) =>
            {
                var title = (msg.ServicoID == null) ? "Novo Serviço" : "Alterar Serviço";
                await Navigation.PushAsync(new CRUDView(msg, title));
            });
            MessagingCenter.Subscribe<Servico>(this, "Confirmação",async (msg) =>
            {
                if (await DisplayAlert("Confirmação",$"Confirma remoção de {msg.Nome.ToUpper()}?", "Yes", "No"))
                {
                    await this.viewModel.EliminarServico(msg);
                    await this.viewModel.AtualizarServicos();
                    await DisplayAlert("Informação", "Serviçoremovido com sucesso", "Ok");
                }
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Servico>(this, "Mostrar");
            MessagingCenter.Unsubscribe<Servico>(this, "Confirmação");
        }
    }
}