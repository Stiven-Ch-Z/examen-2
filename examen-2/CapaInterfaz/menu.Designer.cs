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
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblwelcome.Location = new Point(123, 24);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(299, 31);
            lblwelcome.TabIndex = 0;
            lblwelcome.Text = "¡Bienvenido a Vital Training!";
            // 
            // lblchoose
            // 
            lblchoose.AutoSize = true;
            lblchoose.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblchoose.Location = new Point(168, 69);
            lblchoose.Name = "lblchoose";
            lblchoose.Size = new Size(215, 25);
            lblchoose.TabIndex = 1;
            lblchoose.Text = "Por Favor Elija una opcion";
            // 
            // btnusuario
            // 
            btnusuario.Location = new Point(158, 160);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(240, 29);
            btnusuario.TabIndex = 2;
            btnusuario.Text = "Ingresar Un Usuario Al Sistema";
            btnusuario.UseVisualStyleBackColor = true;
            // 
            // btnhistorial
            // 
            btnhistorial.Location = new Point(179, 230);
            btnhistorial.Name = "btnhistorial";
            btnhistorial.Size = new Size(204, 29);
            btnhistorial.TabIndex = 3;
            btnhistorial.Text = "Ver Historial De Ingresos";
            btnhistorial.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(220, 302);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(103, 29);
            btnsalir.TabIndex = 4;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 406);
            Controls.Add(btnsalir);
            Controls.Add(btnhistorial);
            Controls.Add(btnusuario);
            Controls.Add(lblchoose);
            Controls.Add(lblwelcome);
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
