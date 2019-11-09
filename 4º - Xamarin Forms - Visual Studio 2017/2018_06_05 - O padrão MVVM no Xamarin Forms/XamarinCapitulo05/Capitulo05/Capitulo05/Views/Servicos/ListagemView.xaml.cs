using Capitulo05.Models;
using Capitulo05.ViewModels.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Capitulo05.Views.Servicos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListagemView : ContentPage
	{
        private ListagemViewModel viewModel;
        
        public ListagemView ()
		{
			InitializeComponent ();
            BindingContext = viewModel = new ListagemViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.AtualizarServicos();
            if (listView.SelectedItem != null)
                listView.SelectedItem = null;
            MessagingCenter.Subscribe<Servico>(this, "Mostrar", async (servicoSelecionado) =>
            {
                await Navigation.PushAsync(new CRUDView(servicoSelecionado));
            });

            MessagingCenter.Subscribe<Servico>(this, "Confirmação", async (msg) =>
            {
                if (await DisplayAlert("Confirmação", $"Confirma remoção de {msg.Nome.ToUpper()}?", "Yes", "No"))
                {
                    await this.viewModel.EliminarServico(msg);
                    await this.viewModel.AtualizarServicos();
                    await DisplayAlert("Informação", "Serviço removido com sucesso", "Ok");
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