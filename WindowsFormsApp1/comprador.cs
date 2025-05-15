using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class comprador : Persona
    {

		private string _email;
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private int _importe;
		public int Importe
		{
			get { return _importe; }
			set { _importe = value; }
		}

		private DateTime _fechahora;
		public DateTime Fechahora
		{
			get { return _fechahora; }
			set { _fechahora = value; }
		}

		private string _mediopago;
		public string MedioPago
		{
			get { return _mediopago; }
			set { _mediopago = value; }
		}

        //Grafica: Persona del reclamo con datos, una vez hecho el reclamo aparece el producto. Despues del reclamo tiene que aparecer fecha, hora, importe pagado, medio de pago y causa del reclamo. Tambien tiene que aparecer la cantidad de encuentros, el registro de comunicaciones y fecha de proxima entrevista. Al final tiene que aparecer una nota para el vendedor.
        public comprador(string usuario, string contra) : base(usuario, contra)
        {

        }
    }
}