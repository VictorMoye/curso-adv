namespace ADV_25_ARRAYLIST
{
    partial class FormArrayList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lstbCursos = new System.Windows.Forms.ListBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(87, 52);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(262, 20);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // lstbCursos
            // 
            this.lstbCursos.FormattingEnabled = true;
            this.lstbCursos.Location = new System.Drawing.Point(87, 90);
            this.lstbCursos.Name = "lstbCursos";
            this.lstbCursos.Size = new System.Drawing.Size(262, 160);
            this.lstbCursos.TabIndex = 3;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(87, 272);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(51, 23);
            this.btnLer.TabIndex = 4;
            this.btnLer.Text = "Lêr";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(153, 272);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(252, 272);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(93, 23);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Ordernar [a-z]";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // FormArrayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 307);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.lstbCursos);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormArrayList";
            this.Text = "ARRAY LIST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ListBox lstbCursos;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnOrder;
    }
}

