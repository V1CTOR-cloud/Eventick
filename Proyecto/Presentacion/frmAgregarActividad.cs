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
        bool trackScroll =  false;
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

            if (cbbTipo.SelectedItem == null || String.IsNullOrEmpty(txtTituloActividad.Text) || String.IsNullOrEmpty(txtDescripcionActividad.Text) || String.IsNullOrEmpty(txtLocalidad.Text) || trackScroll ==  false || cambiaHoras == false || cmbDificultad.SelectedItem == null) {

                MessageBox.Show("Debes rellenar todos los campos", "Información", MessageBoxButtons.OK);

            }
            else { 

            Administradores admin = new Administradores();
            Actividad act = new Actividad();


                DialogResult result;

                result = MessageBox.Show("Crear esta actividad", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {                    
                        act.APie = caminar;
                        act.TipoActividad = cbbTipo.SelectedItem.ToString();
                        act.Titulo = txtTituloActividad.Text;
                        act.Descripcion = txtDescripcionActividad.Text;
                        act.Localidad = txtLocalidad.Text;
                        act.Distancia = double.Parse(lblDistancia.Text);
                        act.Duracion = DateTime.Parse(nupCuentaHoras.Value.ToString());
                        act.Dificultad = cmbDificultad.SelectedItem.ToString();
                        admin.AgregarActividad(conexion.Conexion, act);                    

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
            trackScroll = true;
        }

        private void nupCuentaHoras_ValueChanged(object sender, EventArgs e)
        {
            cambiaHoras = true;
        }
    }
}
