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
	public partial class PesquisarView : ContentPage
	{
        private PesquisarViewModel viewModel = new PesquisarViewModel();
        public static Cliente ClienteSelecionado { get; set; }

        public PesquisarView()
        {
            InitializeComponent();
            BindingContext = viewModel;
            ClienteSelecionado = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Cliente>(this, "ClienteSelecionado", (cliente) =>
            {
                ClienteSelecionado = cliente;
                Navigation.PopAsync();
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Cliente>(this, "ClienteSelecionado");
        }






    }
}