namespace WFInicial
{
    partial class Form6
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
            txtnome = new TextBox();
            txtValorDaHora = new TextBox();
            txtQtdDeHoras = new TextBox();
            lblnome = new Label();
            lblValorDaHora = new Label();
            lblQtdDeHoras = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(311, 265);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(230, 128);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 1;
            // 
            // txtValorDaHora
            // 
            txtValorDaHora.Location = new Point(248, 161);
            txtValorDaHora.Name = "txtValorDaHora";
            txtValorDaHora.Size = new Size(100, 23);
            txtValorDaHora.TabIndex = 2;
            // 
            // txtQtdDeHoras
            // 
            txtQtdDeHoras.Location = new Point(286, 210);
            txtQtdDeHoras.Name = "txtQtdDeHoras";
            txtQtdDeHoras.Size = new Size(100, 23);
            txtQtdDeHoras.TabIndex = 3;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(161, 128);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(43, 15);
            lblnome.TabIndex = 4;
            lblnome.Text = "Nome:";
            // 
            // lblValorDaHora
            // 
            lblValorDaHora.AutoSize = true;
            lblValorDaHora.Location = new Point(161, 164);
            lblValorDaHora.Name = "lblValorDaHora";
            lblValorDaHora.Size = new Size(81, 15);
            lblValorDaHora.TabIndex = 5;
            lblValorDaHora.Text = "Valor da Hora:";
            // 
            // lblQtdDeHoras
            // 
            lblQtdDeHoras.AutoSize = true;
            lblQtdDeHoras.Location = new Point(161, 213);
            lblQtdDeHoras.Name = "lblQtdDeHoras";
            lblQtdDeHoras.Size = new Size(119, 15);
            lblQtdDeHoras.TabIndex = 6;
            lblQtdDeHoras.Text = "Quantidade de Horas";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblQtdDeHoras);
            Controls.Add(lblValorDaHora);
            Controls.Add(lblnome);
            Controls.Add(txtQtdDeHoras);
            Controls.Add(txtValorDaHora);
            Controls.Add(txtnome);
            Controls.Add(btnCalcular);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtnome;
        private TextBox txtValorDaHora;
        private TextBox txtQtdDeHoras;
        private Label lblnome;
        private Label lblValorDaHora;
        private Label lblQtdDeHoras;
    }
}