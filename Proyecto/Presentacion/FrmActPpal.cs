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
    public partial class FrmActPpal : Form
    {
        Image favoritovacio = Image.FromFile(@"..\..\..\Iconos\corazonvacio.png");
        Image favoritolleno = Image.FromFile(@"..\..\..\Iconos\corazonrojo.png");
        ConexionBD conexion = new ConexionBD();
        Color colorBotonesActivos = Color.FromArgb(230, 240, 229);
        Color colorBotonesActivosAdmin = Color.FromArgb(229,232,239);
        public FrmActPpal()
        {
            InitializeComponent();
            cbbTipo.SelectedIndex = 0;
            cbbTiempo.SelectedIndex = 0;
            cbbDificultad.SelectedIndex = 0;
            lblDistancia.Text = trbDistancia.Value.ToString() + " km";

            txtPalabraClave.Text = "PALABRA CLAVE";
            txtPalabraClave.Font = new Font(txtPalabraClave.Font, FontStyle.Bold);
            txtPalabraClave.ForeColor = Color.Gray;

            txtLocalidad.Text = "LOCALIDAD";
            txtLocalidad.Font = new Font(txtLocalidad.Font, FontStyle.Bold);
            txtLocalidad.ForeColor = Color.Gray;


            btnEvento.BackColor = Color.Transparent;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("¿Salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelAviso.Visible = false;
            List<Actividad> lista = new List<Actividad>();
            if (conexion.AbrirConexion())
            {
                lista = Actividad.CargarActividades(conexion.Conexion);
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
            conexion.CerrarConexion();

            if (string.IsNullOrEmpty(UserLoginCache.Nombre))
            {
                panel2.BackColor = Color.FromArgb(229, 232, 239);
                cbbTipo.BackColor = Color.FromArgb(70, 130, 180);
                btnActividad.BackColor = colorBotonesActivosAdmin;
            }
            else
            {
                btnActividad.BackColor = colorBotonesActivos;
            }


            foreach (Actividad act in lista)
            {
                Panel panelNoticia = new Panel() { /*Name = "panelNoticia",*/ BackColor = Color.Transparent, Size = new Size(850, 145) };
                flpNoticias.Controls.Add(panelNoticia);
                PictureBox picNoticia = new PictureBox() { /*Name = "picNoticia",*/ Image = Image.FromFile(@"..\..\..\Iconos\yo.jpg"), Size = new Size(241, 135), SizeMode = PictureBoxSizeMode.Normal };
                panelNoticia.Controls.Add(picNoticia);
                LinkLabel llblTitulo = new LinkLabel() { Name = act.Id, Location = new Point(261, 2), Text = act.Titulo, AutoSize=true };
                panelNoticia.Controls.Add(llblTitulo);
                Label lblLocalidad = new Label() { /*Name = "lblLocalidad",*/ AutoSize=true, Location = new Point(264, 24), Text = act.Localidad, Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold) };
                panelNoticia.Controls.Add(lblLocalidad);
                Panel panelInfo = new Panel() { /*Name = "panelInfo",*/ BackColor = Color.Transparent, Size = new Size(588, 25), Location = new Point(276, 46) };
                panelNoticia.Controls.Add(panelInfo);
                Label lblInfo3 = new Label() { /*Name = "lblInfo3",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Circular==1 ? "Circular":"No circular" };
                panelInfo.Controls.Add(lblInfo3);
                Label lblInfo4 = new Label() { /*Name = "lblInfo4",*/ AutoSize = true, Dock = DockStyle.Left, Text = "|" };
                panelInfo.Controls.Add(lblInfo4);
                Label lblInfo5 = new Label() { /*Name = "lblInfo5",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Dificultad };
                panelInfo.Controls.Add(lblInfo5);
                Label lblInfo6 = new Label() { /*Name = "lblInfo6",*/ AutoSize = true, Dock = DockStyle.Left, Text = "|" };
                panelInfo.Controls.Add(lblInfo6);
                Label lblInfo7 = new Label() { /*Name = "lblInfo7",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Duracion.ToString("t") + " horas"};
                panelInfo.Controls.Add(lblInfo7);
                Label lblInfo8 = new Label() { /*Name = "lblInfo8",*/ AutoSize = true, Dock = DockStyle.Left, Text = "|" };
                panelInfo.Controls.Add(lblInfo8);
                Label lblInfo9 = new Label() { /*Name = "lblInfo9",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Distancia.ToString() + " km" };
                panelInfo.Controls.Add(lblInfo9);
                PictureBox picFavorito = new PictureBox() { /*Name = "picFavorito",*/ Cursor = Cursors.Hand, Image = favoritovacio, Size = new Size(35, 35), Location = new Point(261, 100), SizeMode = PictureBoxSizeMode.Zoom };
                panelNoticia.Controls.Add(picFavorito);
                string nombre = "pic" + act.Id;
                PictureBox picCompartir = new PictureBox() { Name = nombre,Cursor=Cursors.Hand, Image = Image.FromFile(@"..\..\..\Iconos\compartir.png"), Size = new Size(35, 35), Location = new Point(300, 100), SizeMode = PictureBoxSizeMode.Zoom };
                panelNoticia.Controls.Add(picCompartir);
                picFavorito.Click += new EventHandler(picFavorito_Click);
                llblTitulo.Click += new EventHandler(llblTitulo_Click);
                picCompartir.Click += new EventHandler(picCompartir_Click);
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

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            if (cbx != null)
            {
                e.DrawBackground();

                if (e.Index >= 0)
                {
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    Brush brush = new SolidBrush(cbx.ForeColor);

                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        brush = SystemBrushes.HighlightText;

                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }


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


        private void btnEvento_Click(object sender, EventArgs e)
        {
            if (btnEvento.BackColor == Color.Transparent && btnActividad.BackColor == colorBotonesActivos)
            {
                btnEvento.BackColor = Color.FromArgb(230, 240, 229);
                btnActividad.BackColor = Color.Transparent;
            }
            FrmEventoUsuario eventos = new FrmEventoUsuario();
            eventos.Show();
            this.Hide();
        }

        private void trbDistancia_Scroll(object sender, EventArgs e)
        {
            lblDistancia.Text = trbDistancia.Value.ToString() + " km";
        }

        private void txtPalabraClave_Enter(object sender, EventArgs e)
        {
            if(txtPalabraClave.Text=="PALABRA CLAVE")
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picUser_Click(object sender, EventArgs e)
        {
            panelUser.Visible = !panelUser.Visible;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AdminLoginCache.Nombre)) {
                this.Hide();
                frmPerfilUsuario perfilusu = new frmPerfilUsuario();
                perfilusu.Show();
            }
            else
            {
                this.Hide();
                FrmPerfilAdmin perfiladm = new FrmPerfilAdmin();
                perfiladm.Show();

            }
        }

        private void llblTitulo_Click(object sender, EventArgs e)
        {
            LinkLabel titulo = sender as LinkLabel;
            FrmFichaActividad fichaact = new FrmFichaActividad(titulo.Name);
            fichaact.Show();
            this.Hide();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {
                if (conexion.AbrirConexion())
                {
                    if (Actividad.FiltroPalabraClave(conexion.Conexion, txtBuscar.Text).Count > 0)
                    {
                        // INSERTAR CARGA
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        picAviso.Image = Image.FromFile(@"..\..\..\Iconos\error404.png");
                        lblAvisoTitulo.Text = "Error 404";
                        lblSubtitulo.Text = "¡Vaya! No se ha podido encontrar el evento deseado";
                        PanelAviso.Visible = true;
                        conexion.CerrarConexion();
                    }
                }
                else
                {
                    picAviso.Image = Image.FromFile(@"..\..\..\Iconos\aviso_bbdd.png");
                    lblAvisoTitulo.Text = "Servidor desconectado";
                    lblSubtitulo.Text = "¡Ups! El servidor se encuentra apagado";
                    conexion.CerrarConexion();
                }
            }
            else
            {
                picAviso.Image = Image.FromFile(@"..\..\..\Iconos\confusion.png");
                lblAvisoTitulo.Text = "No has buscado nada";
                lblSubtitulo.Text = "¡Repampanos! Al menos podrías haber buscado algo";
                PanelAviso.Visible = true;
                conexion.CerrarConexion();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (conexion.AbrirConexion())
            {
                if (cbbTipo.Text != string.Empty)
                {
                    if (Actividad.FiltroTipo(conexion.Conexion, TipoSeleccionado()).Count > 0)
                    {
                        List<Actividad> lista = new List<Actividad>();
                        lista = Actividad.FiltroTipo(conexion.Conexion, TipoSeleccionado());
                        flpNoticias.Controls.Clear();
                        foreach (Actividad act in lista)
                        {
                            PanelAviso.Visible = false;                            
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
                            Label lblInfo3 = new Label() { /*Name = "lblInfo3",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Circular == 1 ? "Circular" : "No circular" };
                            panelInfo.Controls.Add(lblInfo3);
                            Label lblInfo4 = new Label() { /*Name = "lblInfo4",*/ AutoSize = true, Dock = DockStyle.Left, Text = "|" };
                            panelInfo.Controls.Add(lblInfo4);
                            Label lblInfo5 = new Label() { /*Name = "lblInfo5",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Dificultad };
                            panelInfo.Controls.Add(lblInfo5);
                            Label lblInfo6 = new Label() { /*Name = "lblInfo6",*/ AutoSize = true, Dock = DockStyle.Left, Text = "|" };
                            panelInfo.Controls.Add(lblInfo6);
                            Label lblInfo7 = new Label() { /*Name = "lblInfo7",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Duracion.ToString("t") + " horas" };
                            panelInfo.Controls.Add(lblInfo7);
                            Label lblInfo8 = new Label() { /*Name = "lblInfo8",*/ AutoSize = true, Dock = DockStyle.Left, Text = "|" };
                            panelInfo.Controls.Add(lblInfo8);
                            Label lblInfo9 = new Label() { /*Name = "lblInfo9",*/ AutoSize = true, Dock = DockStyle.Left, Text = act.Distancia.ToString() + " km" };
                            panelInfo.Controls.Add(lblInfo9);
                            PictureBox picFavorito = new PictureBox() { /*Name = "picFavorito",*/ Cursor = Cursors.Hand, Image = favoritovacio, Size = new Size(35, 35), Location = new Point(261, 100), SizeMode = PictureBoxSizeMode.Zoom };
                            panelNoticia.Controls.Add(picFavorito);
                            PictureBox picCompartir = new PictureBox() { /*Name = "picCompartir",*/ Image = Image.FromFile(@"..\..\..\Iconos\compartir.png"), Size = new Size(35, 35), Location = new Point(300, 100), SizeMode = PictureBoxSizeMode.Zoom };
                            panelNoticia.Controls.Add(picCompartir);
                            picFavorito.Click += new EventHandler(picFavorito_Click);
                            llblTitulo.Click += new EventHandler(llblTitulo_Click);
                        }
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        PanelAviso.Visible = true;
                        conexion.CerrarConexion();
                    }
                }
                else
                {
                    if (txtPalabraClave.Text != string.Empty)
                    {                        
                        Actividad.FiltroPalabraClave(conexion.Conexion, txtPalabraClave.Text);
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        if (txtLocalidad.Text != string.Empty)
                        {
                            Actividad.FiltroLocalidad(conexion.Conexion, txtLocalidad.Text);
                            conexion.CerrarConexion();
                        }
                        else
                        {
                            Actividad.FiltroKm(conexion.Conexion, trbDistancia.Value);

                            if (cbbDificultad.Text != string.Empty)
                            {
                                Actividad.FiltroDificultad(conexion.Conexion, cbbDificultad.Text);
                                conexion.CerrarConexion();
                            }
                            else
                            {
                                if (chkCircular.Checked)
                                {
                                    Actividad.FiltroCircular(conexion.Conexion, 1);
                                    conexion.CerrarConexion();
                                }                                
                            }
                        }
                    }
                }
            }
            else
            {
                picAviso.Image = Image.FromFile(@"..\..\..\Iconos\aviso_bbdd.png");
                lblAvisoTitulo.Text = "Servidor desconectado";
                lblSubtitulo.Text = "¡Ups! El servidor se encuentra apagado";
            }
        }

        private int TipoSeleccionado()
        {
            switch (cbbTipo.Text)
            {
                case "SENDERISMO":
                    return 1;

                case "ANDAR":
                    return 2;

                case "CORRER":
                    return 3;

                case "CAMINATA":
                    return 4;

                default:
                    return 0;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn login = new frmLogIn();
            login.Show();
        }

        private void picCompartir_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            Clipboard.SetText(pic.Name.Substring(3));
        }
    }
}
