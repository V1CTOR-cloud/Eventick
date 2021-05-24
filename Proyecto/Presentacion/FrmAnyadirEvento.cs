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
    public partial class FrmAñadirEvento : Form
    {

        ConexionBD conexion = new ConexionBD();
        bool cambiaHoras;


        public FrmAñadirEvento()
        {
            InitializeComponent();
        }


        private void picUser_Click(object sender, EventArgs e)
        {
            panelUser.Visible = !panelUser.Visible;

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (cmbTipoEvento.SelectedItem == null || cmbTipoActividadEvento.SelectedItem == null || String.IsNullOrEmpty(txtTituloEvento.Text)  || String.IsNullOrEmpty(txtDescripcionEvento.Text) || String.IsNullOrEmpty(txtPrecio.Text) || String.IsNullOrEmpty(txtLocalidad.Text))
            {

                // OJO: CComprobar --> dtpFechaEvento.Checked ==  false

                MessageBox.Show("Debes rellenar todos los campos", "Información", MessageBoxButtons.OK);

            }
            else
            {

                Administradores admin = new Administradores();
                Eventos ev = new Eventos(cmbTipoActividadEvento.SelectedItem.ToString(),AdminLoginCache.CP);
                DialogResult result;
                result = MessageBox.Show("Crear este evento", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ev.TipoEvento = cmbTipoEvento.SelectedItem.ToString();
                    ev.TipoActividadEvento = cmbTipoActividadEvento.SelectedItem.ToString();
                    ev.Titulo = txtTituloEvento.Text;
                    ev.Descripcion = txtDescripcionEvento.Text;
                    ev.Precio = double.Parse(txtPrecio.Text);
                    ev.Localidad = txtLocalidad.Text;
                    DateTime horitas = new DateTime(2021, 01, 01, Convert.ToInt32(nupCuentaHoras.Value), 00, 00);

                    ev.Duracion = Convert.ToDateTime(horitas);
                    //ev.Fecha = dtpFechaEvento.Value;
                    if (conexion.AbrirConexion()) {
                        Administradores.AgregarEvento(conexion.Conexion, ev,AdminLoginCache.Nombre);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido conectar con la base de datos", "Error - Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }

            }
        }

        private void nupCuentaHoras_ValueChanged(object sender, EventArgs e)
        {
            cambiaHoras = true;
        }

        private void cmbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoEvento.SelectedIndex == 0)
            {
                cmbTipoActividadEvento.Items.Clear();
                cmbTipoActividadEvento.Items.Add("Concierto");
                cmbTipoActividadEvento.Items.Add("Escape Room");
                cmbTipoActividadEvento.Items.Add("Bar con musica en directo");

            }
            else if (cmbTipoEvento.SelectedIndex == 1)
            {
                cmbTipoActividadEvento.Items.Clear();
                cmbTipoActividadEvento.Items.Add("Teatro - Danza");
                cmbTipoActividadEvento.Items.Add("Museo - Exposiciones");
                cmbTipoActividadEvento.Items.Add("Visitas guiadas");
            }
            else
            {
                cmbTipoActividadEvento.Items.Clear();
                cmbTipoActividadEvento.Items.Add("Baloncesto");
                cmbTipoActividadEvento.Items.Add("Tenis");
                cmbTipoActividadEvento.Items.Add("Futbol");
                cmbTipoActividadEvento.Items.Add("Otros deportes");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AdminLoginCache.Nombre))
            {
                frmPerfilUsuario perfil = new frmPerfilUsuario();
                perfil.Show();
                this.Hide();
            }
            else
            {
                FrmPerfilAdmin perfil = new FrmPerfilAdmin();
                perfil.Show();
                this.Hide();

            }
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

        private void picAtras_Click(object sender, EventArgs e)
        {
            FrmPerfilAdmin perfil = new FrmPerfilAdmin();
            perfil.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn login = new frmLogIn();
            login.Show();
        }
    }
}
