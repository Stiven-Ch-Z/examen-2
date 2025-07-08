namespace examen_2
{
    partial class menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblwelcome = new Label();
            lblchoose = new Label();
            btnusuario = new Button();
            btnhistorial = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // lblwelcome
            // 
            lblwelcome.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblwelcome.Location = new Point(196, 18);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(247, 25);
            lblwelcome.TabIndex = 0;
            lblwelcome.Text = "¡Bienvenido a Vital Training!";
            // 
            // lblchoose
            // 
            lblchoose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblchoose.AutoSize = true;
            lblchoose.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblchoose.Location = new Point(235, 52);
            lblchoose.Name = "lblchoose";
            lblchoose.Size = new Size(179, 20);
            lblchoose.TabIndex = 1;
            lblchoose.Text = "Por Favor Elija una opcion";
            // 
            // btnusuario
            // 
            btnusuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnusuario.Location = new Point(226, 120);
            btnusuario.Margin = new Padding(3, 2, 3, 2);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(210, 22);
            btnusuario.TabIndex = 2;
            btnusuario.Text = "Ingresar Un Usuario Al Sistema";
            btnusuario.UseVisualStyleBackColor = true;
            btnusuario.Click += btnusuario_Click;
            // 
            // btnhistorial
            // 
            btnhistorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnhistorial.Location = new Point(245, 172);
            btnhistorial.Margin = new Padding(3, 2, 3, 2);
            btnhistorial.Name = "btnhistorial";
            btnhistorial.Size = new Size(178, 22);
            btnhistorial.TabIndex = 3;
            btnhistorial.Text = "Ver Historial De Ingresos";
            btnhistorial.UseVisualStyleBackColor = true;
            btnhistorial.Click += btnhistorial_Click;
            // 
            // btnsalir
            // 
            btnsalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnsalir.Location = new Point(280, 226);
            btnsalir.Margin = new Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(90, 22);
            btnsalir.TabIndex = 4;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 304);
            Controls.Add(btnsalir);
            Controls.Add(btnhistorial);
            Controls.Add(btnusuario);
            Controls.Add(lblchoose);
            Controls.Add(lblwelcome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwelcome;
        private Label lblchoose;
        private Button btnusuario;
        private Button btnhistorial;
        private Button btnsalir;
    }
}
