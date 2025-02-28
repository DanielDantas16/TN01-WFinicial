namespace WFInicial
{
    partial class Form5
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
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            lblNum2 = new Label();
            lblNum1 = new Label();
            btnmaiorMenor = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(385, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 225);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 17;
            label1.Text = "Numero 3:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(385, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(316, 196);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(63, 15);
            lblNum2.TabIndex = 15;
            lblNum2.Text = "Numero 2:";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(316, 148);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(63, 15);
            lblNum1.TabIndex = 14;
            lblNum1.Text = "Numero 1:";
            // 
            // btnmaiorMenor
            // 
            btnmaiorMenor.Location = new Point(385, 289);
            btnmaiorMenor.Name = "btnmaiorMenor";
            btnmaiorMenor.Size = new Size(100, 42);
            btnmaiorMenor.TabIndex = 13;
            btnmaiorMenor.Text = "Mostrar Maior e Menor";
            btnmaiorMenor.UseVisualStyleBackColor = true;
            btnmaiorMenor.Click += btnmaiorMenor_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(btnmaiorMenor);
            Controls.Add(textBox1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private Label lblNum2;
        private Label lblNum1;
        private Button btnmaiorMenor;
        private TextBox textBox1;
    }
}