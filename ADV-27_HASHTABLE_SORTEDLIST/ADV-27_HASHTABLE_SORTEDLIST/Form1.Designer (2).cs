namespace ADV_27_HASHTABLE_SORTEDLIST
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.txtChaveSortedList = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChaveHashTable = new System.Windows.Forms.TextBox();
            this.btnRemoveKeySortedList = new System.Windows.Forms.Button();
            this.btnRemoveKeyHashTable = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lstSortedList = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstHashTable = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEMBROS DA FAMÍLIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(79, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(370, 35);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(70, 20);
            this.txtIdade.TabIndex = 5;
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.Location = new System.Drawing.Point(460, 34);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(75, 23);
            this.btnAdiciona.TabIndex = 6;
            this.btnAdiciona.Text = "Adiciona";
            this.btnAdiciona.UseVisualStyleBackColor = true;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // txtChaveSortedList
            // 
            this.txtChaveSortedList.Location = new System.Drawing.Point(333, 412);
            this.txtChaveSortedList.Name = "txtChaveSortedList";
            this.txtChaveSortedList.Size = new System.Drawing.Size(166, 20);
            this.txtChaveSortedList.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Chave a ser removida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Chave a ser removida";
            // 
            // txtChaveHashTable
            // 
            this.txtChaveHashTable.Location = new System.Drawing.Point(37, 413);
            this.txtChaveHashTable.Name = "txtChaveHashTable";
            this.txtChaveHashTable.Size = new System.Drawing.Size(166, 20);
            this.txtChaveHashTable.TabIndex = 34;
            // 
            // btnRemoveKeySortedList
            // 
            this.btnRemoveKeySortedList.Location = new System.Drawing.Point(510, 411);
            this.btnRemoveKeySortedList.Name = "btnRemoveKeySortedList";
            this.btnRemoveKeySortedList.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveKeySortedList.TabIndex = 33;
            this.btnRemoveKeySortedList.Text = "Remove item";
            this.btnRemoveKeySortedList.UseVisualStyleBackColor = true;
            // 
            // btnRemoveKeyHashTable
            // 
            this.btnRemoveKeyHashTable.Location = new System.Drawing.Point(209, 411);
            this.btnRemoveKeyHashTable.Name = "btnRemoveKeyHashTable";
            this.btnRemoveKeyHashTable.Size = new System.Drawing.Size(96, 23);
            this.btnRemoveKeyHashTable.TabIndex = 32;
            this.btnRemoveKeyHashTable.Text = "Remove item";
            this.btnRemoveKeyHashTable.UseVisualStyleBackColor = true;
            this.btnRemoveKeyHashTable.Click += new System.EventHandler(this.btnRemoveKeyHashTable_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "SortedList";
            // 
            // lstSortedList
            // 
            this.lstSortedList.FormattingEnabled = true;
            this.lstSortedList.Location = new System.Drawing.Point(332, 93);
            this.lstSortedList.Name = "lstSortedList";
            this.lstSortedList.Size = new System.Drawing.Size(268, 290);
            this.lstSortedList.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "HashTable";
            // 
            // lstHashTable
            // 
            this.lstHashTable.FormattingEnabled = true;
            this.lstHashTable.Location = new System.Drawing.Point(37, 93);
            this.lstHashTable.Name = "lstHashTable";
            this.lstHashTable.Size = new System.Drawing.Size(268, 290);
            this.lstHashTable.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 442);
            this.Controls.Add(this.txtChaveSortedList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtChaveHashTable);
            this.Controls.Add(this.btnRemoveKeySortedList);
            this.Controls.Add(this.btnRemoveKeyHashTable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstSortedList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstHashTable);
            this.Controls.Add(this.btnAdiciona);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TRABALHANDO COM HASHTABLE E SORTEDLIST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.TextBox txtChaveSortedList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChaveHashTable;
        private System.Windows.Forms.Button btnRemoveKeySortedList;
        private System.Windows.Forms.Button btnRemoveKeyHashTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstSortedList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstHashTable;
    }
}

