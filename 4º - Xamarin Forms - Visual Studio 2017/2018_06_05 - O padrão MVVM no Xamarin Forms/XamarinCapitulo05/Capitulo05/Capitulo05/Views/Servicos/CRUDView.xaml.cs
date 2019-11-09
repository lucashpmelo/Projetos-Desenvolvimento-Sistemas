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
	public partial class CRUDView : ContentPage
	{
        private CRUDViewModel crudViewModel;
        public CRUDView()
        {
            InitializeComponent();
        }
        public CRUDView(Servico servico) : this()
        {
            this.crudViewModel = new CRUDViewModel(servico);
            this.BindingContext = this.crudViewModel;
            this.Title = "Consulta Serviço";
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<string>(this, "InformacaoCRUD", async (msg) => {
                await DisplayAlert("Informação", msg, "ok");
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<string>(this, "InformacaoCRUD");
        }
    }
}