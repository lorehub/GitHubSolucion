using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitHubXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BienvenidosPage : ContentPage
    {
        public BienvenidosPage()
        {
            InitializeComponent();
        }

        private async void ListaPublicaciones(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PublicacionesPage());
        }
    }
}