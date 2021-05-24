using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Eventick
{
    public partial class FrmFichaActividad : Form
    {
        private string id;
        ConexionBD conexion = new ConexionBD();

        public FrmFichaActividad(string ident)
        {
            InitializeComponent();
            id = ident;
        }

        
        Image favoritovacio = Image.FromFile(@"..\..\..\Iconos\corazonvacio.png");
        Image favoritolleno = Image.FromFile(@"..\..\..\Iconos\corazonrojo.png");

        private void picSalir_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("¿Salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picFavorito_Click(object sender, EventArgs e)
        {
            PictureBox picFavorito = sender as PictureBox;

            if (picFavorito.Image == favoritovacio)
            {
                picFavorito.Image = favoritolleno;
            }
            else
            {
                picFavorito.Image = favoritovacio;
            }
        }

        private void FrmFichaActividad_Load(object sender, EventArgs e)
        {

            Actividad act = new Actividad();
            act.Id = id;
            if (conexion.AbrirConexion())
            {
                act.CargarFichaAct(conexion.Conexion);
            }
            conexion.CerrarConexion();

            llblTituloActividad.Text = act.Titulo;
            lblLocalidad.Text = act.Localidad;
            lblKmDistancia.Text = act.Distancia.ToString();
            lblCircularSiNo.Text = act.Circular==1?"Si":"No";
            lblDificultad.Text = act.Dificultad;
            lblDuracion.Text = act.Duracion.ToString("HH")+" h";
            txtDescripcion.Text = act.Descripcion;
            picDificultad.Image = act.Dificultad=="Baja"?Image.FromFile(@"..\..\..\Iconos\difbaja.png"):act.Dificultad=="Media"? Image.FromFile(@"..\..\..\Iconos\difmedia.png"): Image.FromFile(@"..\..\..\Iconos\difalta.png");
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            FrmActPpal home = new FrmActPpal();
            home.Show();
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
