// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AppiOS_SQLite
{
	[Register ("RegistroController")]
	partial class RegistroController
	{
		[Outlet]
		UIKit.UIButton btnGuardar { get; set; }

		[Outlet]
		UIKit.UITextField txtCorreo { get; set; }

		[Outlet]
		UIKit.UITextField txtDomicilio { get; set; }

		[Outlet]
		UIKit.UITextField txtEdad { get; set; }

		[Outlet]
		UIKit.UITextField txtNombre { get; set; }

		[Outlet]
		UIKit.UITextField txtSaldo { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtNombre != null) {
				txtNombre.Dispose ();
				txtNombre = null;
			}

			if (txtDomicilio != null) {
				txtDomicilio.Dispose ();
				txtDomicilio = null;
			}

			if (txtCorreo != null) {
				txtCorreo.Dispose ();
				txtCorreo = null;
			}

			if (txtEdad != null) {
				txtEdad.Dispose ();
				txtEdad = null;
			}

			if (txtSaldo != null) {
				txtSaldo.Dispose ();
				txtSaldo = null;
			}

			if (btnGuardar != null) {
				btnGuardar.Dispose ();
				btnGuardar = null;
			}
		}
	}
}
