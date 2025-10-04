namespace WinFormsApps
{
    partial class LOGIN
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
            label1 = new Label();
            btnaceptar = new Button();
            txtcontra = new TextBox();
            txtnombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 82);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION";
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(173, 290);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(75, 23);
            btnaceptar.TabIndex = 1;
            btnaceptar.Text = "iniciar ";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(158, 220);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(100, 23);
            txtcontra.TabIndex = 2;
            txtcontra.TextChanged += txtcontra_TextChanged;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(158, 146);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 3;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 116);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 190);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(432, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Controls.Add(txtcontra);
            Controls.Add(btnaceptar);
            Controls.Add(label1);
            Name = "LOGIN";
            Text = "LOGIN";
            Load += LOGIN_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnaceptar;
        private TextBox txtcontra;
        private TextBox txtnombre;
        private Label label2;
        private Label label3;
    }
}