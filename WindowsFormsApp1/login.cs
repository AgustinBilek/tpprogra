using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        string datos = "DatosLogin.csv";

        public Persona UsuarioAutenticado { get; private set; }

        List<Persona> usuarios = new List<Persona>();

        private void login_Load(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(datos, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] datos = linea.Split(';');
                    if (datos[2] == "3")
                    {
                        admin a = new admin(datos[0], datos[1]);
                        usuarios.Add(a);
                    }
                    else if (datos[2] == "2")
                    {
                        vendedor v = new vendedor(datos[0], datos[1]);
                        usuarios.Add(v);
                    }
                    else if (datos[2] == "1")
                    {
                        comprador c = new comprador(datos[0], datos[1]);
                        usuarios.Add(c);
                    }
                    linea = sr.ReadLine();
                }
            }
            fs.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string useringresado = txtUsuario.Text;
            string contraseñaingresada = txtContra.Text;

            bool loginexitoso = false;

            foreach(var item in usuarios)
            {
                if(item.IniciarSesion(useringresado, contraseñaingresada)) 
                {
                    loginexitoso = true;
                    UsuarioAutenticado = item;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }
            if (loginexitoso == false)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtUsuario.Clear();
                txtContra.Clear();
                txtUsuario.Focus();




                ///derek trolo
            }
        }
    }
}
