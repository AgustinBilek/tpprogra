using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class vendedor : Persona
    {
		List<string> productos = new List<string>();


		private int atencion;
		public int _atencion
		{
			get { return atencion; }
			set { atencion = value; }
		}

		private int idvendedor;
		public int _idvendedor
		{
			get { return idvendedor; }
			set { idvendedor = value; }
		}

		private int reclamosreci;
		public int _reclamoreci
		{
			get { return reclamosreci; }
			set { reclamosreci = value; }
		}

        public vendedor(string usuario, string contra) : base(usuario, contra)
        {
            
        }
    }
}