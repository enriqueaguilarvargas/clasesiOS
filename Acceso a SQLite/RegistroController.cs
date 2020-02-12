using System;
using UIKit;
namespace AppiOS_SQLite
{
    public partial class RegistroController : UIViewController
    {
        public RegistroController() : base("RegistroController", null)
        {
        }
        public RegistroController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            btnGuardar.TouchUpInside += delegate
            {
                try
                {
                    var csql = new ClaseSQLite();
                    csql.nombre = txtNombre.Text;
                    csql.domicilio = txtDomicilio.Text;
                    csql.correo = txtCorreo.Text;
                    csql.edad = int.Parse(txtEdad.Text);
                    csql.saldo = double.Parse(txtSaldo.Text);
                    csql.ConexionBase();
                    if ((csql.IngresarDatos(csql.nombre, csql.domicilio,
                        csql.correo, csql.edad, csql.saldo)) == true)
                    {
                        MessageBox("Guardado", "Correctamente en SQLite");
                    }
                    else
                    {
                        MessageBox("No Guardado", "Favor de consultar al Developer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox("Ocurrió un error:", ex.Message);
                }

        	};

        }
        public static void MessageBox(string title,
            string message)
        {
            var Alerta = UIAlertController.Create
                (title, message, UIAlertControllerStyle.Alert);
            Alerta.AddAction(UIAlertAction.Create("OK",
                UIAlertActionStyle.Default, null));
            var Instancia = UIApplication.SharedApplication.
                Windows[1].RootViewController;
            Instancia.PresentViewController(Alerta, true, null);
        }
    }
}

