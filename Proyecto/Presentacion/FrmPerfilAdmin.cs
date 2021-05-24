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

                lblCorreoAdmin.Text = txtCambiarCorreo.Text;
                lblCorreoAdmin.Visible = true;
                picCandadoContraseña.Visible = true;
                Administradores admin = new Administradores();
                admin.Usuario = AdminLoginCache.Nombre;
                admin.Email = txtCambiarCorreo.Text;
                admin.Contraseña = txtCambiarContrasenya.Text;

                txtCambiarContrasenya.Visible = false;
                txtCambiarCorreo.Visible = false;

                if (conexion.AbrirConexion())
                {
                    admin.ModificarAdmin(conexion.Conexion);
                    conexion.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido conectar con la base de datos", "Error - Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
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
            Administradores admin = new Administradores();
            admin.Usuario = AdminLoginCache.Nombre;
            if (conexion.AbrirConexion())
            {
                gtvActividadesEliminar.DataSource = admin.TotalActividadesAdmin(conexion.Conexion);
                conexion.CerrarConexion();
            }
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
            Administradores admin = new Administradores();
            admin.Usuario = AdminLoginCache.Nombre;
            if (conexion.AbrirConexion())
            {
                dataGridView1.DataSource = admin.TotalEventosAdmin(conexion.Conexion);
                conexion.CerrarConexion();
            }
            dataGridView1.ForeColor = Color.Black;
            panelEliminarElemento.Visible = false;
        }

        private void picCerrarEliminarEventos_Click(object sender, EventArgs e)
        {
            panelEliminarEventos.Visible = false;
        }

        private void FrmPerfilAdmin_Load(object sender, EventArgs e)
        {
            panelEliminarActividades.Visible = false;
            panelEliminarElemento.Visible = false;
            panelEliminarElemento.Visible = false;
            panelAñadirElementos.Visible = false;

            Administradores admin = new Administradores();
            admin.Usuario = AdminLoginCache.Nombre;
            
            if (conexion.AbrirConexion())
            {
                lblCantActAdmin.Text = admin.TotalActAdmin(conexion.Conexion).ToString();
                lblCantEventosAdmin.Text = admin.TotalEvAdmin(conexion.Conexion).ToString();
                conexion.CerrarConexion();
            }

            lblNombreAdm.Text = AdminLoginCache.Nombre;
            lblCPAdmin.Text = AdminLoginCache.CP.ToString();
            lblLocalidadAdm.Text = AdminLoginCache.Localidad;
            lblCorreoAdmin.Text = AdminLoginCache.Email;
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            panelUser.Visible = !panelUser.Visible;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panelBorde_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelBorde_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelBorde_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            FrmActPpal home = new FrmActPpal();
            home.Show();
            this.Hide();

        }

        private void panelNavegacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("¿Salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnVerListaElementos_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn login = new frmLogIn();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count==1) 
            //{
            //    Administradores admin = new Administradores();
            //    admin.Usuario = AdminLoginCache.Nombre;
            //    int indice = dataGridView1.SelectedRows[0].Index;
            //    if (conexion.AbrirConexion())
            //    {
            //        Administradores.EliminarEvento(conexion.Conexion, dataGridView1.Rows[indice].Cells[0].Value.ToString());
            //        dataGridView1.DataSource = admin.TotalEventosAdmin(conexion.Conexion);

            //        conexion.CerrarConexion();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se ha podido conectar con la base de datos");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Selecciona 1 evento");
            //}
        }

        private void btnEliminarAct_Click(object sender, EventArgs e)
        {

        }

        private void picCerrarPanelEliminarActividades_Click_1(object sender, EventArgs e)
        {
            panelEliminarActividades.Visible = false;
        }
    }
}
