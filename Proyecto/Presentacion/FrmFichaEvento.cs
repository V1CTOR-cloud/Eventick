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
    public partial class FrmFichaEvento : Form
    {
        string id;
        ConexionBD conexion = new ConexionBD();
        public FrmFichaEvento(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FrmFichaEvento_Load(object sender, EventArgs e)
        {
            Eventos act = new Eventos();
            act.Id = id;
            if (conexion.AbrirConexion())
            {
                act.VerFichaEvento(conexion.Conexion);
                conexion.CerrarConexion();
            }
            lblPrecioEvento.Text = act.Precio.ToString()+" €";
            lblDuracionEvento.Text = act.Duracion.ToString("HH")+" horas";
            txtDescripcion.Text = act.Descripcion;
            lblLocalidad.Text = act.Localidad;
            llblNombreEvento.Text = act.Titulo;
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            FrmEventoUsuario homeevento = new FrmEventoUsuario();
            homeevento.Show();
            this.Hide();
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
    }
}
