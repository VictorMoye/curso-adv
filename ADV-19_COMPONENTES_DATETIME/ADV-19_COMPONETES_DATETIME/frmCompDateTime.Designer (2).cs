namespace ADV_19_COMPONENTES_DATETIME
{
    partial class frmCompDateTime
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mcData = new System.Windows.Forms.MonthCalendar();
            this.lblAnoMC = new System.Windows.Forms.Label();
            this.lbl_MC_DataSelecionada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMesMC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiaMC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbl_DTP_dataSelecionada = new System.Windows.Forms.Label();
            this.lblAnoTP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMesTP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDiaTP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timerRelogioDigital = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.mcData);
            this.groupBox1.Controls.Add(this.lblAnoMC);
            this.groupBox1.Controls.Add(this.lbl_MC_DataSelecionada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMesMC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDiaMC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 334);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Componente MonthCalendar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // mcData
            // 
            this.mcData.Location = new System.Drawing.Point(6, 20);
            this.mcData.Name = "mcData";
            this.mcData.TabIndex = 6;
            this.mcData.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcData_DateChanged);
            // 
            // lblAnoMC
            // 
            this.lblAnoMC.BackColor = System.Drawing.Color.White;
            this.lblAnoMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnoMC.Location = new System.Drawing.Point(183, 303);
            this.lblAnoMC.Name = "lblAnoMC";
            this.lblAnoMC.Size = new System.Drawing.Size(55, 20);
            this.lblAnoMC.TabIndex = 7;
            // 
            // lbl_MC_DataSelecionada
            // 
            this.lbl_MC_DataSelecionada.BackColor = System.Drawing.Color.White;
            this.lbl_MC_DataSelecionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_MC_DataSelecionada.Location = new System.Drawing.Point(145, 191);
            this.lbl_MC_DataSelecionada.Name = "lbl_MC_DataSelecionada";
            this.lbl_MC_DataSelecionada.Size = new System.Drawing.Size(95, 20);
            this.lbl_MC_DataSelecionada.TabIndex = 18;
            this.lbl_MC_DataSelecionada.Click += new System.EventHandler(this.lbl_MC_DataSelecionada_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data selecionada:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMesMC
            // 
            this.lblMesMC.BackColor = System.Drawing.Color.White;
            this.lblMesMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMesMC.Location = new System.Drawing.Point(183, 261);
            this.lblMesMC.Name = "lblMesMC";
            this.lblMesMC.Size = new System.Drawing.Size(55, 20);
            this.lblMesMC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mês";
            // 
            // lblDiaMC
            // 
            this.lblDiaMC.BackColor = System.Drawing.Color.White;
            this.lblDiaMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiaMC.Location = new System.Drawing.Point(183, 225);
            this.lblDiaMC.Name = "lblDiaMC";
            this.lblDiaMC.Size = new System.Drawing.Size(55, 20);
            this.lblDiaMC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dia:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpData);
            this.groupBox2.Controls.Add(this.lbl_DTP_dataSelecionada);
            this.groupBox2.Controls.Add(this.lblAnoTP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblMesTP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblDiaTP);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(294, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 334);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Componente DateTimePicker";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(34, 84);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 21;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // lbl_DTP_dataSelecionada
            // 
            this.lbl_DTP_dataSelecionada.BackColor = System.Drawing.Color.White;
            this.lbl_DTP_dataSelecionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DTP_dataSelecionada.Location = new System.Drawing.Point(138, 135);
            this.lbl_DTP_dataSelecionada.Name = "lbl_DTP_dataSelecionada";
            this.lbl_DTP_dataSelecionada.Size = new System.Drawing.Size(95, 20);
            this.lbl_DTP_dataSelecionada.TabIndex = 20;
            // 
            // lblAnoTP
            // 
            this.lblAnoTP.BackColor = System.Drawing.Color.White;
            this.lblAnoTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnoTP.Location = new System.Drawing.Point(179, 249);
            this.lblAnoTP.Name = "lblAnoTP";
            this.lblAnoTP.Size = new System.Drawing.Size(55, 20);
            this.lblAnoTP.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ano:";
            // 
            // lblMesTP
            // 
            this.lblMesTP.BackColor = System.Drawing.Color.White;
            this.lblMesTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMesTP.Location = new System.Drawing.Point(179, 207);
            this.lblMesTP.Name = "lblMesTP";
            this.lblMesTP.Size = new System.Drawing.Size(55, 20);
            this.lblMesTP.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mês";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Data selecionada:";
            // 
            // lblDiaTP
            // 
            this.lblDiaTP.BackColor = System.Drawing.Color.White;
            this.lblDiaTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiaTP.Location = new System.Drawing.Point(179, 171);
            this.lblDiaTP.Name = "lblDiaTP";
            this.lblDiaTP.Size = new System.Drawing.Size(55, 20);
            this.lblDiaTP.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dia:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRelogio);
            this.groupBox3.Location = new System.Drawing.Point(174, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 70);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relógio Digital";
            // 
            // lblRelogio
            // 
            this.lblRelogio.BackColor = System.Drawing.Color.White;
            this.lblRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(6, 15);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(188, 51);
            this.lblRelogio.TabIndex = 0;
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRelogioDigital
            // 
            this.timerRelogioDigital.Enabled = true;
            this.timerRelogioDigital.Interval = 999;
            this.timerRelogioDigital.Tick += new System.EventHandler(this.timerRelogioDigital_Tick);
            // 
            // frmCompDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 455);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCompDateTime";
            this.Text = "Componentes Date time";
            this.Load += new System.EventHandler(this.frmCompDateTime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAnoMC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMesMC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiaMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAnoTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMesTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDiaTP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Label lbl_MC_DataSelecionada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DTP_dataSelecionada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar mcData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Timer timerRelogioDigital;
    }
}

