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
    public partial class frmPerfilUsuario : Form
    {
        public frmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void panelNavegacion_Paint(object sender, PaintEventArgs e)
        {

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

        private void picSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            panelUser.Visible = !panelUser.Visible;
        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {
            lblNombreAdm.Text = UserLoginCache.Nombre;
            lblApellidosAdm.Text = UserLoginCache.Apellidos;
            lblCPAdmin.Text = UserLoginCache.CP.ToString();
            lblLocalidadAdm.Text =UserLoginCache.Localidad;
            lblCorreoAdmin.Text = UserLoginCache.Email;
        }

        private void lblEditarDatosAdmin_Click(object sender, EventArgs e)
        {
            lblNombreAdm.Visible = lblApellidos.Visible= lblCPAdmin.Visible = lblLocalidadAdm.Visible = lblCorreoAdmin.Visible = picSeguridad.Visible = !lblNombreAdm.Visible;
            txtNombre.Visible = txtApellidos.Visible=txtCP.Visible = txtLocalidad.Visible = txtEmail.Visible = txtPass.Visible = !txtCP.Visible;
            lblEditarDatosAdmin.Visible = !lblEditarDatosAdmin.Visible;
            btnAceptar.Visible = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estás seguro de guardar los cambios?","¿Seguro?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                lblNombreAdm.Visible=lblApellidos.Visible=lblCPAdmin.Visible = lblLocalidadAdm.Visible = lblCorreoAdmin.Visible = picSeguridad.Visible = !lblNombreAdm.Visible;
                txtNombre.Visible=txtApellidos.Visible=txtCP.Visible = txtLocalidad.Visible = txtEmail.Visible = txtPass.Visible = !txtCP.Visible;
                lblEditarDatosAdmin.Visible = true;
                btnAceptar.Visible = false;
                Usuarios usu = new Usuarios();

                usu.Nombre = txtNombre.Text;
                usu.Apellidos = txtApellidos.Text;
                usu.Cp = int.Parse(txtCP.Text);
                usu.Localidad = txtLocalidad.Text;
                usu.Email = txtEmail.Text;
                usu.Contraseña = txtPass.Text;
            }


        }
    }
}
