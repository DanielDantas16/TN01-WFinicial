namespace WFinicial
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
            lblNota1 = new Label();
            btnCalcularMedia = new Button();
            txtNota1 = new TextBox();
            label2 = new Label();
            txtNota2 = new TextBox();
            
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(231, 137);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(45, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1:";
            // 
            // btnCalcularMedia
            // 
            btnCalcularMedia.Location = new Point(212, 228);
            btnCalcularMedia.Name = "btnCalcularMedia";
            btnCalcularMedia.Size = new Size(100, 23);
            btnCalcularMedia.TabIndex = 1;
            btnCalcularMedia.Text = "Calcular Média";
            btnCalcularMedia.UseVisualStyleBackColor = true;
            btnCalcularMedia.Click += btnCalcularMedia_Click;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(212, 155);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 181);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Nota 2:";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(212, 199);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNota2);
            Controls.Add(label2);
            Controls.Add(txtNota1);
            Controls.Add(btnCalcularMedia);
            Controls.Add(lblNota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Button btnCalcularMedia;
        private TextBox txtNota1;
        private Label label2;
        private TextBox txtNota2;
    }
}
