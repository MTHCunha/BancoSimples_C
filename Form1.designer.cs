namespace _10
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
            this.btnSaque = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.NumericUpDown();
            this.txtvalor = new System.Windows.Forms.NumericUpDown();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnops = new System.Windows.Forms.Button();
            this.btnDepósito = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaque
            // 
            this.btnSaque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaque.Location = new System.Drawing.Point(210, 111);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(125, 40);
            this.btnSaque.TabIndex = 2;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = false;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.DecimalPlaces = 2;
            this.txtSaldo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtSaldo.Location = new System.Drawing.Point(497, 37);
            this.txtSaldo.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(101, 20);
            this.txtSaldo.TabIndex = 5;
            // 
            // txtvalor
            // 
            this.txtvalor.DecimalPlaces = 2;
            this.txtvalor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtvalor.Location = new System.Drawing.Point(212, 75);
            this.txtvalor.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(123, 20);
            this.txtvalor.TabIndex = 6;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(69, 37);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(112, 20);
            this.txtAgencia.TabIndex = 7;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(197, 37);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(93, 20);
            this.txtConta.TabIndex = 8;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(315, 37);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(154, 20);
            this.txtTitular.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Agência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Titular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Saldo";
            // 
            // btnops
            // 
            this.btnops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnops.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnops.Location = new System.Drawing.Point(69, 381);
            this.btnops.Name = "btnops";
            this.btnops.Size = new System.Drawing.Size(529, 28);
            this.btnops.TabIndex = 16;
            this.btnops.Text = "HISTÓRICO";
            this.btnops.UseVisualStyleBackColor = false;
            this.btnops.Click += new System.EventHandler(this.btnops_Click);
            // 
            // btnDepósito
            // 
            this.btnDepósito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDepósito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepósito.Location = new System.Drawing.Point(69, 111);
            this.btnDepósito.Name = "btnDepósito";
            this.btnDepósito.Size = new System.Drawing.Size(125, 40);
            this.btnDepósito.TabIndex = 17;
            this.btnDepósito.Text = "Depósito";
            this.btnDepósito.UseVisualStyleBackColor = false;
            this.btnDepósito.Click += new System.EventHandler(this.btnDepósito_Click);
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(69, 166);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(529, 209);
            this.dgv1.TabIndex = 18;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.Yellow;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(357, 105);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(241, 20);
            this.btnBusca.TabIndex = 20;
            this.btnBusca.Text = "BUSCAR";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(357, 75);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(241, 20);
            this.txtBusca.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor da operação";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(357, 131);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(241, 20);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "EXCLUIR CONTA";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 443);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnDepósito);
            this.Controls.Add(this.btnops);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.btnSaque);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.NumericUpDown txtSaldo;
        private System.Windows.Forms.NumericUpDown txtvalor;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnops;
        private System.Windows.Forms.Button btnDepósito;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluir;
    }
}

