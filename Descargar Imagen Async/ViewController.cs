using Foundation;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using UIKit;

namespace E2
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            btnDescargar.TouchUpInside += async delegate
			{
				var rutaArchivo = await DescargarImagen();
				Imagen.Image = UIImage.FromFile(rutaArchivo);
			};
		}
		public async Task<string> DescargarImagen()
		{
			WebClient clienteWEB = new WebClient();
			byte[] datosImagen = await clienteWEB.DownloadDataTaskAsync				
			("https://pbs.twimg.com/media/DTtSOafVAAAmz6Y.jpg");
			string ruta = Environment.GetFolderPath
				(Environment.SpecialFolder.Personal);
			string archivo = "foto1.jpg";
			string rutaArchivo = Path.Combine(ruta, archivo);
			File.WriteAllBytes(rutaArchivo, datosImagen);
			return rutaArchivo;
		}
	}
}