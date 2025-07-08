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
            lbltextoderellenoxd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbltextoderellenoxd.AutoSize = true;
            lbltextoderellenoxd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltextoderellenoxd.Location = new Point(116, 16);
            lbltextoderellenoxd.Name = "lbltextoderellenoxd";
            lbltextoderellenoxd.Size = new Size(212, 25);
            lbltextoderellenoxd.TabIndex = 0;
            lbltextoderellenoxd.Text = "Registrador de Usuarios";
            // 
            // lblnombre
            // 
            lblnombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(72, 79);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(54, 15);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre:";
            // 
            // lblmenbr
            // 
            lblmenbr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblmenbr.AutoSize = true;
            lblmenbr.Location = new Point(29, 134);
            lblmenbr.Name = "lblmenbr";
            lblmenbr.Size = new Size(132, 15);
            lblmenbr.TabIndex = 2;
            lblmenbr.Text = "Numero de membresia:";
            // 
            // lbledad
            // 
            lbledad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbledad.AutoSize = true;
            lbledad.Location = new Point(82, 187);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(36, 15);
            lbledad.TabIndex = 3;
            lbledad.Text = "Edad:";
            // 
            // cbotipomembre
            // 
            cbotipomembre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbotipomembre.FormattingEnabled = true;
            cbotipomembre.Items.AddRange(new object[] { "Anual", "Mensual", "Trimestral" });
            cbotipomembre.Location = new Point(179, 242);
            cbotipomembre.Margin = new Padding(3, 2, 3, 2);
            cbotipomembre.Name = "cbotipomembre";
            cbotipomembre.Size = new Size(127, 23);
            cbotipomembre.TabIndex = 4;
            // 
            // txtnombre
            // 
            txtnombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtnombre.Location = new Point(179, 76);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(219, 23);
            txtnombre.TabIndex = 5;
            // 
            // txtmembre
            // 
            txtmembre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtmembre.Location = new Point(179, 134);
            txtmembre.Margin = new Padding(3, 2, 3, 2);
            txtmembre.Name = "txtmembre";
            txtmembre.Size = new Size(219, 23);
            txtmembre.TabIndex = 6;
            // 
            // txtedad
            // 
            txtedad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtedad.Location = new Point(179, 184);
            txtedad.Margin = new Padding(3, 2, 3, 2);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(59, 23);
            txtedad.TabIndex = 7;
            // 
            // btnvolver
            // 
            btnvolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnvolver.Location = new Point(352, 316);
            btnvolver.Margin = new Padding(3, 2, 3, 2);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(64, 22);
            btnvolver.TabIndex = 8;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // btningresar
            // 
            btningresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btningresar.Location = new Point(40, 316);
            btningresar.Margin = new Padding(3, 2, 3, 2);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(64, 22);
            btningresar.TabIndex = 9;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // lbltipomembre
            // 
            lbltipomembre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbltipomembre.AutoSize = true;
            lbltipomembre.Location = new Point(40, 244);
            lbltipomembre.Name = "lbltipomembre";
            lbltipomembre.Size = new Size(112, 15);
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
            contextMenuagregar.Size = new Size(216, 70);
            // 
            // cambiarElColorDelFondoToolStripMenuItem
            // 
            cambiarElColorDelFondoToolStripMenuItem.Name = "cambiarElColorDelFondoToolStripMenuItem";
            cambiarElColorDelFondoToolStripMenuItem.Size = new Size(215, 22);
            cambiarElColorDelFondoToolStripMenuItem.Text = "Cambiar el color del fondo";
            cambiarElColorDelFondoToolStripMenuItem.Click += cambiarElColorDelFondoToolStripMenuItem_Click;
            // 
            // mostrarTotalDeIngresosToolStripMenuItem
            // 
            mostrarTotalDeIngresosToolStripMenuItem.Name = "mostrarTotalDeIngresosToolStripMenuItem";
            mostrarTotalDeIngresosToolStripMenuItem.Size = new Size(215, 22);
            mostrarTotalDeIngresosToolStripMenuItem.Text = "Mostrar Total de ingresos";
            mostrarTotalDeIngresosToolStripMenuItem.Click += mostrarTotalDeIngresosToolStripMenuItem_Click;
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(215, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 354);
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
            Margin = new Padding(3, 2, 3, 2);
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