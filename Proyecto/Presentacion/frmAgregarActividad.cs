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
    public partial class frmAgregarActividad : Form
    {
        ConexionBD conexion = new ConexionBD();
        bool caminar;
        bool trackScroll = false;
        bool cambiaHoras;

        public frmAgregarActividad()
        {
            InitializeComponent();
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            panelUser.Visible = !panelUser.Visible;

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (cbbTipo.SelectedItem == null || String.IsNullOrEmpty(txtTituloActividad.Text) || String.IsNullOrEmpty(txtDescripcionActividad.Text) || String.IsNullOrEmpty(txtLocalidad.Text) || cmbDificultad.SelectedItem == null)
            {

                MessageBox.Show("Debes rellenar todos los campos", "Información", MessageBoxButtons.OK);

            }
            else
            {

                Administradores admin = new Administradores();


                DialogResult result;

                result = MessageBox.Show("Crear esta actividad", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Actividad act = new Actividad(cbbTipo.SelectedItem.ToString(), AdminLoginCache.CP);

                    act.APie = caminar;
                    act.TipoActividad = cbbTipo.SelectedItem.ToString();
                    act.Titulo = txtTituloActividad.Text;
                    act.Descripcion = txtDescripcionActividad.Text;
                    act.Localidad = txtLocalidad.Text;
                    act.Distancia = Convert.ToDouble(trbDistancia.Value);
                    DateTime horitas = new DateTime(2021, 01, 01, Convert.ToInt32(nupCuentaHoras.Value), 00, 00);
                    act.Duracion = horitas;
                    act.Dificultad = cmbDificultad.SelectedItem.ToString();
                    act.Localidad = AdminLoginCache.Localidad;
                    if (conexion.AbrirConexion())
                    {
                        Administradores.AgregarActividad(conexion.Conexion, act, AdminLoginCache.Nombre);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido conectar con la base de datos", "Error - Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }

            }
        }



        private void picAPie_Click(object sender, EventArgs e)
        {
            caminar = true;
        }

        private void picEnBici_Click(object sender, EventArgs e)
        {
            caminar = false;
        }

        private void trbDistancia_Scroll(object sender, EventArgs e)
        {
            lblDistancia.Text = trbDistancia.Value + " km";
        }

        private void nupCuentaHoras_ValueChanged(object sender, EventArgs e)
        {
            cambiaHoras = true;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void FrmActPpal_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FrmActPpal_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void FrmActPpal_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            FrmPerfilAdmin perfiladmin = new FrmPerfilAdmin();
            perfiladmin.Show();
            this.Dispose();
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

        private void frmAgregarActividad_Load(object sender, EventArgs e)
        {
            lblDistancia.Text = trbDistancia.Value.ToString() + " km";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn login = new frmLogIn();
            login.Show();
        }
    }
}
