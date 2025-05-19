using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formhidden : Form
    {
        public formhidden()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Opacity = 0;
            this.Load += (s, e) => login_Load();
        }

        private void login_Load()
        {
            while (true)
            {
                login Login = new login();
                if (Login.ShowDialog() == DialogResult.OK)
                {
                    Persona usuarioLogueado = Login.UsuarioAutenticado;
                    formprincipal f1 = new formprincipal(usuarioLogueado);
                    f1.ShowDialog();
                }
                else
                {
                    this.Hide();
                    break;
                }
            }
        }
    }
}
