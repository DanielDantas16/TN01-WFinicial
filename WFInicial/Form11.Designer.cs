namespace WFInicial
{
    partial class Form11
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
            lblSalarioBruto = new Label();
            txtSalarioBruto = new TextBox();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblSalarioBruto
            // 
            lblSalarioBruto.AutoSize = true;
            lblSalarioBruto.Location = new Point(170, 40);
            lblSalarioBruto.Name = "lblSalarioBruto";
            lblSalarioBruto.Size = new Size(77, 15);
            lblSalarioBruto.TabIndex = 0;
            lblSalarioBruto.Text = "Salario Bruto:";
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.Location = new Point(157, 68);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.Size = new Size(100, 23);
            txtSalarioBruto.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(170, 322);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(157, 126);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 172);
            txtResultado.TabIndex = 3;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtSalarioBruto);
            Controls.Add(lblSalarioBruto);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalarioBruto;
        private TextBox txtSalarioBruto;
        private Button btnCalcular;
        private TextBox txtResultado;
    }
}