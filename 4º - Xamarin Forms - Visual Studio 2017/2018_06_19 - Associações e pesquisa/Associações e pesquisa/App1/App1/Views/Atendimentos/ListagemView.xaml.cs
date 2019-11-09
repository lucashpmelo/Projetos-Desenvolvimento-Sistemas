using App1.ViewModels.Atendimentos;
using OficinaModels.Atendimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Atendimentos
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

            await viewModel.AtualizarAtendimentos();

            if (listView.SelectedItem != null)
                listView.SelectedItem = null;

            MessagingCenter.Subscribe<Atendimento>(this, "Mostrar", async (atendimento) =>
            {
                await Navigation.PushAsync(new CRUDView(atendimento, "Novo Atendimento"));
            });
            MessagingCenter.Subscribe<Atendimento>(this, "MostrarOpcoes", async (atendimento) =>
            {
                viewModel.AtendimentoSelecionado = null;
                string result;
                if (atendimento.EstaFinalizado)
                    result = await DisplayActionSheet("Opções para o Atendimento " + atendimento.AtendimentoID, "Cancelar", "Consultar");
                else
                    result = await DisplayActionSheet("Opções para o Atendimento " + atendimento.AtendimentoID, "Cancelar", "Alterar", "Registrar Entrega", "Remover OS");
                ProcessarOpcaoRespondida(atendimento, result);
            });

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Atendimento>(this, "Mostrar");
            MessagingCenter.Unsubscribe<Atendimento>(this, "MostrarOpcoes");

        }

        private async void ProcessarOpcaoRespondida(Atendimento msg, string result)
        {
            if (result.Equals("Consultar") || result.Equals("Alterar"))
            {
                var title = result + " Atendimento" + msg.AtendimentoID;
                await Navigation.PushAsync(new CRUDView(msg, title));

            }
            else if (result.Equals("Registrar Entrega"))
            {
                await viewModel.RegistrarEntrega(msg);
                await viewModel.AtualizarAtendimentos();
                await DisplayAlert("Informação", "Entrega registrada com sucesso.", "Ok");
                listView.SelectedItem = null;
            }
            else if (result.Equals("Remover OS"))
            {
                if (await DisplayAlert("Confirmação", $"Confirma remoção da OS {msg.AtendimentoID}?", "Yes", "No"))
                {
                    await viewModel.EliminarAtendimento(msg);
                    await viewModel.AtualizarAtendimentos();
                    await DisplayAlert("Informação", "Atendimento removido com sucesso", "Ok");
                }
            }
        }


    }
}