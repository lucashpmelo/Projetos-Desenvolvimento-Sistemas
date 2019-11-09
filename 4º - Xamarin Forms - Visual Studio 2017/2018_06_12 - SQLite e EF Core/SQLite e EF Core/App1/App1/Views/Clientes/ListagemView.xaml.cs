using App1.ViewModels.Clientes;
using OficinaModels.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Clientes
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
            await viewModel.AtualizarClientes();
            MessagingCenter.Subscribe<Cliente>(this, "Mostrar",async (cliente) =>
            {
            });
            MessagingCenter.Subscribe<Cliente>(this, "Confirmação",async (cliente) =>
            {
            });

            MessagingCenter.Subscribe<Cliente>(this, "Mostrar",async (cliente) =>
            {
                var title = (cliente.ClienteID == null) ? "Novo Cliente": "Alterar Cliente";
                await Navigation.PushAsync(new CRUDView(cliente, title));
            });

            MessagingCenter.Subscribe<Cliente>(this, "Confirmação",async (cliente) =>
            {
                if (await DisplayAlert("Confirmação",$"Confirma remoção de {cliente.Nome.ToUpper()}?", "Yes", "No"))
                {
                    await this.viewModel.EliminarCliente(cliente);
                    await this.viewModel.AtualizarClientes();
                    await DisplayAlert("Informação", "Cliente removido com sucesso", "Ok");
                }
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Cliente>(this, "Mostrar");
            MessagingCenter.Unsubscribe<Cliente>(this, "Confirmação");
        }
    }
}