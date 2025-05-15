using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class admin : Persona
    {
		private int _idadmin;

		public int IdAdmin
		{
			get { return _idadmin; }
			set { _idadmin = value; }
		}

       public admin(string usuario, string contra) : base(usuario, contra)
        {
            
        }
    }
}
