using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using SalvaMiVida.Service;
using SalvaMiVida.Model;
using System.Collections.ObjectModel;
using System.Globalization;

namespace SalvaMiVida.ViewModel
{
        public class ViewModelCitasIdentidad : INotifyPropertyChanged
        {
        public ViewModelCitasIdentidad()
        {

            Enviar = new Command(async () => {
                if (valor != null)
                {
                    RestClient cliente = new RestClient();
                    string url = "https://apex.oracle.com/pls/apex/walterdb/consultas/buscacitasidentidad?busqueda=" + valor;
                    var result = await cliente.GetUrl<ModelCitasIdentidad>(url);

                    if (result != null)
                    {

                        for (int i = 0; i < result.items.Count; i++)
                        {

                            listaPacientes.Add(result.items[i]);
                        }


                    }
                }
            });

    }




        string valor;
        public string Valor
        {
            get => valor;

            set
            {
                valor = value;
                var arg = new PropertyChangedEventArgs(nameof(Valor));
                PropertyChanged?.Invoke(this, arg);

            }
        }



        ItemIdentidad identidadSeleccionada;

        public ItemIdentidad IdentidadSeleccionada
        {
            get => identidadSeleccionada;
            set
            {

                identidadSeleccionada = value;
                var args = new PropertyChangedEventArgs(nameof(IdentidadSeleccionada));
                PropertyChanged?.Invoke(this, args);

            }

        }
        

        ObservableCollection<Item> listaPacientes = new ObservableCollection<Item>();

        public ObservableCollection<Item> ListaPacientes { get => listaPacientes; }


        public Command Enviar { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
