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
    public partial class FrmEventoAdmin : Form
    {
        Image favoritovacio = Image.FromFile(@"..\..\..\Iconos\corazonvacio.png");
        Image favoritolleno = Image.FromFile(@"..\..\..\Iconos\corazonrojo.png");

        public FrmEventoAdmin()
        {
            InitializeComponent();
            nupCuentaHoras.DecimalPlaces = 1;

            //cbbTipo.SelectedIndex = 0;
            cbbPrecioMin.SelectedIndex = 0;
            cbbPrecioMax.SelectedIndex = 0;

            picMaximizar.Image = Image.FromFile(@"..\..\..\Iconos\maximizar2.png");

            txtPalabraClave.Text = "PALABRA CLAVE";
            txtPalabraClave.Font = new Font(txtPalabraClave.Font, FontStyle.Bold);
            txtPalabraClave.ForeColor = Color.Gray;

            txtLocalidad.Text = "LOCALIDAD";
            txtLocalidad.Font = new Font(txtLocalidad.Font, FontStyle.Bold);
            txtLocalidad.ForeColor = Color.Gray;


            btnActividad.BackColor = colorBotonesActivos;
            btnEvento.BackColor = Color.Transparent;



        }

        private void FrmEventoAdmin_Load(object sender, EventArgs e)
        {
            nupCuentaHoras.Cursor = Cursors.Arrow;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            btnEvento.BackColor = Color.FromArgb(229, 232, 239);
            btnActividad.BackColor = Color.Transparent;
        }



        private void picInfo_MouseEnter(object sender, EventArgs e)
        {
            this.ttInfoCuentaHoras.SetToolTip(this.picInfo, "Tiempo en horas");
        }

        private void nupCuentaHoras_Enter(object sender, EventArgs e)
        {
            nupCuentaHoras.Cursor = Cursors.Arrow;
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            DialogResult result;
            
            result = MessageBox.Show("¿Salir de la aplicación?","Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes )
            {
                Application.Exit();
            } 
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toggPruebaPaneles_CheckedChanged(object sender, EventArgs e)
        {
            Panel panelNoticia = new Panel() { Name = "panelNoticia", BackColor = Color.Transparent, Size = new Size(850, 145) };
            flpNoticias.Controls.Add(panelNoticia);
            PictureBox picNoticia = new PictureBox() { Name = "picNoticia", Image = Image.FromFile(@"..\..\Iconos\yo.jpg"), Size = new Size(241, 135), SizeMode = PictureBoxSizeMode.Normal };
            panelNoticia.Controls.Add(picNoticia);
            LinkLabel llblTitulo = new LinkLabel() { Name = "llblTitulo", Location = new Point(261, 2), Text = "Hola" };
            panelNoticia.Controls.Add(llblTitulo);
            Label lblLocalidad = new Label() { Name = "lblLocalidad", Location = new Point(264, 24), Text = "Casa", Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold) };
            panelNoticia.Controls.Add(lblLocalidad);
            Panel panelInfo = new Panel() { Name = "panelInfo", BackColor = Color.Transparent, Size = new Size(588, 25), Location = new Point(276, 46) };
            panelNoticia.Controls.Add(panelInfo);
            Label lblInfo1 = new Label() { Name = "lblInfo1", AutoSize = true, Dock = DockStyle.Left, Text = "466m" };
            panelInfo.Controls.Add(lblInfo1);
            Label lblInfo2 = new Label() { Name = "lblInfo2", AutoSize = true, Dock = DockStyle.Left, Text = "|" };
            panelInfo.Controls.Add(lblInfo2);
            Label lblInfo3 = new Label() { Name = "lblInfo3", AutoSize = true, Dock = DockStyle.Left, Text = "Circular" };
            panelInfo.Controls.Add(lblInfo3);
            Label lblInfo4 = new Label() { Name = "lblInfo4", AutoSize = true, Dock = DockStyle.Left, Text = "|" };
            panelInfo.Controls.Add(lblInfo4);
            Label lblInfo5 = new Label() { Name = "lblInfo5", AutoSize = true, Dock = DockStyle.Left, Text = "Media" };
            panelInfo.Controls.Add(lblInfo5);
            Label lblInfo6 = new Label() { Name = "lblInfo6", AutoSize = true, Dock = DockStyle.Left, Text = "|" };
            panelInfo.Controls.Add(lblInfo6);
            Label lblInfo7 = new Label() { Name = "lblInfo7", AutoSize = true, Dock = DockStyle.Left, Text = "4h" };
            panelInfo.Controls.Add(lblInfo7);
            Label lblInfo8 = new Label() { Name = "lblInfo8", AutoSize = true, Dock = DockStyle.Left, Text = "|" };
            panelInfo.Controls.Add(lblInfo8);
            Label lblInfo9 = new Label() { Name = "lblInfo9", AutoSize = true, Dock = DockStyle.Left, Text = "12 km" };
            panelInfo.Controls.Add(lblInfo9);
            PictureBox picFavorito = new PictureBox() { Name = "picFavorito", Cursor = Cursors.Hand, Image = favoritovacio, Size = new Size(35, 35), Location = new Point(261, 100), SizeMode = PictureBoxSizeMode.Zoom };
            panelNoticia.Controls.Add(picFavorito);
            PictureBox picCompartir = new PictureBox() { Name = "picCompartir", Image = Image.FromFile(@"..\..\..\Iconos\compartir.png"), Size = new Size(35, 35), Location = new Point(300, 100), SizeMode = PictureBoxSizeMode.Zoom };
            panelNoticia.Controls.Add(picCompartir);
            picFavorito.Click += new EventHandler(picFavorito_Click);

        }

        Color colorBotonesActivos = Color.FromArgb(230, 240, 229);
        private void btnActividad_Click(object sender, EventArgs e)
        {
            FrmActividadAdmin formulario = new FrmActividadAdmin();
            formulario.Visible = true;
            Visible = false;
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


        private void txtPalabraClave_Enter(object sender, EventArgs e)
        {
            if (txtPalabraClave.Text == "PALABRA CLAVE")
            {
                txtPalabraClave.Text = "";
                txtPalabraClave.ForeColor = default;
                txtPalabraClave.Font = new Font(txtPalabraClave.Font, FontStyle.Regular);
            }
        }

        private void txtPalabraClave_Leave(object sender, EventArgs e)
        {
            if (txtPalabraClave.Text == "")
            {
                txtPalabraClave.Text = "PALABRA CLAVE";
                txtPalabraClave.Font = new Font(txtPalabraClave.Font, FontStyle.Bold);

                txtPalabraClave.ForeColor = Color.Gray;

            }
        }

        private void txtLocalidad_Enter(object sender, EventArgs e)
        {
            if (txtLocalidad.Text == "LOCALIDAD")
            {
                txtLocalidad.Text = "";
                txtLocalidad.ForeColor = default;
                txtLocalidad.Font = new Font(txtLocalidad.Font, FontStyle.Regular);

            }
        }

        private void txtLocalidad_Leave(object sender, EventArgs e)
        {
            if (txtLocalidad.Text == "")
            {
                txtLocalidad.Text = "LOCALIDAD";
                txtLocalidad.Font = new Font(txtLocalidad.Font, FontStyle.Bold);
                txtLocalidad.ForeColor = Color.Gray;
            }
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            panelUser.Visible = !panelUser.Visible;
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            if (btnEvento.BackColor == Color.Transparent && btnActividad.BackColor == colorBotonesActivos)
            {
                btnEvento.BackColor = Color.FromArgb(230, 240, 229);
                btnActividad.BackColor = Color.Transparent;
            }
        }

        private void cbbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTipo.SelectedIndex == 0)
            {
                cmbTipoEvento.Items.Clear();
                cmbTipoEvento.Items.Add("Concierto");
                cmbTipoEvento.Items.Add("Escape Room");
                cmbTipoEvento.Items.Add("Bar con musica en directo");

            }
            else if (cbbTipo.SelectedIndex == 1)
            {
                cmbTipoEvento.Items.Clear();
                cmbTipoEvento.Items.Add("Teatro - Danza");
                cmbTipoEvento.Items.Add("Museo - Exposiciones");
                cmbTipoEvento.Items.Add("Visitas guiadas");
            }
            else
            {
                cmbTipoEvento.Items.Clear();
                cmbTipoEvento.Items.Add("Baloncesto");
                cmbTipoEvento.Items.Add("Tenis");
                cmbTipoEvento.Items.Add("Futbol");
                cmbTipoEvento.Items.Add("Otros deportes");

            }
        }

        private void picMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                picMaximizar.Image = Image.FromFile(@"..\..\..\Iconos\maximizar2.png");
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                picMaximizar.Image = Image.FromFile(@"..\..\..\Iconos\maximizar.png");

                this.WindowState = FormWindowState.Normal;
            }
        }

        private void picUser_Click_1(object sender, EventArgs e)
        {
            panelUser.Visible = !panelUser.Visible;

        }
    }
}
