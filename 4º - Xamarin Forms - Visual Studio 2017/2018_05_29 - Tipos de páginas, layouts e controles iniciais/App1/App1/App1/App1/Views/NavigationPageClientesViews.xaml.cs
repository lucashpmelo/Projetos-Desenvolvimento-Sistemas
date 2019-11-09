using App1.Models;
using App1.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationPageClientesViews : ContentPage
	{
		public NavigationPageClientesViews ()
		{
			InitializeComponent ();
            listViewClientes.ItemsSource = new DadosParaTeste().Clientes;

        }

        private async void listViewClientes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var cliente = e.SelectedItem as Cliente;
            await Navigation.PushAsync(new NavigationPageVeiculosView(cliente));
            ((ListView)sender).SelectedItem = null;
        }
    }
}