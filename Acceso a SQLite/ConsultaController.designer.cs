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
	[Register ("ConsultaController")]
	partial class ConsultaController
	{
		[Outlet]
		UIKit.UIButton btnConsultar { get; set; }

		[Outlet]
		UIKit.UILabel lblCorreo { get; set; }

		[Outlet]
		UIKit.UILabel lblDomicilio { get; set; }

		[Outlet]
		UIKit.UILabel lblEdad { get; set; }

		[Outlet]
		UIKit.UILabel lblNombre { get; set; }

		[Outlet]
		UIKit.UILabel lblSaldo { get; set; }

		[Outlet]
		UIKit.UITextField txtFolio { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtFolio != null) {
				txtFolio.Dispose ();
				txtFolio = null;
			}

			if (btnConsultar != null) {
				btnConsultar.Dispose ();
				btnConsultar = null;
			}

			if (lblNombre != null) {
				lblNombre.Dispose ();
				lblNombre = null;
			}

			if (lblDomicilio != null) {
				lblDomicilio.Dispose ();
				lblDomicilio = null;
			}

			if (lblCorreo != null) {
				lblCorreo.Dispose ();
				lblCorreo = null;
			}

			if (lblEdad != null) {
				lblEdad.Dispose ();
				lblEdad = null;
			}

			if (lblSaldo != null) {
				lblSaldo.Dispose ();
				lblSaldo = null;
			}
		}
	}
}
