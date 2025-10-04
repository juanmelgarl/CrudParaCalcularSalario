namespace WinFormsApps
{
    partial class Form1
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
            button1 = new Button();
            txtsueldo = new TextBox();
            tctnombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtaumento = new TextBox();
            txtresultado = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(335, 360);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtsueldo
            // 
            txtsueldo.Location = new Point(149, 189);
            txtsueldo.Name = "txtsueldo";
            txtsueldo.Size = new Size(100, 23);
            txtsueldo.TabIndex = 1;
            txtsueldo.TextChanged += txtsueldo_TextChanged;
            // 
            // tctnombre
            // 
            tctnombre.Location = new Point(149, 99);
            tctnombre.Name = "tctnombre";
            tctnombre.Size = new Size(100, 23);
            tctnombre.TabIndex = 2;
            tctnombre.TextChanged += tctnombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 156);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Sueldo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 228);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Aumento";
            // 
            // txtaumento
            // 
            txtaumento.Location = new Point(149, 259);
            txtaumento.Name = "txtaumento";
            txtaumento.Size = new Size(100, 23);
            txtaumento.TabIndex = 4;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(323, 297);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(100, 23);
            txtresultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(592, 450);
            Controls.Add(txtresultado);
            Controls.Add(label3);
            Controls.Add(txtaumento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tctnombre);
            Controls.Add(txtsueldo);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtsueldo;
        private TextBox tctnombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtaumento;
        private TextBox txtresultado;
    }
}
