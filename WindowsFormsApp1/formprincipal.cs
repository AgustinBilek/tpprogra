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
    public partial class formprincipal : Form
    {
        private Persona usuarioLogueado;
      
        public formprincipal(Persona usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            ActualizarMenu();
        }

        private void ActualizarMenu()
        {
            if(usuarioLogueado is admin)
            {
                menuAdmin.Visible = true;
                menuListaUsuarios.Visible = true;
                menuListaVendedores.Visible = true;

                menuReclamo.Visible = true;
                menuHacerReclamo.Visible = true;
                menuRevisarReclamos.Visible = true;
                menuHistorialReclamos.Visible = true;
                menuReclamosSolucionados.Visible = true;
                menuHistorialMensajes.Visible = true;

                menuPuntuaciones.Visible = true;
                menuPuntuarVendedor.Visible = true;
                menuPuntuacionesDadas.Visible = true;
                menuPuntuacionesRecibidas.Visible = true;

               
            }
            else if(usuarioLogueado is vendedor)
            {
                menuAdmin.Visible = false;
                menuListaUsuarios.Visible = false;
                menuListaVendedores.Visible = false;

                menuReclamo.Visible = true;
                menuHacerReclamo.Visible = false;
                menuRevisarReclamos.Visible = true;
                menuHistorialReclamos.Visible = true;
                menuReclamosSolucionados.Visible = true;
                menuHistorialMensajes.Visible = true;

                menuPuntuaciones.Visible = true;
                menuPuntuarVendedor.Visible = false;
                menuPuntuacionesDadas.Visible = false;
                menuPuntuacionesRecibidas.Visible = true;

                menuUnlogin.Visible = true;
            }
            else if (usuarioLogueado is comprador)
            {
                menuAdmin.Visible = false;
                menuListaUsuarios.Visible = false;
                menuListaVendedores.Visible = false;

                menuReclamo.Visible = true;
                menuHacerReclamo.Visible = true;
                menuRevisarReclamos.Visible = false;
                menuHistorialReclamos.Visible = true;
                menuReclamosSolucionados.Visible = true;
                menuHistorialMensajes.Visible = true;

                menuPuntuaciones.Visible = true;
                menuPuntuarVendedor.Visible = true;
                menuPuntuacionesDadas.Visible = true;
                menuPuntuacionesRecibidas.Visible = false;

                menuUnlogin.Visible = true;
            }
        }
        private void reclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void historialDeMensajesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void puntuacionesDadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reclamosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void menuUnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l=new login();
            l.Show();
        }
    }
}
