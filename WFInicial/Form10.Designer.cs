namespace WFInicial
{
    partial class Form10
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtResultado = new RichTextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(285, 129);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(272, 164);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            txtNumero.Leave += txtNumero_Leave;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(272, 212);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(111, 167);
            txtResultado.TabIndex = 3;
            txtResultado.Text = "";
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "Form10";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNumero;
        private TextBox txtNumero;
        private RichTextBox txtResultado;
    }
}