namespace atividade01.View
{
    partial class TelaPrincipal
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
            lbl_Valor1 = new Label();
            lbl_Valor2 = new Label();
            label3 = new Label();
            lbl_Display = new Label();
            tbx_Valor1 = new TextBox();
            tbx_Valor2 = new TextBox();
            Somar = new Button();
            SuspendLayout();
            // 
            // lbl_Valor1
            // 
            lbl_Valor1.AutoSize = true;
            lbl_Valor1.Location = new Point(51, 130);
            lbl_Valor1.Name = "lbl_Valor1";
            lbl_Valor1.Size = new Size(39, 15);
            lbl_Valor1.TabIndex = 0;
            lbl_Valor1.Text = "Valor1";
            lbl_Valor1.Visible = false;
            // 
            // lbl_Valor2
            // 
            lbl_Valor2.AutoSize = true;
            lbl_Valor2.Location = new Point(51, 167);
            lbl_Valor2.Name = "lbl_Valor2";
            lbl_Valor2.Size = new Size(39, 15);
            lbl_Valor2.TabIndex = 1;
            lbl_Valor2.Text = "Valor2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(165, 9);
            label3.Name = "label3";
            label3.Size = new Size(82, 30);
            label3.TabIndex = 2;
            label3.Text = "Soma";
            // 
            // lbl_Display
            // 
            lbl_Display.BackColor = Color.FromArgb(128, 255, 255);
            lbl_Display.Location = new Point(21, 220);
            lbl_Display.Name = "lbl_Display";
            lbl_Display.Size = new Size(338, 54);
            lbl_Display.TabIndex = 3;
            lbl_Display.Click += label4_Click;
            // 
            // tbx_Valor1
            // 
            tbx_Valor1.Location = new Point(96, 122);
            tbx_Valor1.Name = "tbx_Valor1";
            tbx_Valor1.Size = new Size(100, 23);
            tbx_Valor1.TabIndex = 4;
            // 
            // tbx_Valor2
            // 
            tbx_Valor2.Location = new Point(96, 167);
            tbx_Valor2.Name = "tbx_Valor2";
            tbx_Valor2.Size = new Size(100, 23);
            tbx_Valor2.TabIndex = 5;
            // 
            // Somar
            // 
            Somar.Location = new Point(196, 301);
            Somar.Name = "Somar";
            Somar.Size = new Size(133, 40);
            Somar.TabIndex = 6;
            Somar.Text = "Somar";
            Somar.UseVisualStyleBackColor = true;
            Somar.Click += Somar_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Somar);
            Controls.Add(tbx_Valor2);
            Controls.Add(tbx_Valor1);
            Controls.Add(lbl_Display);
            Controls.Add(label3);
            Controls.Add(lbl_Valor2);
            Controls.Add(lbl_Valor1);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Valor1;
        private Label lbl_Valor2;
        private Label label3;
        private Label lbl_Display;
        private TextBox tbx_Valor1;
        private TextBox tbx_Valor2;
        private Button Somar;
    }
}