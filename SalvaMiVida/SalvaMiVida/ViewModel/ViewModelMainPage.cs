using System;
using System.Collections.Generic;
using System.Text;
using SalvaMiVida.Model;
using System.ComponentModel;
using SalvaMiVida.View;
using SalvaMiVida.Service;
using Xamarin.Forms;

namespace SalvaMiVida.ViewModel
{
    public class ViewModelMainPage : INotifyPropertyChanged
    {
        public ViewModelMainPage()
        {
            Ingresar = new Command(async () => {


                RestClient client = new RestClient();
                var result = await client.validacionUsuario<ModelMainPage> (
                    this.usuario,
                    this.pass);


                if (result.items[0].cuenta == 1)
                {

                    ViewMainPage mn = new ViewMainPage();
                    NavigationPage.SetHasBackButton(mn, false);
                    await App.Current.MainPage.Navigation.PushAsync(mn);
                    

                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Mensaje",
                        "Usuario y Contraseña Incorrectos", "Ok");

                    Resultado = "Error de Inicio de Sesion!";
                }


            });

        }

        string usuario = "";

        public string Usuario
        {
            get => usuario;
            set
            {
                usuario = value;
                var args = new PropertyChangedEventArgs(nameof(Usuario));
                PropertyChanged?.Invoke(this, args);
            }
        }

        string pass;

        public string Pass
        {
            get => pass;
            set
            {
                pass = value;
                var args = new PropertyChangedEventArgs(nameof(Pass));
                PropertyChanged?.Invoke(this, args);

            }
        }

        string resultado;

        public string Resultado
        {
            get => resultado;
            set
            {
                resultado = value;
                var args = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, args);

            }
        }

        public Command Ingresar { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
