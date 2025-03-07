namespace WFInicial
{
    partial class Form8
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
            lblNumero1 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            lblNumero2 = new Label();
            gpxOperacao = new GroupBox();
            rdbSoma = new RadioButton();
            rdbSubtracao = new RadioButton();
            rdbMutiplicacao = new RadioButton();
            rdbDivisao = new RadioButton();
            rdbPotenciacao = new RadioButton();
            rdbRadiciacao = new RadioButton();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(327, 78);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(63, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Numero 1:";
            
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(308, 96);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(308, 173);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 2;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(327, 138);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(63, 15);
            lblNumero2.TabIndex = 3;
            lblNumero2.Text = "Numero 2:";
            // 
            // gpxOperacao
            // 
            gpxOperacao.Location = new Point(67, 78);
            gpxOperacao.Name = "gpxOperacao";
            gpxOperacao.Size = new Size(200, 187);
            gpxOperacao.TabIndex = 4;
            gpxOperacao.TabStop = false;
            gpxOperacao.Text = "Opereção";
            
            // 
            // rdbSoma
            // 
            rdbSoma.AutoSize = true;
            rdbSoma.Location = new Point(116, 100);
            rdbSoma.Name = "rdbSoma";
            rdbSoma.Size = new Size(55, 19);
            rdbSoma.TabIndex = 5;
            rdbSoma.TabStop = true;
            rdbSoma.Text = "Soma";
            rdbSoma.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Location = new Point(116, 124);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(78, 19);
            rdbSubtracao.TabIndex = 6;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMutiplicacao
            // 
            rdbMutiplicacao.AutoSize = true;
            rdbMutiplicacao.Location = new Point(116, 149);
            rdbMutiplicacao.Name = "rdbMutiplicacao";
            rdbMutiplicacao.Size = new Size(94, 19);
            rdbMutiplicacao.TabIndex = 7;
            rdbMutiplicacao.TabStop = true;
            rdbMutiplicacao.Text = "Mutiplicação";
            rdbMutiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Location = new Point(116, 174);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(63, 19);
            rdbDivisao.TabIndex = 8;
            rdbDivisao.TabStop = true;
            rdbDivisao.Text = "Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbPotenciacao
            // 
            rdbPotenciacao.AutoSize = true;
            rdbPotenciacao.Location = new Point(116, 199);
            rdbPotenciacao.Name = "rdbPotenciacao";
            rdbPotenciacao.Size = new Size(90, 19);
            rdbPotenciacao.TabIndex = 9;
            rdbPotenciacao.TabStop = true;
            rdbPotenciacao.Text = "Potenciação";
            rdbPotenciacao.UseVisualStyleBackColor = true;
            // 
            // rdbRadiciacao
            // 
            rdbRadiciacao.AutoSize = true;
            rdbRadiciacao.Location = new Point(116, 224);
            rdbRadiciacao.Name = "rdbRadiciacao";
            rdbRadiciacao.Size = new Size(82, 19);
            rdbRadiciacao.TabIndex = 10;
            rdbRadiciacao.TabStop = true;
            rdbRadiciacao.Text = "Radiciação";
            rdbRadiciacao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(327, 220);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(rdbRadiciacao);
            Controls.Add(rdbPotenciacao);
            Controls.Add(rdbDivisao);
            Controls.Add(rdbMutiplicacao);
            Controls.Add(rdbSubtracao);
            Controls.Add(rdbSoma);
            Controls.Add(gpxOperacao);
            Controls.Add(lblNumero2);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero1);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblNumero2;
        private GroupBox gpxOperacao;
        private RadioButton rdbSoma;
        private RadioButton rdbSubtracao;
        private RadioButton rdbMutiplicacao;
        private RadioButton rdbDivisao;
        private RadioButton rdbPotenciacao;
        private RadioButton rdbRadiciacao;
        private Button btnCalcular;
    }
}