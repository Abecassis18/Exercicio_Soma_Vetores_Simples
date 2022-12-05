namespace Exercicio_Soma_Vetores_Simples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpVetor1 = new System.Windows.Forms.GroupBox();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblPosicao1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblPosicao2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnApresentar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lstVetor1 = new System.Windows.Forms.ListBox();
            this.lstVetor2 = new System.Windows.Forms.ListBox();
            this.lstSoma = new System.Windows.Forms.ListBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpVetor1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVetor1
            // 
            this.grpVetor1.Controls.Add(this.btnInserir1);
            this.grpVetor1.Controls.Add(this.txtValor1);
            this.grpVetor1.Controls.Add(this.lblPosicao1);
            this.grpVetor1.Controls.Add(this.label2);
            this.grpVetor1.Controls.Add(this.label1);
            this.grpVetor1.Location = new System.Drawing.Point(28, 13);
            this.grpVetor1.Name = "grpVetor1";
            this.grpVetor1.Size = new System.Drawing.Size(200, 100);
            this.grpVetor1.TabIndex = 0;
            this.grpVetor1.TabStop = false;
            this.grpVetor1.Text = "Vetor 1";
            // 
            // btnInserir1
            // 
            this.btnInserir1.Location = new System.Drawing.Point(119, 30);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(75, 46);
            this.btnInserir1.TabIndex = 4;
            this.btnInserir1.Text = "Inserir";
            this.btnInserir1.UseVisualStyleBackColor = true;
            this.btnInserir1.Click += new System.EventHandler(this.btnInserir1_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(58, 56);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(50, 20);
            this.txtValor1.TabIndex = 3;
            // 
            // lblPosicao1
            // 
            this.lblPosicao1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPosicao1.Location = new System.Drawing.Point(59, 25);
            this.lblPosicao1.Name = "lblPosicao1";
            this.lblPosicao1.Size = new System.Drawing.Size(49, 23);
            this.lblPosicao1.TabIndex = 2;
            this.lblPosicao1.Text = "label3";
            this.lblPosicao1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posição";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInserir2);
            this.groupBox2.Controls.Add(this.txtValor2);
            this.groupBox2.Controls.Add(this.lblPosicao2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(254, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vetor 2";
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(119, 30);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(75, 46);
            this.btnInserir2.TabIndex = 4;
            this.btnInserir2.Text = "Inserir";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(58, 56);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(50, 20);
            this.txtValor2.TabIndex = 3;
            // 
            // lblPosicao2
            // 
            this.lblPosicao2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPosicao2.Location = new System.Drawing.Point(58, 25);
            this.lblPosicao2.Name = "lblPosicao2";
            this.lblPosicao2.Size = new System.Drawing.Size(50, 23);
            this.lblPosicao2.TabIndex = 2;
            this.lblPosicao2.Text = "label4";
            this.lblPosicao2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Posição";
            // 
            // btnApresentar
            // 
            this.btnApresentar.Location = new System.Drawing.Point(68, 121);
            this.btnApresentar.Name = "btnApresentar";
            this.btnApresentar.Size = new System.Drawing.Size(114, 29);
            this.btnApresentar.TabIndex = 5;
            this.btnApresentar.Text = "Apresentar Valores";
            this.btnApresentar.UseVisualStyleBackColor = true;
            this.btnApresentar.Click += new System.EventHandler(this.btnApresentar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(294, 119);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(106, 29);
            this.btnSomar.TabIndex = 6;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lstVetor1
            // 
            this.lstVetor1.FormattingEnabled = true;
            this.lstVetor1.Location = new System.Drawing.Point(68, 156);
            this.lstVetor1.Name = "lstVetor1";
            this.lstVetor1.Size = new System.Drawing.Size(54, 134);
            this.lstVetor1.TabIndex = 7;
            // 
            // lstVetor2
            // 
            this.lstVetor2.FormattingEnabled = true;
            this.lstVetor2.Location = new System.Drawing.Point(128, 156);
            this.lstVetor2.Name = "lstVetor2";
            this.lstVetor2.Size = new System.Drawing.Size(54, 134);
            this.lstVetor2.TabIndex = 8;
            // 
            // lstSoma
            // 
            this.lstSoma.FormattingEnabled = true;
            this.lstSoma.Location = new System.Drawing.Point(294, 154);
            this.lstSoma.Name = "lstSoma";
            this.lstSoma.Size = new System.Drawing.Size(106, 134);
            this.lstSoma.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(408, 259);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 34);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnInserir1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 305);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lstSoma);
            this.Controls.Add(this.lstVetor2);
            this.Controls.Add(this.lstVetor1);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnApresentar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpVetor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Soma de Vetores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpVetor1.ResumeLayout(false);
            this.grpVetor1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVetor1;
        private System.Windows.Forms.Button btnInserir1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblPosicao1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInserir2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblPosicao2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApresentar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.ListBox lstVetor1;
        private System.Windows.Forms.ListBox lstVetor2;
        private System.Windows.Forms.ListBox lstSoma;
        private System.Windows.Forms.Button btnSair;
    }
}

