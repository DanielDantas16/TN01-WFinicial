﻿namespace WFInicial
{
    partial class FormMenu
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
            btnEx1 = new Button();
            btnEx2 = new Button();
            btnEx3 = new Button();
            btnEx4 = new Button();
            btnex5 = new Button();
            btnex6 = new Button();
            btnex7 = new Button();
            btn8 = new Button();
            SuspendLayout();
            // 
            // btnEx1
            // 
            btnEx1.Location = new Point(231, 94);
            btnEx1.Name = "btnEx1";
            btnEx1.Size = new Size(75, 23);
            btnEx1.TabIndex = 0;
            btnEx1.Text = "Exercicio 1";
            btnEx1.UseVisualStyleBackColor = true;
            btnEx1.Click += btnEx1_Click;
            // 
            // btnEx2
            // 
            btnEx2.Location = new Point(312, 94);
            btnEx2.Name = "btnEx2";
            btnEx2.Size = new Size(75, 23);
            btnEx2.TabIndex = 1;
            btnEx2.Text = "Exercicio 2";
            btnEx2.UseVisualStyleBackColor = true;
            btnEx2.Click += button2_Click;
            // 
            // btnEx3
            // 
            btnEx3.Location = new Point(393, 94);
            btnEx3.Name = "btnEx3";
            btnEx3.Size = new Size(75, 23);
            btnEx3.TabIndex = 2;
            btnEx3.Text = "Exercicio 3";
            btnEx3.UseVisualStyleBackColor = true;
            btnEx3.Click += btnEx3_Click;
            // 
            // btnEx4
            // 
            btnEx4.Location = new Point(474, 94);
            btnEx4.Name = "btnEx4";
            btnEx4.Size = new Size(75, 23);
            btnEx4.TabIndex = 3;
            btnEx4.Text = "Exercicio 4";
            btnEx4.UseVisualStyleBackColor = true;
            btnEx4.Click += btnEx4_Click;
            // 
            // btnex5
            // 
            btnex5.Location = new Point(231, 123);
            btnex5.Name = "btnex5";
            btnex5.Size = new Size(75, 23);
            btnex5.TabIndex = 4;
            btnex5.Text = "Exercicio 5";
            btnex5.UseVisualStyleBackColor = true;
            btnex5.Click += btnex5_Click;
            // 
            // btnex6
            // 
            btnex6.Location = new Point(312, 123);
            btnex6.Name = "btnex6";
            btnex6.Size = new Size(75, 23);
            btnex6.TabIndex = 5;
            btnex6.Text = "Exercicio 6";
            btnex6.UseVisualStyleBackColor = true;
            btnex6.Click += btnex6_Click;
            // 
            // btnex7
            // 
            btnex7.Location = new Point(393, 123);
            btnex7.Name = "btnex7";
            btnex7.Size = new Size(75, 23);
            btnex7.TabIndex = 6;
            btnex7.Text = "Exercicio 7";
            btnex7.UseVisualStyleBackColor = true;
            btnex7.Click += btnex7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(474, 123);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 23);
            btn8.TabIndex = 7;
            btn8.Text = "Exercicio 8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn8);
            Controls.Add(btnex7);
            Controls.Add(btnex6);
            Controls.Add(btnex5);
            Controls.Add(btnEx4);
            Controls.Add(btnEx3);
            Controls.Add(btnEx2);
            Controls.Add(btnEx1);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEx1;
        private Button btnEx2;
        private Button btnEx3;
        private Button btnEx4;
        private Button btnex5;
        private Button btnex6;
        private Button btnex7;
        private Button btn8;
    }
}