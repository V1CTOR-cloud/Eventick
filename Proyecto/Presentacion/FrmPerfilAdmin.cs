using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventick
{
    public partial class FrmPerfilAdmin : Form
    {

        ConexionBD conexion = new ConexionBD();

        public FrmPerfilAdmin()
        {
            InitializeComponent();
            txtCambiarCorreo.Visible = false;
            txtCambiarContrasenya.Visible = false;
            btnAceptarCambios.Visible = false;
        }

        private void lblEditarDatosAdmin_Click(object sender, EventArgs e)
        {
            lblCorreoAdmin.Visible = false;
            picCandadoContraseña.Visible = false;
            txtCambiarCorreo.Visible = true;
            txtCambiarContrasenya.Visible = true;
            btnAceptarCambios.Visible = true;
            btnEditarDatosAdmin.Visible = false;


        }

        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("¿Realizar cambios?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ConexionBD conexion = new ConexionBD();

                lblCorreoAdmin.Text = txtCambiarContrasenya.Text;
                lblCorreoAdmin.Visible = true;
                picCandadoContraseña.Visible = true;
                //Administradores.CambiarContrasenya(conexion.Conexion, txtCambiarContrasenya.Text, AdminLoginCache.Email);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            panelAñadirElementos.Visible = !panelAñadirElementos.Visible;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            panelEliminarElemento.Visible = !panelEliminarElemento.Visible;
        }

        private void btnAñadirActividad_Click(object sender, EventArgs e)
        {
            frmAgregarActividad formulario = new frmAgregarActividad(); 
            formulario.Visible = true;
            Visible = false;
            this.Dispose();
        }

        private void btnAñadirEvento_Click(object sender, EventArgs e)
        {

            FrmAñadirEvento formulario = new FrmAñadirEvento();          
            formulario.Visible = true;
            Visible = false;
            this.Dispose();

        }

        private void btnEliminarActividad_Click(object sender, EventArgs e)
        {
         
            panelEliminarActividades.Visible = true;
            //gtvActividadesEliminar.DataSource = Administradores.VerActividadesTotales(conexion.Conexion, AdminLoginCache.Nombre);
            gtvActividadesEliminar.ForeColor = Color.Black;
        }

        private void picCerrarPanelEliminarActividades_Click(object sender, EventArgs e)
        {
            panelEliminarActividades.Visible = false;
            panelEliminarElemento.Visible = false;
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            panelEliminarEventos.Visible = true;
            //gtvActividadesEliminar.DataSource = Administradores.VerEventosTotales(conexion.Conexion, AdminLoginCache.Nombre);
            gtvActividadesEliminar.ForeColor = Color.Black;
        }

        private void picCerrarEliminarEventos_Click(object sender, EventArgs e)
        {
            panelEliminarElemento.Visible = false;
        }

        private void FrmPerfilAdmin_Load(object sender, EventArgs e)
        {
            panelEliminarActividades.Visible = false;
            panelEliminarElemento.Visible = false;
            panelEliminarElemento.Visible = false;
            panelAñadirElementos.Visible = false;
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            panelUser.Visible = !panelUser.Visible;
        }
    }
}
