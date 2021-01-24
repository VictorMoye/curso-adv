namespace ADV_21_HERANCA
{
    partial class FrmHeranca
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCaminhao = new System.Windows.Forms.RadioButton();
            this.rdbCarro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskAno = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nupdEixos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsHeranca = new System.Data.DataSet();
            this.carros = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.caminhoes = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dgvCaminhoes = new System.Windows.Forms.DataGridView();
            this.placaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eixosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEixos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeranca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhoes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCaminhao);
            this.groupBox1.Controls.Add(this.rdbCarro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de cadastro";
            // 
            // rdbCaminhao
            // 
            this.rdbCaminhao.AutoSize = true;
            this.rdbCaminhao.Location = new System.Drawing.Point(112, 31);
            this.rdbCaminhao.Name = "rdbCaminhao";
            this.rdbCaminhao.Size = new System.Drawing.Size(72, 17);
            this.rdbCaminhao.TabIndex = 1;
            this.rdbCaminhao.TabStop = true;
            this.rdbCaminhao.Text = "Caminhão";
            this.rdbCaminhao.UseVisualStyleBackColor = true;
            this.rdbCaminhao.CheckedChanged += new System.EventHandler(this.grpTipoDeCadastro);
            // 
            // rdbCarro
            // 
            this.rdbCarro.AutoSize = true;
            this.rdbCarro.Checked = true;
            this.rdbCarro.Location = new System.Drawing.Point(22, 31);
            this.rdbCarro.Name = "rdbCarro";
            this.rdbCarro.Size = new System.Drawing.Size(50, 17);
            this.rdbCarro.TabIndex = 0;
            this.rdbCarro.TabStop = true;
            this.rdbCarro.Text = "Carro";
            this.rdbCarro.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskAno);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mskPlaca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 192);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carro";
            // 
            // mskAno
            // 
            this.mskAno.Location = new System.Drawing.Point(66, 152);
            this.mskAno.Mask = "0000";
            this.mskAno.Name = "mskAno";
            this.mskAno.Size = new System.Drawing.Size(38, 20);
            this.mskAno.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ano:";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(64, 109);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(153, 20);
            this.txtModelo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(61, 66);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(156, 20);
            this.txtMarca.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ex.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ABC-1234";
            // 
            // mskPlaca
            // 
            this.mskPlaca.Location = new System.Drawing.Point(64, 35);
            this.mskPlaca.Mask = "aaa-0000";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(58, 20);
            this.mskPlaca.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Placa:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nupdEixos);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(13, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 65);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eixos";
            // 
            // nupdEixos
            // 
            this.nupdEixos.Location = new System.Drawing.Point(126, 32);
            this.nupdEixos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupdEixos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdEixos.Name = "nupdEixos";
            this.nupdEixos.Size = new System.Drawing.Size(45, 20);
            this.nupdEixos.TabIndex = 1;
            this.nupdEixos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quantidade de eixos:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(193, 376);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            this.dgvCarros.AutoGenerateColumns = false;
            this.dgvCarros.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn});
            this.dgvCarros.DataMember = "carros";
            this.dgvCarros.DataSource = this.dsHeranca;
            this.dgvCarros.Location = new System.Drawing.Point(291, 37);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarros.Size = new System.Drawing.Size(478, 171);
            this.dgvCarros.TabIndex = 16;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            this.placaDataGridViewTextBoxColumn.Width = 65;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 150;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoDataGridViewTextBoxColumn.Width = 60;
            // 
            // dsHeranca
            // 
            this.dsHeranca.DataSetName = "NewDataSet";
            this.dsHeranca.Tables.AddRange(new System.Data.DataTable[] {
            this.carros,
            this.caminhoes});
            // 
            // carros
            // 
            this.carros.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.carros.TableName = "carros";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "placa";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "marca";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "modelo";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "ano";
            // 
            // caminhoes
            // 
            this.caminhoes.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9});
            this.caminhoes.TableName = "caminhoes";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "placa";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "marca";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "modelo";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "ano";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "eixos";
            // 
            // dgvCaminhoes
            // 
            this.dgvCaminhoes.AllowUserToAddRows = false;
            this.dgvCaminhoes.AutoGenerateColumns = false;
            this.dgvCaminhoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCaminhoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placaDataGridViewTextBoxColumn1,
            this.marcaDataGridViewTextBoxColumn1,
            this.modeloDataGridViewTextBoxColumn1,
            this.anoDataGridViewTextBoxColumn1,
            this.eixosDataGridViewTextBoxColumn});
            this.dgvCaminhoes.DataMember = "caminhoes";
            this.dgvCaminhoes.DataSource = this.dsHeranca;
            this.dgvCaminhoes.Location = new System.Drawing.Point(291, 251);
            this.dgvCaminhoes.Name = "dgvCaminhoes";
            this.dgvCaminhoes.ReadOnly = true;
            this.dgvCaminhoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaminhoes.Size = new System.Drawing.Size(478, 195);
            this.dgvCaminhoes.TabIndex = 17;
            // 
            // placaDataGridViewTextBoxColumn1
            // 
            this.placaDataGridViewTextBoxColumn1.DataPropertyName = "placa";
            this.placaDataGridViewTextBoxColumn1.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn1.Name = "placaDataGridViewTextBoxColumn1";
            this.placaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.placaDataGridViewTextBoxColumn1.Width = 55;
            // 
            // marcaDataGridViewTextBoxColumn1
            // 
            this.marcaDataGridViewTextBoxColumn1.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn1.Name = "marcaDataGridViewTextBoxColumn1";
            this.marcaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn1.Width = 135;
            // 
            // modeloDataGridViewTextBoxColumn1
            // 
            this.modeloDataGridViewTextBoxColumn1.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.Name = "modeloDataGridViewTextBoxColumn1";
            this.modeloDataGridViewTextBoxColumn1.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn1.Width = 135;
            // 
            // anoDataGridViewTextBoxColumn1
            // 
            this.anoDataGridViewTextBoxColumn1.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn1.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn1.Name = "anoDataGridViewTextBoxColumn1";
            this.anoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.anoDataGridViewTextBoxColumn1.Width = 60;
            // 
            // eixosDataGridViewTextBoxColumn
            // 
            this.eixosDataGridViewTextBoxColumn.DataPropertyName = "eixos";
            this.eixosDataGridViewTextBoxColumn.HeaderText = "Eixos";
            this.eixosDataGridViewTextBoxColumn.Name = "eixosDataGridViewTextBoxColumn";
            this.eixosDataGridViewTextBoxColumn.ReadOnly = true;
            this.eixosDataGridViewTextBoxColumn.Width = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Carros cadastrados:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Caminhões cadastrados:";
            // 
            // FrmHeranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 494);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvCaminhoes);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHeranca";
            this.Text = "HERANÇA";
            this.Load += new System.EventHandler(this.FrmHeranca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEixos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeranca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCaminhao;
        private System.Windows.Forms.RadioButton rdbCarro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskAno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nupdEixos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.DataGridView dgvCaminhoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Data.DataSet dsHeranca;
        private System.Data.DataTable carros;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataTable caminhoes;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eixosDataGridViewTextBoxColumn;
    }
}

