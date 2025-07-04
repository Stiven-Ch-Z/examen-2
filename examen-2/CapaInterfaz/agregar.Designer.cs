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
            lbltextoderellenoxd.Click += this.lbltextoderellenoxd_Click;
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
            // 
            // btningresar
            // 
            btningresar.Location = new Point(36, 421);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(94, 29);
            btningresar.TabIndex = 9;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
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
            // agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 472);
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
    }
}