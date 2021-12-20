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
    public class ViewModelCitasFecha : INotifyPropertyChanged
    {
        public ViewModelCitasFecha()
        {

            Enviar = new Command(async () => {
                if (fechainicio != null && fechafin !=null)
                {
                    RestClient cliente = new RestClient();
                    string url = "https://apex.oracle.com/pls/apex/walterdb/consultas/buscacitasfecha?finicial=" + fechainicio.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + "&ffinal=" + fechafin.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    var result = await cliente.GetUrl<ModelCitasFecha>(url);

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




        DateTime fechainicio;
        public DateTime FechaInicio
        {
            get => fechainicio;

            set
            {
                fechainicio = value;
                var arg = new PropertyChangedEventArgs(nameof(FechaInicio));
                PropertyChanged?.Invoke(this, arg);

            }
        }


        DateTime fechafin;
        public DateTime FechaFin
        {
            get => fechafin;

            set
            {
                fechafin = value;
                var arg = new PropertyChangedEventArgs(nameof(FechaFin));
                PropertyChanged?.Invoke(this, arg);

            }
        }



        Itemfecha fechaSeleccionada;

        public Itemfecha FechaSeleccionada
        {
            get => fechaSeleccionada;
            set
            {

                fechaSeleccionada = value;
                var args = new PropertyChangedEventArgs(nameof(FechaSeleccionada));
                PropertyChanged?.Invoke(this, args);

            }

        }


        ObservableCollection<Item> listaPacientes = new ObservableCollection<Item>();

        public ObservableCollection<Item> ListaPacientes { get => listaPacientes; }


        public Command Enviar { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
