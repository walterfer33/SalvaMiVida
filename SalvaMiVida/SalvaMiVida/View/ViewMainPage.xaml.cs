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
    public partial class ViewMainPage : TabbedPage
    {
        public ViewMainPage()
        {
            InitializeComponent();
        }
    }
}