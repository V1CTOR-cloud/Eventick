
namespace Eventick
{
    partial class frmAgregarActividad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarActividad));
            this.panelBorde = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.panelNavegacion = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTituloActividad = new System.Windows.Forms.Label();
            this.txtTituloActividad = new System.Windows.Forms.TextBox();
            this.txtDescripcionActividad = new System.Windows.Forms.TextBox();
            this.LBLDescripcionActividad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.cmbDificultad = new System.Windows.Forms.ComboBox();
            this.nupCuentaHoras = new System.Windows.Forms.NumericUpDown();
            this.lblLocalidadAct = new System.Windows.Forms.Label();
            this.lblDuracionAct = new System.Windows.Forms.Label();
            this.picAñadirImagenActividad = new System.Windows.Forms.PictureBox();
            this.chkCircular = new System.Windows.Forms.CheckBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.picDistancia = new System.Windows.Forms.PictureBox();
            this.trbDistancia = new System.Windows.Forms.TrackBar();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.picAPie = new System.Windows.Forms.PictureBox();
            this.picEnBici = new System.Windows.Forms.PictureBox();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.panelBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            this.panelNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCuentaHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAñadirImagenActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDistancia)).BeginInit();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnBici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorde
            // 
            this.panelBorde.BackColor = System.Drawing.Color.White;
            this.panelBorde.Controls.Add(this.label1);
            this.panelBorde.Controls.Add(this.pictureBox5);
            this.panelBorde.Controls.Add(this.picMinimizar);
            this.panelBorde.Controls.Add(this.picSalir);
            this.panelBorde.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorde.Location = new System.Drawing.Point(0, 0);
            this.panelBorde.Margin = new System.Windows.Forms.Padding(2);
            this.panelBorde.Name = "panelBorde";
            this.panelBorde.Size = new System.Drawing.Size(1235, 29);
            this.panelBorde.TabIndex = 81;
            this.panelBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmActPpal_MouseDown);
            this.panelBorde.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmActPpal_MouseMove);
            this.panelBorde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmActPpal_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eventick";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(9, 6);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // picMinimizar
            // 
            this.picMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.picMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(1191, 2);
            this.picMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(19, 20);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizar.TabIndex = 2;
            this.picMinimizar.TabStop = false;
            // 
            // picSalir
            // 
            this.picSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSalir.BackColor = System.Drawing.Color.Transparent;
            this.picSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalir.Image = ((System.Drawing.Image)(resources.GetObject("picSalir.Image")));
            this.picSalir.Location = new System.Drawing.Point(1214, 2);
            this.picSalir.Margin = new System.Windows.Forms.Padding(2);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(19, 20);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalir.TabIndex = 0;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNavegacion.BackColor = System.Drawing.Color.Transparent;
            this.panelNavegacion.Controls.Add(this.picUser);
            this.panelNavegacion.Controls.Add(this.picBuscar);
            this.panelNavegacion.Controls.Add(this.txtBuscar);
            this.panelNavegacion.Controls.Add(this.picLogo);
            this.panelNavegacion.Location = new System.Drawing.Point(-34, 75);
            this.panelNavegacion.Margin = new System.Windows.Forms.Padding(2);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(1269, 65);
            this.panelNavegacion.TabIndex = 80;
            // 
            // picUser
            // 
            this.picUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(1195, 8);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(62, 50);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 6;
            this.picUser.TabStop = false;
            this.picUser.Click += new System.EventHandler(this.picUser_Click);
            // 
            // picBuscar
            // 
            this.picBuscar.BackColor = System.Drawing.Color.White;
            this.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuscar.Image = ((System.Drawing.Image)(resources.GetObject("picBuscar.Image")));
            this.picBuscar.Location = new System.Drawing.Point(1058, 17);
            this.picBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(28, 25);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 5;
            this.picBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(338, 15);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(750, 29);
            this.txtBuscar.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(35, 8);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(214, 39);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // lblTituloActividad
            // 
            this.lblTituloActividad.AutoSize = true;
            this.lblTituloActividad.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloActividad.Location = new System.Drawing.Point(88, 201);
            this.lblTituloActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloActividad.Name = "lblTituloActividad";
            this.lblTituloActividad.Size = new System.Drawing.Size(62, 18);
            this.lblTituloActividad.TabIndex = 82;
            this.lblTituloActividad.Text = "TITULO";
            // 
            // txtTituloActividad
            // 
            this.txtTituloActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloActividad.Location = new System.Drawing.Point(91, 221);
            this.txtTituloActividad.Margin = new System.Windows.Forms.Padding(2);
            this.txtTituloActividad.Name = "txtTituloActividad";
            this.txtTituloActividad.Size = new System.Drawing.Size(881, 23);
            this.txtTituloActividad.TabIndex = 83;
            // 
            // txtDescripcionActividad
            // 
            this.txtDescripcionActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionActividad.Location = new System.Drawing.Point(91, 280);
            this.txtDescripcionActividad.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionActividad.Multiline = true;
            this.txtDescripcionActividad.Name = "txtDescripcionActividad";
            this.txtDescripcionActividad.Size = new System.Drawing.Size(881, 214);
            this.txtDescripcionActividad.TabIndex = 85;
            // 
            // LBLDescripcionActividad
            // 
            this.LBLDescripcionActividad.AutoSize = true;
            this.LBLDescripcionActividad.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDescripcionActividad.Location = new System.Drawing.Point(88, 260);
            this.LBLDescripcionActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLDescripcionActividad.Name = "LBLDescripcionActividad";
            this.LBLDescripcionActividad.Size = new System.Drawing.Size(109, 18);
            this.LBLDescripcionActividad.TabIndex = 84;
            this.LBLDescripcionActividad.Text = "DESCRIPCIÓN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDificultad);
            this.panel1.Controls.Add(this.cmbDificultad);
            this.panel1.Controls.Add(this.nupCuentaHoras);
            this.panel1.Controls.Add(this.lblLocalidadAct);
            this.panel1.Controls.Add(this.lblDuracionAct);
            this.panel1.Controls.Add(this.picAñadirImagenActividad);
            this.panel1.Controls.Add(this.chkCircular);
            this.panel1.Controls.Add(this.lblDistancia);
            this.panel1.Controls.Add(this.picDistancia);
            this.panel1.Controls.Add(this.trbDistancia);
            this.panel1.Controls.Add(this.txtLocalidad);
            this.panel1.Location = new System.Drawing.Point(112, 514);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 149);
            this.panel1.TabIndex = 86;
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificultad.Location = new System.Drawing.Point(458, 16);
            this.lblDificultad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(64, 16);
            this.lblDificultad.TabIndex = 112;
            this.lblDificultad.Text = "Dificultad";
            // 
            // cmbDificultad
            // 
            this.cmbDificultad.FormattingEnabled = true;
            this.cmbDificultad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cmbDificultad.Location = new System.Drawing.Point(461, 36);
            this.cmbDificultad.Name = "cmbDificultad";
            this.cmbDificultad.Size = new System.Drawing.Size(121, 21);
            this.cmbDificultad.TabIndex = 111;
            // 
            // nupCuentaHoras
            // 
            this.nupCuentaHoras.BackColor = System.Drawing.Color.White;
            this.nupCuentaHoras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nupCuentaHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCuentaHoras.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nupCuentaHoras.Location = new System.Drawing.Point(313, 35);
            this.nupCuentaHoras.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nupCuentaHoras.Name = "nupCuentaHoras";
            this.nupCuentaHoras.Size = new System.Drawing.Size(56, 22);
            this.nupCuentaHoras.TabIndex = 110;
            this.nupCuentaHoras.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nupCuentaHoras.ValueChanged += new System.EventHandler(this.nupCuentaHoras_ValueChanged);
            // 
            // lblLocalidadAct
            // 
            this.lblLocalidadAct.AutoSize = true;
            this.lblLocalidadAct.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadAct.Location = new System.Drawing.Point(49, 16);
            this.lblLocalidadAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidadAct.Name = "lblLocalidadAct";
            this.lblLocalidadAct.Size = new System.Drawing.Size(63, 16);
            this.lblLocalidadAct.TabIndex = 94;
            this.lblLocalidadAct.Text = "Localidad";
            // 
            // lblDuracionAct
            // 
            this.lblDuracionAct.AutoSize = true;
            this.lblDuracionAct.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracionAct.Location = new System.Drawing.Point(310, 16);
            this.lblDuracionAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuracionAct.Name = "lblDuracionAct";
            this.lblDuracionAct.Size = new System.Drawing.Size(60, 16);
            this.lblDuracionAct.TabIndex = 93;
            this.lblDuracionAct.Text = "Duracion";
            // 
            // picAñadirImagenActividad
            // 
            this.picAñadirImagenActividad.BackColor = System.Drawing.Color.Transparent;
            this.picAñadirImagenActividad.Image = ((System.Drawing.Image)(resources.GetObject("picAñadirImagenActividad.Image")));
            this.picAñadirImagenActividad.Location = new System.Drawing.Point(651, 30);
            this.picAñadirImagenActividad.Name = "picAñadirImagenActividad";
            this.picAñadirImagenActividad.Size = new System.Drawing.Size(103, 90);
            this.picAñadirImagenActividad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAñadirImagenActividad.TabIndex = 27;
            this.picAñadirImagenActividad.TabStop = false;
            // 
            // chkCircular
            // 
            this.chkCircular.AutoSize = true;
            this.chkCircular.Location = new System.Drawing.Point(313, 95);
            this.chkCircular.Name = "chkCircular";
            this.chkCircular.Size = new System.Drawing.Size(109, 17);
            this.chkCircular.TabIndex = 26;
            this.chkCircular.Text = "Recorrido circular";
            this.chkCircular.UseVisualStyleBackColor = true;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(190, 95);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(29, 13);
            this.lblDistancia.TabIndex = 23;
            this.lblDistancia.Text = "x km";
            // 
            // picDistancia
            // 
            this.picDistancia.BackColor = System.Drawing.Color.Transparent;
            this.picDistancia.Image = ((System.Drawing.Image)(resources.GetObject("picDistancia.Image")));
            this.picDistancia.Location = new System.Drawing.Point(52, 78);
            this.picDistancia.Name = "picDistancia";
            this.picDistancia.Size = new System.Drawing.Size(45, 42);
            this.picDistancia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDistancia.TabIndex = 22;
            this.picDistancia.TabStop = false;
            // 
            // trbDistancia
            // 
            this.trbDistancia.Location = new System.Drawing.Point(91, 89);
            this.trbDistancia.Maximum = 42;
            this.trbDistancia.Minimum = 1;
            this.trbDistancia.Name = "trbDistancia";
            this.trbDistancia.Size = new System.Drawing.Size(104, 45);
            this.trbDistancia.TabIndex = 21;
            this.trbDistancia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbDistancia.Value = 1;
            this.trbDistancia.Scroll += new System.EventHandler(this.trbDistancia_Scroll);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(52, 35);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(154, 20);
            this.txtLocalidad.TabIndex = 13;
            // 
            // cbbTipo
            // 
            this.cbbTipo.BackColor = System.Drawing.Color.SteelBlue;
            this.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "SENDERISMO",
            "ANDAR",
            "CORRER",
            "CAMINATA"});
            this.cbbTipo.Location = new System.Drawing.Point(587, 172);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(155, 26);
            this.cbbTipo.TabIndex = 90;
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Controls.Add(this.button7);
            this.panelUser.Controls.Add(this.button2);
            this.panelUser.Location = new System.Drawing.Point(1062, 145);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(161, 65);
            this.panelUser.TabIndex = 92;
            this.panelUser.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 30);
            this.button7.TabIndex = 32;
            this.button7.Text = "Cerrar sesión";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 30);
            this.button2.TabIndex = 27;
            this.button2.Text = "    Perfil";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.btnAñadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAñadir.FlatAppearance.BorderSize = 2;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.Location = new System.Drawing.Point(1003, 626);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(116, 37);
            this.btnAñadir.TabIndex = 91;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // picAPie
            // 
            this.picAPie.BackColor = System.Drawing.Color.Transparent;
            this.picAPie.Image = ((System.Drawing.Image)(resources.GetObject("picAPie.Image")));
            this.picAPie.Location = new System.Drawing.Point(388, 168);
            this.picAPie.Name = "picAPie";
            this.picAPie.Size = new System.Drawing.Size(32, 30);
            this.picAPie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAPie.TabIndex = 89;
            this.picAPie.TabStop = false;
            this.picAPie.Click += new System.EventHandler(this.picAPie_Click);
            // 
            // picEnBici
            // 
            this.picEnBici.BackColor = System.Drawing.Color.Transparent;
            this.picEnBici.Image = ((System.Drawing.Image)(resources.GetObject("picEnBici.Image")));
            this.picEnBici.Location = new System.Drawing.Point(490, 168);
            this.picEnBici.Name = "picEnBici";
            this.picEnBici.Size = new System.Drawing.Size(32, 30);
            this.picEnBici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnBici.TabIndex = 88;
            this.picEnBici.TabStop = false;
            this.picEnBici.Click += new System.EventHandler(this.picEnBici_Click);
            // 
            // picAtras
            // 
            this.picAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAtras.Image = ((System.Drawing.Image)(resources.GetObject("picAtras.Image")));
            this.picAtras.Location = new System.Drawing.Point(10, 145);
            this.picAtras.Name = "picAtras";
            this.picAtras.Size = new System.Drawing.Size(51, 46);
            this.picAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAtras.TabIndex = 79;
            this.picAtras.TabStop = false;
            this.picAtras.Click += new System.EventHandler(this.picAtras_Click);
            // 
            // frmAgregarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 673);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.cbbTipo);
            this.Controls.Add(this.picAPie);
            this.Controls.Add(this.picEnBici);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDescripcionActividad);
            this.Controls.Add(this.LBLDescripcionActividad);
            this.Controls.Add(this.txtTituloActividad);
            this.Controls.Add(this.lblTituloActividad);
            this.Controls.Add(this.picAtras);
            this.Controls.Add(this.panelBorde);
            this.Controls.Add(this.panelNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgregarActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarActividad";
            this.Load += new System.EventHandler(this.frmAgregarActividad_Load);
            this.panelBorde.ResumeLayout(false);
            this.panelBorde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            this.panelNavegacion.ResumeLayout(false);
            this.panelNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCuentaHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAñadirImagenActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDistancia)).EndInit();
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnBici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.Panel panelBorde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTituloActividad;
        private System.Windows.Forms.TextBox txtTituloActividad;
        private System.Windows.Forms.TextBox txtDescripcionActividad;
        private System.Windows.Forms.Label LBLDescripcionActividad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAPie;
        private System.Windows.Forms.PictureBox picEnBici;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.PictureBox picDistancia;
        private System.Windows.Forms.TrackBar trbDistancia;
        private System.Windows.Forms.CheckBox chkCircular;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.PictureBox picAñadirImagenActividad;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblLocalidadAct;
        private System.Windows.Forms.Label lblDuracionAct;
        private System.Windows.Forms.NumericUpDown nupCuentaHoras;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.ComboBox cmbDificultad;
    }
}