namespace WFInicial
{
    partial class Form12
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
            txtNumero = new TextBox();
            lblNumero = new Label();
            lblContador = new Label();
            btnCadastrar = new Button();
            lblNumeros = new Label();
            lblPar = new Label();
            lblImpar = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(324, 144);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(250, 147);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero:";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(441, 147);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(13, 15);
            lblContador.TabIndex = 2;
            lblContador.Text = "0";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(335, 173);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // lblNumeros
            // 
            lblNumeros.BorderStyle = BorderStyle.Fixed3D;
            lblNumeros.Location = new Point(250, 222);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(111, 27);
            lblNumeros.TabIndex = 4;
            lblNumeros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPar
            // 
            lblPar.BorderStyle = BorderStyle.Fixed3D;
            lblPar.Location = new Point(250, 263);
            lblPar.Name = "lblPar";
            lblPar.Size = new Size(111, 27);
            lblPar.TabIndex = 7;
            lblPar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImpar
            // 
            lblImpar.BorderStyle = BorderStyle.Fixed3D;
            lblImpar.Location = new Point(250, 302);
            lblImpar.Name = "lblImpar";
            lblImpar.Size = new Size(111, 27);
            lblImpar.TabIndex = 8;
            lblImpar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblImpar);
            Controls.Add(lblPar);
            Controls.Add(lblNumeros);
            Controls.Add(btnCadastrar);
            Controls.Add(lblContador);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label lblNumero;
        private Label lblContador;
        private Button btnCadastrar;
        private Label lblNumeros;
        private Label lblPar;
        private Label lblImpar;
    }
}