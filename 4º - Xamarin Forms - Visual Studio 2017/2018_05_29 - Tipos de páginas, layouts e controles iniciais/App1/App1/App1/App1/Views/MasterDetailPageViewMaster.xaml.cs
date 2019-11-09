using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageViewMaster : ContentPage
    {
        public MasterDetailPageViewMenuItem[] OpcoesMenu { get; set; }

        public ListView ListView { get; set; }

        public MasterDetailPageViewMaster()
        {
            Icon = "menu.png";
            InitializeComponent();
            OpcoesMenu = new[]
            {
                new MasterDetailPageViewMenuItem { Id = 0, Title = "Clientes", TargetType = typeof(ContentPageView), IconSource="tab_clientes.png"},
                new MasterDetailPageViewMenuItem { Id = 0, Title = "Serviços", TargetType = typeof(TabbedPageView), IconSource="tab_servicos.png"}
            };

            ListView = itensMenuListView;
            BindingContext = this;
        }
    }
}