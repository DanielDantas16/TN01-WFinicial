namespace WFInicial
{
    partial class Form7
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
            btnCalcular = new Button();
            txtCaixa2 = new TextBox();
            txtCaixa1 = new TextBox();
            lblProduto = new Label();
            lblValor = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(359, 218);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCaixa2
            // 
            txtCaixa2.Location = new Point(348, 189);
            txtCaixa2.Name = "txtCaixa2";
            txtCaixa2.Size = new Size(100, 23);
            txtCaixa2.TabIndex = 1;
            // 
            // txtCaixa1
            // 
            txtCaixa1.Location = new Point(348, 150);
            txtCaixa1.Name = "txtCaixa1";
            txtCaixa1.Size = new Size(100, 23);
            txtCaixa1.TabIndex = 2;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(281, 150);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 3;
            lblProduto.Text = "Produto";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(281, 189);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValor);
            Controls.Add(lblProduto);
            Controls.Add(txtCaixa1);
            Controls.Add(txtCaixa2);
            Controls.Add(btnCalcular);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtCaixa2;
        private TextBox txtCaixa1;
        private Label lblProduto;
        private Label lblValor;
    }
}