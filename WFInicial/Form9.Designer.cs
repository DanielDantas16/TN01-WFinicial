namespace WFInicial
{
    partial class Form9
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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            lblUsuario = new Label();
            lblSenha = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(290, 244);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(290, 286);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(299, 330);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(237, 247);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(245, 289);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 388);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Name = "Form9";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label lblUsuario;
        private Label lblSenha;
    }
}