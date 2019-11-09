using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Interfaces.DataAccess;
using OficinaModels.Cadastros;
using SQLiteEF.DAL;
using SQLiteEF.DataAccess;
using Interfaces.DataAccess.Interfaces;

namespace App1.ViewModels.Clientes
{
    public class PesquisarViewModel
    {
            private IDAL<Cliente> clienteDAL;
            public ObservableCollection<Cliente> ClientesEncontrados { get; set; }
            public ICommand PesquisarCommand { get; set; }

            public PesquisarViewModel()
            {
                clienteDAL = new ClienteDAL(DatabaseContext.GetContext(DependencyService.Get<IDBPath>().GetDbPath()));
                ClientesEncontrados = new ObservableCollection<Cliente>();
                PesquisarCommand = new Command<string>((cliente) =>
                {
                    ClientesEncontrados.Clear();
                    var clientesEncontrados = clienteDAL.GetStartsWithByFieldAsync("Nome", cliente).Result;
                    foreach (var c in clientesEncontrados)
                    {
                        ClientesEncontrados.Add(c);
                    }
                });
            }

            private Cliente clienteLocalizadoSelecionado;
            public Cliente ClienteLocalizadoSelecionado
            {
                get { return clienteLocalizadoSelecionado; }
                set
                {
                    if (value != null)
                    {
                        clienteLocalizadoSelecionado = value;
                        MessagingCenter.Send<Cliente>(clienteLocalizadoSelecionado, "ClienteSelecionado");
                    }
                }
            }

    }
}