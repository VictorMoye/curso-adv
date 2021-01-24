namespace ADV_18_DATAGRIDVIEW
{
    partial class frmDataGridView
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
            this.grpbProduto = new System.Windows.Forms.GroupBox();
            this.nupdQtde = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.TextBox();
            this.grpbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbProduto
            // 
            this.grpbProduto.Controls.Add(this.nupdQtde);
            this.grpbProduto.Controls.Add(this.btnAdicionar);
            this.grpbProduto.Controls.Add(this.label4);
            this.grpbProduto.Controls.Add(this.txtPreco);
            this.grpbProduto.Controls.Add(this.label3);
            this.grpbProduto.Controls.Add(this.txtDescricao);
            this.grpbProduto.Controls.Add(this.label2);
            this.grpbProduto.Controls.Add(this.txtCodigo);
            this.grpbProduto.Controls.Add(this.label1);
            this.grpbProduto.Location = new System.Drawing.Point(13, 13);
            this.grpbProduto.Name = "grpbProduto";
            this.grpbProduto.Size = new System.Drawing.Size(754, 99);
            this.grpbProduto.TabIndex = 0;
            this.grpbProduto.TabStop = false;
            this.grpbProduto.Text = "Compra de produtos";
            // 
            // nupdQtde
            // 
            this.nupdQtde.AccessibleName = "quantidade ";
            this.nupdQtde.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdQtde.Location = new System.Drawing.Point(273, 60);
            this.nupdQtde.Name = "nupdQtde";
            this.nupdQtde.Size = new System.Drawing.Size(100, 20);
            this.nupdQtde.TabIndex = 4;
            this.nupdQtde.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(470, 63);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade:";
            // 
            // txtPreco
            // 
            this.txtPreco.AccessibleName = "Preço";
            this.txtPreco.Location = new System.Drawing.Point(73, 57);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AccessibleName = "Descrição";
            this.txtDescricao.Location = new System.Drawing.Point(259, 18);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(365, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AccessibleName = "Código";
            this.txtCodigo.Location = new System.Drawing.Point(73, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.preco,
            this.qtde,
            this.SubTotal});
            this.dgvProdutos.Location = new System.Drawing.Point(13, 128);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(635, 320);
            this.dgvProdutos.TabIndex = 6;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvProdutos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellEndEdit);
            this.dgvProdutos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProdutos_RowsRemoved);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo ";
            this.codigo.Name = "codigo";
            this.codigo.Width = 80;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "descrição ";
            this.descricao.Name = "descricao";
            this.descricao.Width = 250;
            // 
            // preco
            // 
            this.preco.HeaderText = "preço";
            this.preco.Name = "preco";
            this.preco.Width = 80;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "quantidade";
            this.qtde.Name = "qtde";
            this.qtde.Width = 80;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 80;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GrayText;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(457, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "valor total do pedido ";
            this.label5.TextChanged += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(571, 454);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(100, 20);
            this.lbltotal.TabIndex = 9;
            this.lbltotal.TextChanged += new System.EventHandler(this.lbltotal_TextChanged);
            // 
            // frmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 513);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grpbProduto);
            this.Name = "frmDataGridView";
            this.Text = "Manipulando o componente DataGridView";
            this.grpbProduto.ResumeLayout(false);
            this.grpbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupdQtde;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TextBox label5;
        private System.Windows.Forms.TextBox lbltotal;
    }
}

