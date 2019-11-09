﻿using Interfaces.DataAccess;
using Interfaces.DataAccess.Interfaces;
using OficinaModels.Atendimentos;
using OficinaModels.Cadastros;
using SQLiteEF.DAL;
using SQLiteEF.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels.Atendimentos
{
    public class CRUDViewModel : BaseViewModel
    {
        private IDAL<Atendimento> atendimentoDAL;
        private Atendimento Atendimento { get; set; }

        public string ClienteNome { get { return this.Atendimento.Cliente == null ? "Localize o cliente" : this.Atendimento.Cliente.Nome; } }

        public CRUDViewModel(Atendimento atendimento)
        {
            atendimentoDAL = new AtendimentoDAL(DatabaseContext.GetContext(DependencyService.Get<IDBPath>().GetDbPath()));
            this.Atendimento = atendimento;
        }

        public ICommand PesquisarCommand { get; set; }

        private void RegistrarCommands()
        {
            PesquisarCommand = new Command(() =>
            {
                MessagingCenter.Send<Atendimento>(Atendimento, "MostrarPesquisarCliente");
            });

            GravarCommand = new Command(async () =>
            {
                await atendimentoDAL.UpdateAsync(Atendimento, Atendimento.AtendimentoID);
                MessagingCenter.Send<string>("Atualização realizada com sucesso.", "InformacaoCRUD");
            }, () =>
            {
                return ((this.Atendimento.Cliente != null) && !string.IsNullOrEmpty(this.Atendimento.Cliente.Nome) && !string.IsNullOrEmpty(this.Atendimento.Veiculo) && (this.Atendimento.DataHoraPrometida > this.Atendimento.DataHoraChegada));
            });
            //nao sie onde é:
            ((Command)GravarCommand).ChangeCanExecute();

        }

        public Cliente Cliente
        {
            get { return this.Atendimento.Cliente; }
            set
            {
                this.Atendimento.Cliente = value;
                //this.Atendimento.ClienteID = (value == null) ? null : value.ClienteID; // No EF Core este código não é necessário.
                OnPropertyChanged(nameof(ClienteNome));
            }
        }

        public string Veiculo
        {
            get { return this.Atendimento.Veiculo; }
            set
            {
                this.Atendimento.Veiculo = value;
                OnPropertyChanged();
            }
        }
        public DateTime DataChegada
        {
            get { return this.Atendimento.DataHoraChegada; }
            set
            {
                this.Atendimento.DataHoraChegada = new DateTime(value.Year, value.Month, value.Day, HoraChegada.Hours, HoraChegada.Minutes, 0);
                OnPropertyChanged();
            }
        }

        public TimeSpan HoraChegada
        {
            get { return new TimeSpan(this.Atendimento.DataHoraChegada.Hour, this.Atendimento.DataHoraChegada.Minute, 0); }
            set
            {
                this.Atendimento.DataHoraChegada = new DateTime(DataChegada.Year, DataChegada.Month, DataChegada.Day, value.Hours, value.Minutes, 0);
                OnPropertyChanged();
            }
        }

        public DateTime DataPrometida
        {
            get { return this.Atendimento.DataHoraPrometida; }
            set
            {
                this.Atendimento.DataHoraPrometida = new DateTime(value.Year, value.Month, value.Day, HoraPrometida.Hours, HoraPrometida.Minutes, 0);
                OnPropertyChanged();
            }
        }

        public TimeSpan HoraPrometida
        {
            get { return new TimeSpan(this.Atendimento.DataHoraPrometida.Hour, this.Atendimento.DataHoraPrometida.Minute, 0); }
            set
            {
                this.Atendimento.DataHoraPrometida = new DateTime(DataPrometida.Year, DataPrometida.Month, DataPrometida.Day, value.Hours, value.Minutes, 0);
                OnPropertyChanged();
            }
        }

        public ICommand GravarCommand { get; set; }

        public bool HabilitaAlteracao
        {
            get { return !Atendimento.EstaFinalizado; }
        }

        public string EntregaVeiculo
        {
            get
            {
                return (HabilitaAlteracao)
                    ? "" : "Entregue em " + ((DateTime)this.Atendimento.DataHoraEntrega).ToString("dd/MM/yyyy HH:mm:ss");
            }
        }








    }
}

