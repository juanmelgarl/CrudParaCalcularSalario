namespace WinFormsApps
{
    partial class ClienteForm
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
            panel1 = new Panel();
            btnconsultas = new Button();
            btnborrar = new Button();
            btnactualizar = new Button();
            dgv = new DataGridView();
            BTNEXPORTAR = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BTNEXPORTAR);
            panel1.Controls.Add(btnconsultas);
            panel1.Controls.Add(btnborrar);
            panel1.Controls.Add(btnactualizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // btnconsultas
            // 
            btnconsultas.Location = new Point(276, 47);
            btnconsultas.Name = "btnconsultas";
            btnconsultas.Size = new Size(129, 23);
            btnconsultas.TabIndex = 5;
            btnconsultas.Text = "CONSULTAS LINQ";
            btnconsultas.UseVisualStyleBackColor = true;
            btnconsultas.Click += btnconsultas_Click;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(164, 47);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(75, 23);
            btnborrar.TabIndex = 2;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(46, 47);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(75, 23);
            btnactualizar.TabIndex = 3;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 100);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.Size = new Size(800, 350);
            dgv.TabIndex = 0;
            // 
            // BTNEXPORTAR
            // 
            BTNEXPORTAR.Location = new Point(421, 47);
            BTNEXPORTAR.Name = "BTNEXPORTAR";
            BTNEXPORTAR.Size = new Size(129, 23);
            BTNEXPORTAR.TabIndex = 6;
            BTNEXPORTAR.Text = "EXPORTAR A JSON";
            BTNEXPORTAR.UseVisualStyleBackColor = true;
            BTNEXPORTAR.Click += BTNEXPORTAR_Click;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv);
            Controls.Add(panel1);
            Name = "ClienteForm";
            Text = "ClienteForm";
            Load += ClienteForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnborrar;
        private Button btnactualizar;
        private DataGridView dgv;
        private Button btnconsultas;
        private Button BTNEXPORTAR;
    }
}