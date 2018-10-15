using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitHubXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PublicacionesPage : ContentPage
	{
		public PublicacionesPage ()
		{
			InitializeComponent ();
            CargarPublicaciones();

        }
        //invocar api
        private async Task CargarPublicaciones()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://192.168.1.57");
            var request = await client.GetAsync("/PublicacionesApi2/api/Publicacion");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                listPublicaciones.ItemsSource = response;
            }
           
            

        }
    }
}