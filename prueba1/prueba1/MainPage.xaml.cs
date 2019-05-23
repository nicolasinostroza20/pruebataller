using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prueba1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(userEntry.Text))
                {
                    DisplayAlert("Alerta", "Es obligatorio poner un nombre en este campo!", "Aceptar");
                    userEntry.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(rutEntry.Text))
                {
                    DisplayAlert("Alerta", "Es obligatorio poner un RUT en este campo!", "Aceptar");
                    rutEntry.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(emailEntry.Text))
                {
                    DisplayAlert("Alerta", "Es obligatorio poner un Email en este campo!", "Aceptar");
                    emailEntry.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(passEntry.Text))
                {
                    DisplayAlert("Alerta", "Es obligatorio poner una Contraseña en este campo!", "Aceptar");
                    passEntry.Focus();
                    return;
                }

                if (passEntry.Text.Length < 6)
                {
                    DisplayAlert("Alerta", "La contraseña actual debe tener 6 caractares.", "Aceptar");
                    passEntry.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(confirmapassEntry.Text))
                {
                    DisplayAlert("Alerta", "Debes completar este campo!", "Aceptar");
                    confirmapassEntry.Focus();
                    return;
                }

                if (passEntry.Text != passEntry.Text)
                {
                    DisplayAlert("Alerta", "Las contraseñas deben ser iguales!", "Aceptar");
                    passEntry.Focus();
                    return;
                }
            }
        }
    }
}

