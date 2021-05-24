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
    public partial class FrmEventoUsuario : Form
    {
        ConexionBD conexion = new ConexionBD();

        private void EventosUsuario_Load(object sender, EventArgs e)
        {
            btnEvento.BackColor = Color.FromArgb(230, 240, 229);
            btnActividad.BackColor = Color.Transparent;
            if (string.IsNullOrEmpty(UserLoginCache.Nombre))
            {
                panel2.BackColor = Color.FromArgb(229, 232, 239);
                cbbTipo.BackColor = Color.FromArgb(70, 130, 180);
                cmbTipoEvento.BackColor = Color.FromArgb(70, 130, 180);
                btnEvento.BackColor = colorBotonesActivosAdmin;
            }
            else
            {
                btnEvento.BackColor = colorBotonesActivos;
            }
            List<Eventos> lista = new List<Eventos>();
            if (conexion.AbrirConexion())
            {
                lista = Eventos.CargarEventos(conexion.Conexion);
                foreach (Eventos act in lista)
                {
                    Panel panelNoticia = new Panel() { /*Name = "panelNoticia",*/ BackColor = Color.Transparent, Size = new Size(850, 145) };
                    flpNoticias.Controls.Add(panelNoticia);
                    PictureBox picNoticia = new PictureBox() { /*Name = "picNoticia",*/ Image = Image.FromFile(@"..\..\..\Iconos\yo.jpg"), Size = new Size(241, 135), SizeMode = PictureBoxSizeMode.Normal };
                    panelNoticia.Controls.Add(picNoticia);
                    LinkLabel llblTitulo = new LinkLabel() { Name = act.Id, Location = new Point(261, 2), Text = act.Titulo, AutoSize = true };
                    panelNoticia.Controls.Add(llblTitulo);
                    Label lblLocalidad = new Label() { /*Name = "lblLocalidad",*/ AutoSize = true, Location = new Point(264, 24), Text = act.Localidad, Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold) };
                    panelNoticia.Controls.Add(lblLocalidad);
                    Panel panelInfo = new Panel() { /*Name = "panelInfo",*/ BackColor = Color.Transparent, Size = new Size(588, 25), Location = new Point(276, 46) };
                    panelNoticia.Controls.Add(panelInfo);
                    Label lblInfo5 = new Label() { /*Name = "lblInfo5",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Precio.ToString() + " €" };
                    panelInfo.Controls.Add(lblInfo5);
                    Label lblInfo6 = new Label() { /*Name = "lblInfo6",*/ AutoSize = true, Dock = DockStyle.Left, Text = "|" };
                    panelInfo.Controls.Add(lblInfo6);
                    Label lblInfo7 = new Label() { /*Name = "lblInfo7",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Duracion.ToString("t") + " horas" };
                    panelInfo.Controls.Add(lblInfo7);
                    Label lblInfo8 = new Label() { /*Name = "lblInfo8",*/ AutoSize = true, Dock = DockStyle.Left, Text = "|" };
                    panelInfo.Controls.Add(lblInfo8);
                    Label lblInfo9 = new Label() { /*Name = "lblInfo9",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.TipoActividadEvento };
                    panelInfo.Controls.Add(lblInfo9);
                    PictureBox picFavorito = new PictureBox() { /*Name = "picFavorito",*/ Cursor = Cursors.Hand, Image = favoritovacio, Size = new Size(35, 35), Location = new Point(261, 100), SizeMode = PictureBoxSizeMode.Zoom };
                    panelNoticia.Controls.Add(picFavorito);
                    PictureBox picCompartir = new PictureBox() { /*Name = "picCompartir",*/ Image = Image.FromFile(@"..\..\..\Iconos\compartir.png"), Size = new Size(35, 35), Location = new Point(300, 100), SizeMode = PictureBoxSizeMode.Zoom };
                    panelNoticia.Controls.Add(picCompartir);
                    picFavorito.Click += new EventHandler(picFavorito_Click);
                    llblTitulo.Click += new EventHandler(llblTitulo_Click);
                }
            }

        }


        Image favoritovacio = Image.FromFile(@"..\..\..\Iconos\corazonvacio.png");
        Image favoritolleno = Image.FromFile(@"..\..\..\Iconos\corazonrojo.png");
        Color colorBotonesActivosAdmin = Color.FromArgb(229, 232, 239);


        public FrmEventoUsuario()
        {
            InitializeComponent();
            nupCuentaHoras.DecimalPlaces = 1;

            cbbTipo.SelectedIndex = 0;
            //cmbTipoEvento.SelectedIndex = 0;
            cbbPrecioMin.SelectedIndex = 0;
            cbbPrecioMax.SelectedIndex = 0;


            txtPalabraClave.Text = "PALABRA CLAVE";
            txtPalabraClave.Font = new Font(txtPalabraClave.Font, FontStyle.Bold);
            txtPalabraClave.ForeColor = Color.Gray;

            txtLocalidad.Text = "LOCALIDAD";
            txtLocalidad.Font = new Font(txtLocalidad.Font, FontStyle.Bold);
            txtLocalidad.ForeColor = Color.Gray;


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

            result = MessageBox.Show("¿Salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
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
            if (btnActividad.BackColor == Color.Transparent && btnEvento.BackColor == colorBotonesActivos)
            {
                btnActividad.BackColor = Color.FromArgb(230, 240, 229);
                btnEvento.BackColor = Color.Transparent;
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

        private void btnActividad_Click_1(object sender, EventArgs e)
        {
            FrmActPpal formulario = new FrmActPpal();
            formulario.Visible = true;
            Visible = false;
        }
        private void llblTitulo_Click(object sender, EventArgs e)
        {
            LinkLabel titulo = sender as LinkLabel;
            FrmFichaEvento fichaact = new FrmFichaEvento(titulo.Name);
            fichaact.Show();
            this.Hide();
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn login = new frmLogIn();
            login.Show();
        }
    }
}

