namespace examen_2
{
    partial class agregar
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
            components = new System.ComponentModel.Container();
            lbltextoderellenoxd = new Label();
            lblnombre = new Label();
            lblmenbr = new Label();
            lbledad = new Label();
            cbotipomembre = new ComboBox();
            txtnombre = new TextBox();
            txtmembre = new TextBox();
            txtedad = new TextBox();
            btnvolver = new Button();
            btningresar = new Button();
            lbltipomembre = new Label();
            errorProvideragregar = new ErrorProvider(components);
            contextMenuagregar = new ContextMenuStrip(components);
            cambiarElColorDelFondoToolStripMenuItem = new ToolStripMenuItem();
            mostrarTotalDeIngresosToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)errorProvideragregar).BeginInit();
            contextMenuagregar.SuspendLayout();
            SuspendLayout();
            // 
            // lbltextoderellenoxd
            // 
            lbltextoderellenoxd.AutoSize = true;
            lbltextoderellenoxd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltextoderellenoxd.Location = new Point(124, 22);
            lbltextoderellenoxd.Name = "lbltextoderellenoxd";
            lbltextoderellenoxd.Size = new Size(258, 31);
            lbltextoderellenoxd.TabIndex = 0;
            lbltextoderellenoxd.Text = "Registrador de Usuarios";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(73, 105);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(67, 20);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre:";
            // 
            // lblmenbr
            // 
            lblmenbr.AutoSize = true;
            lblmenbr.Location = new Point(24, 178);
            lblmenbr.Name = "lblmenbr";
            lblmenbr.Size = new Size(165, 20);
            lblmenbr.TabIndex = 2;
            lblmenbr.Text = "Numero de membresia:";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(84, 249);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(46, 20);
            lbledad.TabIndex = 3;
            lbledad.Text = "Edad:";
            // 
            // cbotipomembre
            // 
            cbotipomembre.FormattingEnabled = true;
            cbotipomembre.Items.AddRange(new object[] { "Anual", "Mensual", "Trimestral" });
            cbotipomembre.Location = new Point(195, 323);
            cbotipomembre.Name = "cbotipomembre";
            cbotipomembre.Size = new Size(165, 28);
            cbotipomembre.TabIndex = 4;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(195, 102);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(270, 27);
            txtnombre.TabIndex = 5;
            // 
            // txtmembre
            // 
            txtmembre.Location = new Point(195, 178);
            txtmembre.Name = "txtmembre";
            txtmembre.Size = new Size(270, 27);
            txtmembre.TabIndex = 6;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(195, 246);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(87, 27);
            txtedad.TabIndex = 7;
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(393, 421);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(94, 29);
            btnvolver.TabIndex = 8;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // btningresar
            // 
            btningresar.Location = new Point(36, 421);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(94, 29);
            btningresar.TabIndex = 9;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // lbltipomembre
            // 
            lbltipomembre.AutoSize = true;
            lbltipomembre.Location = new Point(36, 326);
            lbltipomembre.Name = "lbltipomembre";
            lbltipomembre.Size = new Size(141, 20);
            lbltipomembre.TabIndex = 10;
            lbltipomembre.Text = "Tipo de membresia:";
            // 
            // errorProvideragregar
            // 
            errorProvideragregar.ContainerControl = this;
            // 
            // contextMenuagregar
            // 
            contextMenuagregar.ImageScalingSize = new Size(20, 20);
            contextMenuagregar.Items.AddRange(new ToolStripItem[] { cambiarElColorDelFondoToolStripMenuItem, mostrarTotalDeIngresosToolStripMenuItem, salirDelSistemaToolStripMenuItem });
            contextMenuagregar.Name = "contextMenuagregar";
            contextMenuagregar.Size = new Size(258, 76);
            // 
            // cambiarElColorDelFondoToolStripMenuItem
            // 
            cambiarElColorDelFondoToolStripMenuItem.Name = "cambiarElColorDelFondoToolStripMenuItem";
            cambiarElColorDelFondoToolStripMenuItem.Size = new Size(257, 24);
            cambiarElColorDelFondoToolStripMenuItem.Text = "Cambiar el color del fondo";
            cambiarElColorDelFondoToolStripMenuItem.Click += cambiarElColorDelFondoToolStripMenuItem_Click;
            // 
            // mostrarTotalDeIngresosToolStripMenuItem
            // 
            mostrarTotalDeIngresosToolStripMenuItem.Name = "mostrarTotalDeIngresosToolStripMenuItem";
            mostrarTotalDeIngresosToolStripMenuItem.Size = new Size(257, 24);
            mostrarTotalDeIngresosToolStripMenuItem.Text = "Mostrar Total de ingresos";
            mostrarTotalDeIngresosToolStripMenuItem.Click += mostrarTotalDeIngresosToolStripMenuItem_Click;
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(257, 24);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 472);
            ContextMenuStrip = contextMenuagregar;
            Controls.Add(lbltipomembre);
            Controls.Add(btningresar);
            Controls.Add(btnvolver);
            Controls.Add(txtedad);
            Controls.Add(txtmembre);
            Controls.Add(txtnombre);
            Controls.Add(cbotipomembre);
            Controls.Add(lbledad);
            Controls.Add(lblmenbr);
            Controls.Add(lblnombre);
            Controls.Add(lbltextoderellenoxd);
            Name = "agregar";
            Text = "Agregar Usuario";
            Load += agregar_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvideragregar).EndInit();
            contextMenuagregar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltextoderellenoxd;
        private Label lblnombre;
        private Label lblmenbr;
        private Label lbledad;
        private ComboBox cbotipomembre;
        private TextBox txtnombre;
        private TextBox txtmembre;
        private TextBox txtedad;
        private Button btnvolver;
        private Button btningresar;
        private Label lbltipomembre;
        private ErrorProvider errorProvideragregar;
        private ContextMenuStrip contextMenuagregar;
        private ToolStripMenuItem cambiarElColorDelFondoToolStripMenuItem;
        private ToolStripMenuItem mostrarTotalDeIngresosToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}