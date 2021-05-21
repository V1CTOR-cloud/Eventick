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

            if (cmbTipoEvento.SelectedItem == null || cmbTipoActividadEvento.SelectedItem == null || String.IsNullOrEmpty(txtTituloEvento.Text)  || String.IsNullOrEmpty(txtDescripcionEvento.Text) || String.IsNullOrEmpty(txtPrecio.Text) || String.IsNullOrEmpty(txtLocalidad.Text) || cambiaHoras == false || dtpFechaEvento.Checked ==  false)
            {

                // OJO: CComprobar --> dtpFechaEvento.Checked ==  false

                MessageBox.Show("Debes rellenar todos los campos", "Información", MessageBoxButtons.OK);

            }
            else
            {

                Administradores admin = new Administradores();
                Eventos ev = new Eventos();

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
                    ev.Duracion = DateTime.Parse(nupCuentaHoras.Value.ToString());
                    ev.Fecha = dtpFechaEvento.Value;

                    admin.AgregarEvento(conexion.Conexion, ev);

                }

            }
        }

        private void nupCuentaHoras_ValueChanged(object sender, EventArgs e)
        {
            cambiaHoras = true;
        }

    }
}
