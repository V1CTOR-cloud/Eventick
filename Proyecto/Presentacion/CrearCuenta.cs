using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eventick
{
    public partial class CrearCuenta : Form
    {
        ConexionBD bdatos = new ConexionBD();

        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            frmLogIn inicio_sesion = new frmLogIn();
            inicio_sesion.Visible = true;
            Visible = false;
        }


        private void picMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Limpiacajas()
        {
            txtUsuario_Nombre.Clear();
            txtUsuario.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();
        }

        private bool NohaynombreAyuntamiento()
        {
            if (txtUsuario.Text.Contains("ayto"))
            {
                return false;
            }
            else
            {
                if (txtEmail.Text.Contains("ayto"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private int Cajasvacias()
        {
            if (txtUsuario_Nombre.Text == string.Empty && txtApellido.Text == string.Empty && txtEmail.Text == string.Empty && txtContraseña.Text == string.Empty && txtConfirmarContraseña.Text == string.Empty)
            {
                return 1;
            }
            else
            {
                if (txtUsuario_Nombre.Text == string.Empty)
                {
                    return 2;
                }
                else
                {
                    if (txtApellido.Text == string.Empty)
                    {
                        return 3;
                    }
                    else
                    {
                        if (txtUsuario.Text == string.Empty)
                        {
                            return 4;
                        }
                        else
                        {
                            if (txtEmail.Text == string.Empty)
                            {
                                return 5;
                            }
                            else
                            {
                                if (txtContraseña.Text == string.Empty)
                                {
                                    return 6;
                                }
                                else
                                {
                                    if (txtConfirmarContraseña.Text == string.Empty)
                                    {
                                        return 7;
                                    }
                                    else
                                    {
                                        return 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool ContraseñaConfirmada()
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panelBarranav_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelBarranav_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelBarranav_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
