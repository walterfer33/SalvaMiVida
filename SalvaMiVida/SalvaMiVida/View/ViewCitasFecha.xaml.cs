using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SalvaMiVida.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewCitasFecha : ContentPage
    {
        public ViewCitasFecha()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            InitializeComponent();
        }
    }
}