using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Persona : IInicioSesion
    {
		private string _nombre;
		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;
		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private int _telefono;
		public int Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}

		private int _dni;
		public int DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}

		private string _usuario;
		public string Usuario
		{
			get { return _usuario; }
			set { _usuario = value; }
		}

		private string _contra;
		public string Contra
		{
			get { return _contra; }
			set { _contra = value; }
		}

        protected Persona(string usuario, string contra)
        {
			Usuario = usuario;
			Contra = contra;
        }

        public bool IniciarSesion(string usuario, string contra)
        {
            return Usuario == usuario && Contra == contra;
        }
    }
}
