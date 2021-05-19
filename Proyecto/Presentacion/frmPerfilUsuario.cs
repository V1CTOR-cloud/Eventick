﻿using System;
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
    public partial class frmPerfilUsuario : Form
    {
        public frmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void panelNavegacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool mouseDown;
        private Point lastLocation;

        private void panelBorde_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panelBorde_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void panelBorde_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            panelUser.Visible = !panelUser.Visible;
        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {
            string nombre = UserLoginCache.Nombre == "" ? AdminLoginCache.Nombre : UserLoginCache.Nombre + ' ' + UserLoginCache.Apellidos;
            lblNombreAdm.Text = nombre;
            string cp = UserLoginCache.Nombre == "" ? AdminLoginCache.CP.ToString() : UserLoginCache.CP.ToString(); ;
            lblCPAdmin.Text = cp;
            string localidad = UserLoginCache.Nombre == "" ? AdminLoginCache.Localidad : UserLoginCache.Localidad;
            lblLocalidadAdm.Text =localidad;
            string email = UserLoginCache.Nombre =="" ? AdminLoginCache.Email:UserLoginCache.Email;
            lblCorreoAdmin.Text = email;
        }

        private void lblEditarDatosAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
