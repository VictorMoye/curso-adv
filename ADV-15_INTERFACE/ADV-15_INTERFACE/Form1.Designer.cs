namespace ADV_15_INTERFACE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grbddadosinformados = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbldatadenascimento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbcurso = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gboxsexo = new System.Windows.Forms.GroupBox();
            this.rdbfeminino = new System.Windows.Forms.RadioButton();
            this.rdbmasculino = new System.Windows.Forms.RadioButton();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.eventLog2 = new System.Diagnostics.EventLog();
            this.eventLog3 = new System.Diagnostics.EventLog();
            this.lblsexo = new System.Windows.Forms.Label();
            this.dtbdatadenascimento = new System.Windows.Forms.DateTimePicker();
            this.lblcurso = new System.Windows.Forms.Label();
            this.grbddadosinformados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gboxsexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(326, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-MAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // grbddadosinformados
            // 
            this.grbddadosinformados.Controls.Add(this.lblcurso);
            this.grbddadosinformados.Controls.Add(this.lblsexo);
            this.grbddadosinformados.Controls.Add(this.label11);
            this.grbddadosinformados.Controls.Add(this.lbldatadenascimento);
            this.grbddadosinformados.Controls.Add(this.label9);
            this.grbddadosinformados.Controls.Add(this.lblEmail);
            this.grbddadosinformados.Controls.Add(this.label7);
            this.grbddadosinformados.Controls.Add(this.label5);
            this.grbddadosinformados.Controls.Add(this.lblnome);
            this.grbddadosinformados.Controls.Add(this.label3);
            this.grbddadosinformados.Location = new System.Drawing.Point(7, 216);
            this.grbddadosinformados.Name = "grbddadosinformados";
            this.grbddadosinformados.Size = new System.Drawing.Size(480, 280);
            this.grbddadosinformados.TabIndex = 8;
            this.grbddadosinformados.TabStop = false;
            this.grbddadosinformados.Text = "dados informado ";
            this.grbddadosinformados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Curso";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbldatadenascimento
            // 
            this.lbldatadenascimento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldatadenascimento.Location = new System.Drawing.Point(113, 171);
            this.lbldatadenascimento.Name = "lbldatadenascimento";
            this.lbldatadenascimento.Size = new System.Drawing.Size(148, 20);
            this.lbldatadenascimento.TabIndex = 12;
            this.lbldatadenascimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbldatadenascimento.Click += new System.EventHandler(this.lbldatadenascimento_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "data de nascimento";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(87, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(148, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "sexo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblnome
            // 
            this.lblnome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnome.Location = new System.Drawing.Point(76, 41);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(351, 20);
            this.lblnome.TabIndex = 9;
            this.lblnome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbcurso);
            this.groupBox2.Location = new System.Drawing.Point(255, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "selecione o curso ";
            // 
            // cmbcurso
            // 
            this.cmbcurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcurso.FormattingEnabled = true;
            this.cmbcurso.Items.AddRange(new object[] {
            "access ",
            "algoritmos c++",
            "asp.net",
            "excel basic ",
            "2007",
            "excel express ",
            "2007",
            "excel ",
            "avançado 2007",
            "excel vba 2007",
            "java scripts ",
            "mySQL5",
            "php5 ",
            "VB.met"});
            this.cmbcurso.Location = new System.Drawing.Point(13, 19);
            this.cmbcurso.Name = "cmbcurso";
            this.cmbcurso.Size = new System.Drawing.Size(187, 21);
            this.cmbcurso.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "data de nascimento ";
            // 
            // gboxsexo
            // 
            this.gboxsexo.Controls.Add(this.rdbfeminino);
            this.gboxsexo.Controls.Add(this.rdbmasculino);
            this.gboxsexo.Location = new System.Drawing.Point(494, 63);
            this.gboxsexo.Name = "gboxsexo";
            this.gboxsexo.Size = new System.Drawing.Size(142, 71);
            this.gboxsexo.TabIndex = 3;
            this.gboxsexo.TabStop = false;
            this.gboxsexo.Text = "Sexo";
            // 
            // rdbfeminino
            // 
            this.rdbfeminino.AutoSize = true;
            this.rdbfeminino.Location = new System.Drawing.Point(22, 43);
            this.rdbfeminino.Name = "rdbfeminino";
            this.rdbfeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbfeminino.TabIndex = 5;
            this.rdbfeminino.Text = "feminino ";
            this.rdbfeminino.UseVisualStyleBackColor = true;
            // 
            // rdbmasculino
            // 
            this.rdbmasculino.AutoSize = true;
            this.rdbmasculino.Checked = true;
            this.rdbmasculino.Location = new System.Drawing.Point(22, 20);
            this.rdbmasculino.Name = "rdbmasculino";
            this.rdbmasculino.Size = new System.Drawing.Size(75, 17);
            this.rdbmasculino.TabIndex = 4;
            this.rdbmasculino.TabStop = true;
            this.rdbmasculino.Text = "masculino ";
            this.rdbmasculino.UseVisualStyleBackColor = true;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(554, 229);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 14;
            this.btncadastrar.Text = "cadastrar ";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(554, 275);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "cancelar ";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(554, 328);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 16;
            this.btnsair.Text = "sair ";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // eventLog2
            // 
            this.eventLog2.SynchronizingObject = this;
            // 
            // eventLog3
            // 
            this.eventLog3.SynchronizingObject = this;
            // 
            // lblsexo
            // 
            this.lblsexo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsexo.Location = new System.Drawing.Point(87, 82);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(148, 20);
            this.lblsexo.TabIndex = 14;
            this.lblsexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblsexo.Click += new System.EventHandler(this.lblsexo_Click);
            // 
            // dtbdatadenascimento
            // 
            this.dtbdatadenascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbdatadenascimento.Location = new System.Drawing.Point(119, 100);
            this.dtbdatadenascimento.Name = "dtbdatadenascimento";
            this.dtbdatadenascimento.Size = new System.Drawing.Size(112, 20);
            this.dtbdatadenascimento.TabIndex = 17;
            // 
            // lblcurso
            // 
            this.lblcurso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcurso.Location = new System.Drawing.Point(113, 208);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(148, 20);
            this.lblcurso.TabIndex = 15;
            this.lblcurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 512);
            this.Controls.Add(this.dtbdatadenascimento);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.gboxsexo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbddadosinformados);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "conhecendo os componentes ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbddadosinformados.ResumeLayout(false);
            this.grbddadosinformados.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gboxsexo.ResumeLayout(false);
            this.gboxsexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grbddadosinformados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbldatadenascimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gboxsexo;
        private System.Windows.Forms.RadioButton rdbfeminino;
        private System.Windows.Forms.RadioButton rdbmasculino;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.ComboBox cmbcurso;
        private System.Diagnostics.EventLog eventLog1;
        private System.Diagnostics.EventLog eventLog2;
        private System.Diagnostics.EventLog eventLog3;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.DateTimePicker dtbdatadenascimento;
        private System.Windows.Forms.Label lblcurso;
    }
}

