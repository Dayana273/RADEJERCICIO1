using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RADEJERCICIO1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }




        private void btEnviar_Clicked_1(object sender, EventArgs e)
        {


            {


                var person = new Personas
                {
                    nombre = txtnombre.Text,
                    Apellido = txtApellido.Text,
                    correo = txtcorreo.Text,
                    Edad = txtedad.Text,    
                    direccion = txtdireccion.Text,

                };
                //esto es para llamar una segunda pagina y pasar un parametro a una segunda pantalla//
                var seconpage = new PageResultado();
                seconpage.BindingContext = person; //paso de parametros a la pantalla
                Navigation.PushAsync(seconpage);
            }


        }
    }
}

