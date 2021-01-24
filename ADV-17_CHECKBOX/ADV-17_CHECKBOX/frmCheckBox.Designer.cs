namespace ADV_17_CHECKEDBOX
{
    partial class frmCheckBox
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
            this.components = new System.ComponentModel.Container();
            this.grpbCliente = new System.Windows.Forms.GroupBox();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbCursos = new System.Windows.Forms.GroupBox();
            this.chkWebMaster = new System.Windows.Forms.CheckBox();
            this.chkWebDeveloper = new System.Windows.Forms.CheckBox();
            this.chkPhp = new System.Windows.Forms.CheckBox();
            this.chkWebDesign = new System.Windows.Forms.CheckBox();
            this.chkPowerPoint = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.chkAspNet = new System.Windows.Forms.CheckBox();
            this.chkExcel = new System.Windows.Forms.CheckBox();
            this.chkWord = new System.Windows.Forms.CheckBox();
            this.chkMySQL = new System.Windows.Forms.CheckBox();
            this.chkSQL = new System.Windows.Forms.CheckBox();
            this.chkAccess = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.grpbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbCliente
            // 
            this.grpbCliente.Controls.Add(this.pbStatus);
            this.grpbCliente.Controls.Add(this.txtNome);
            this.grpbCliente.Controls.Add(this.label1);
            this.grpbCliente.Location = new System.Drawing.Point(13, 13);
            this.grpbCliente.Name = "grpbCliente";
            this.grpbCliente.Size = new System.Drawing.Size(518, 72);
            this.grpbCliente.TabIndex = 0;
            this.grpbCliente.TabStop = false;
            this.grpbCliente.Text = "Cliente";
            // 
            // pbStatus
            // 
            this.pbStatus.Image = global::ADV_17_CHECKEDBOX.Properties.Resources.bgWPF;
            this.pbStatus.Location = new System.Drawing.Point(382, 31);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(16, 16);
            this.pbStatus.TabIndex = 2;
            this.pbStatus.TabStop = false;
            this.toolTip1.SetToolTip(this.pbStatus, "para exibor os cursos informe um nome moaior ou igual a 4 letras ");
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpbCursos
            // 
            this.grpbCursos.Controls.Add(this.chkWebMaster);
            this.grpbCursos.Controls.Add(this.chkWebDeveloper);
            this.grpbCursos.Controls.Add(this.chkPhp);
            this.grpbCursos.Controls.Add(this.chkWebDesign);
            this.grpbCursos.Controls.Add(this.chkPowerPoint);
            this.grpbCursos.Controls.Add(this.chkCSharp);
            this.grpbCursos.Controls.Add(this.chkAspNet);
            this.grpbCursos.Controls.Add(this.chkExcel);
            this.grpbCursos.Controls.Add(this.chkWord);
            this.grpbCursos.Controls.Add(this.chkMySQL);
            this.grpbCursos.Controls.Add(this.chkSQL);
            this.grpbCursos.Controls.Add(this.chkAccess);
            this.grpbCursos.Location = new System.Drawing.Point(13, 101);
            this.grpbCursos.Name = "grpbCursos";
            this.grpbCursos.Size = new System.Drawing.Size(518, 122);
            this.grpbCursos.TabIndex = 1;
            this.grpbCursos.TabStop = false;
            this.grpbCursos.Text = "Cursos de interesse";
            this.grpbCursos.Visible = false;
            // 
            // chkWebMaster
            // 
            this.chkWebMaster.AutoSize = true;
            this.chkWebMaster.Location = new System.Drawing.Point(388, 70);
            this.chkWebMaster.Name = "chkWebMaster";
            this.chkWebMaster.Size = new System.Drawing.Size(84, 17);
            this.chkWebMaster.TabIndex = 5;
            this.chkWebMaster.Text = "Web Master";
            this.chkWebMaster.UseVisualStyleBackColor = true;
            // 
            // chkWebDeveloper
            // 
            this.chkWebDeveloper.AutoSize = true;
            this.chkWebDeveloper.Location = new System.Drawing.Point(388, 49);
            this.chkWebDeveloper.Name = "chkWebDeveloper";
            this.chkWebDeveloper.Size = new System.Drawing.Size(101, 17);
            this.chkWebDeveloper.TabIndex = 8;
            this.chkWebDeveloper.Text = "Web Developer";
            this.chkWebDeveloper.UseVisualStyleBackColor = true;
            // 
            // chkPhp
            // 
            this.chkPhp.AutoSize = true;
            this.chkPhp.Location = new System.Drawing.Point(269, 70);
            this.chkPhp.Name = "chkPhp";
            this.chkPhp.Size = new System.Drawing.Size(45, 17);
            this.chkPhp.TabIndex = 4;
            this.chkPhp.Text = "Php";
            this.chkPhp.UseVisualStyleBackColor = true;
            // 
            // chkWebDesign
            // 
            this.chkWebDesign.AutoSize = true;
            this.chkWebDesign.Location = new System.Drawing.Point(388, 26);
            this.chkWebDesign.Name = "chkWebDesign";
            this.chkWebDesign.Size = new System.Drawing.Size(85, 17);
            this.chkWebDesign.TabIndex = 7;
            this.chkWebDesign.Text = "Web Design";
            this.chkWebDesign.UseVisualStyleBackColor = true;
            // 
            // chkPowerPoint
            // 
            this.chkPowerPoint.AutoSize = true;
            this.chkPowerPoint.Location = new System.Drawing.Point(138, 70);
            this.chkPowerPoint.Name = "chkPowerPoint";
            this.chkPowerPoint.Size = new System.Drawing.Size(83, 17);
            this.chkPowerPoint.TabIndex = 3;
            this.chkPowerPoint.Text = "Power Point";
            this.chkPowerPoint.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(269, 49);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(61, 17);
            this.chkCSharp.TabIndex = 6;
            this.chkCSharp.Text = "CSharp";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // chkAspNet
            // 
            this.chkAspNet.AutoSize = true;
            this.chkAspNet.Location = new System.Drawing.Point(269, 26);
            this.chkAspNet.Name = "chkAspNet";
            this.chkAspNet.Size = new System.Drawing.Size(64, 17);
            this.chkAspNet.TabIndex = 5;
            this.chkAspNet.Text = "Asp.Net";
            this.chkAspNet.UseVisualStyleBackColor = true;
            // 
            // chkExcel
            // 
            this.chkExcel.AutoSize = true;
            this.chkExcel.Location = new System.Drawing.Point(138, 49);
            this.chkExcel.Name = "chkExcel";
            this.chkExcel.Size = new System.Drawing.Size(79, 17);
            this.chkExcel.TabIndex = 4;
            this.chkExcel.Text = "Excel 2007";
            this.chkExcel.UseVisualStyleBackColor = true;
            // 
            // chkWord
            // 
            this.chkWord.AutoSize = true;
            this.chkWord.Location = new System.Drawing.Point(138, 26);
            this.chkWord.Name = "chkWord";
            this.chkWord.Size = new System.Drawing.Size(52, 17);
            this.chkWord.TabIndex = 3;
            this.chkWord.Text = "Word";
            this.chkWord.UseVisualStyleBackColor = true;
            // 
            // chkMySQL
            // 
            this.chkMySQL.AutoSize = true;
            this.chkMySQL.Location = new System.Drawing.Point(23, 72);
            this.chkMySQL.Name = "chkMySQL";
            this.chkMySQL.Size = new System.Drawing.Size(61, 17);
            this.chkMySQL.TabIndex = 2;
            this.chkMySQL.Text = "MySQL";
            this.chkMySQL.UseVisualStyleBackColor = true;
            // 
            // chkSQL
            // 
            this.chkSQL.AutoSize = true;
            this.chkSQL.Location = new System.Drawing.Point(23, 49);
            this.chkSQL.Name = "chkSQL";
            this.chkSQL.Size = new System.Drawing.Size(81, 17);
            this.chkSQL.TabIndex = 1;
            this.chkSQL.Text = "SQL Server";
            this.chkSQL.UseVisualStyleBackColor = true;
            // 
            // chkAccess
            // 
            this.chkAccess.AutoSize = true;
            this.chkAccess.Location = new System.Drawing.Point(23, 26);
            this.chkAccess.Name = "chkAccess";
            this.chkAccess.Size = new System.Drawing.Size(88, 17);
            this.chkAccess.TabIndex = 0;
            this.chkAccess.Text = "Access 2007";
            this.chkAccess.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(455, 229);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.toolTip1.SetToolTip(this.btnEnviar, "clique no botão para exibir os cursos selecionados ");
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 269);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grpbCursos);
            this.Controls.Add(this.grpbCliente);
            this.Name = "frmCheckBox";
            this.Text = "Trabalhoando Check Box";
            this.grpbCliente.ResumeLayout(false);
            this.grpbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.grpbCursos.ResumeLayout(false);
            this.grpbCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbCursos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox chkWebDeveloper;
        private System.Windows.Forms.CheckBox chkWebDesign;
        private System.Windows.Forms.CheckBox chkPowerPoint;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.CheckBox chkAspNet;
        private System.Windows.Forms.CheckBox chkExcel;
        private System.Windows.Forms.CheckBox chkWord;
        private System.Windows.Forms.CheckBox chkMySQL;
        private System.Windows.Forms.CheckBox chkSQL;
        private System.Windows.Forms.CheckBox chkAccess;
        private System.Windows.Forms.CheckBox chkPhp;
        private System.Windows.Forms.CheckBox chkWebMaster;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

