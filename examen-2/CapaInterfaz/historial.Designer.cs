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
            lbltextogrande.AutoSize = true;
            lbltextogrande.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltextogrande.Location = new Point(217, 23);
            lbltextogrande.Name = "lbltextogrande";
            lbltextogrande.Size = new Size(258, 31);
            lbltextogrande.TabIndex = 0;
            lbltextogrande.Text = "Visualizador de historial";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(576, 381);
            dataGridView1.TabIndex = 1;
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(601, 501);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(94, 29);
            btnvolver.TabIndex = 2;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(501, 501);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(94, 29);
            btnactualizar.TabIndex = 3;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(29, 505);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(138, 20);
            lbltotal.TabIndex = 4;
            lbltotal.Text = "Total de Usuarios: 0";
            // 
            // historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 546);
            Controls.Add(lbltotal);
            Controls.Add(btnactualizar);
            Controls.Add(btnvolver);
            Controls.Add(dataGridView1);
            Controls.Add(lbltextogrande);
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