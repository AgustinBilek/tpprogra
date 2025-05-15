using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class producto
    {
		private int idprod;
		public int _idprod
		{
			get { return idprod; }
			set { idprod = value; }
		}

		private string nombree;
		public string _nombree
		{
			get { return nombree; }
			set { nombree = value; }
		}

		private string descripcion;
		public string _descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private  DateTime fechacompra;
		public  DateTime _fechacompra
		{
			get { return fechacompra; }
			set { fechacompra = value; }
		}
		
		private int comprobante;
		public int _comprobante
		{
			get { return comprobante; }
			set { comprobante = value; }
		}
	}
}