namespace WinFormsApps
{
    partial class linqForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtnombre = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(64, 37);
            button1.Name = "button1";
            button1.Size = new Size(179, 23);
            button1.TabIndex = 0;
            button1.Text = "buscar por nombre";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(64, 164);
            button2.Name = "button2";
            button2.Size = new Size(179, 23);
            button2.TabIndex = 1;
            button2.Text = "buscar segun aumento";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(64, 213);
            button3.Name = "button3";
            button3.Size = new Size(187, 23);
            button3.TabIndex = 2;
            button3.Text = "buscar segun orden desc";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(104, 85);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(64, 259);
            button4.Name = "button4";
            button4.Size = new Size(179, 23);
            button4.TabIndex = 5;
            button4.Text = "buscar segun Sueldo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // linqForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(315, 334);
            Controls.Add(button4);
            Controls.Add(txtnombre);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "linqForm";
            Text = "linqForm";
            Load += linqForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtnombre;
        private Button button4;
    }
}