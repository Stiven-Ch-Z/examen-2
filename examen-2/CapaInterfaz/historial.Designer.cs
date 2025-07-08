namespace examen_2
{
    partial class historial
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
            lbltextogrande = new Label();
            dataGridView1 = new DataGridView();
            btnvolver = new Button();
            btnactualizar = new Button();
            lbltotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbltextogrande
            // 
            lbltextogrande.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbltextogrande.AutoSize = true;
            lbltextogrande.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltextogrande.Location = new Point(266, 17);
            lbltextogrande.Name = "lbltextogrande";
            lbltextogrande.Size = new Size(215, 25);
            lbltextogrande.TabIndex = 0;
            lbltextogrande.Text = "Visualizador de historial";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(137, 68);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(504, 286);
            dataGridView1.TabIndex = 1;
            // 
            // btnvolver
            // 
            btnvolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnvolver.Location = new Point(602, 376);
            btnvolver.Margin = new Padding(3, 2, 3, 2);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(82, 22);
            btnvolver.TabIndex = 2;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnactualizar.Location = new Point(514, 376);
            btnactualizar.Margin = new Padding(3, 2, 3, 2);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(82, 22);
            btnactualizar.TabIndex = 3;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // lbltotal
            // 
            lbltotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(101, 379);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(109, 15);
            lbltotal.TabIndex = 4;
            lbltotal.Text = "Total de Usuarios: 0";
            // 
            // historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 410);
            Controls.Add(lbltotal);
            Controls.Add(btnactualizar);
            Controls.Add(btnvolver);
            Controls.Add(dataGridView1);
            Controls.Add(lbltextogrande);
            Margin = new Padding(3, 2, 3, 2);
            Name = "historial";
            Text = "historial";
            Load += historial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltextogrande;
        private DataGridView dataGridView1;
        private Button btnvolver;
        private Button btnactualizar;
        private Label lbltotal;
    }
}