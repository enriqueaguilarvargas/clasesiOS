using System;

using UIKit;

namespace AppiOS_SQLite
{
    public partial class ConsultaController : UIViewController
    {
        public ConsultaController() : base("ConsultaController", null)
        {
        }
        public ConsultaController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            btnConsultar.TouchUpInside += delegate
            {
                try
                {
                    var csql = new ClaseSQLite();
                    csql.folio = int.Parse(txtFolio.Text);
                    csql.Buscar(csql.folio);
                    lblNombre.Text = csql.nombre;
                    lblDomicilio.Text = csql.domicilio;
                    lblCorreo.Text = csql.correo;
                    lblEdad.Text = csql.edad.ToString();
                    lblSaldo.Text = csql.saldo.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        	};
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

