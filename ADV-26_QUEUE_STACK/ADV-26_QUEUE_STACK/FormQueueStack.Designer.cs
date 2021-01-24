namespace ADV_26_QUEUE_STACK
{
    partial class FormQueueStack
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.lstStack = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveItemQueue = new System.Windows.Forms.Button();
            this.btnRemveItemStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de livros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(56, 46);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(297, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // lstQueue
            // 
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.Location = new System.Drawing.Point(15, 127);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(282, 251);
            this.lstQueue.TabIndex = 3;
            this.lstQueue.SelectedIndexChanged += new System.EventHandler(this.lstQueue_SelectedIndexChanged);
            // 
            // lstStack
            // 
            this.lstStack.FormattingEnabled = true;
            this.lstStack.Location = new System.Drawing.Point(320, 127);
            this.lstStack.Name = "lstStack";
            this.lstStack.Size = new System.Drawing.Size(320, 251);
            this.lstStack.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Queue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stack:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveItemQueue
            // 
            this.btnRemoveItemQueue.Location = new System.Drawing.Point(175, 380);
            this.btnRemoveItemQueue.Name = "btnRemoveItemQueue";
            this.btnRemoveItemQueue.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveItemQueue.TabIndex = 8;
            this.btnRemoveItemQueue.Text = "Remove item Queue";
            this.btnRemoveItemQueue.UseVisualStyleBackColor = true;
            this.btnRemoveItemQueue.Click += new System.EventHandler(this.btnRemoveItemQueue_Click);
            // 
            // btnRemveItemStack
            // 
            this.btnRemveItemStack.Location = new System.Drawing.Point(526, 380);
            this.btnRemveItemStack.Name = "btnRemveItemStack";
            this.btnRemveItemStack.Size = new System.Drawing.Size(114, 23);
            this.btnRemveItemStack.TabIndex = 9;
            this.btnRemveItemStack.Text = "Remove item Stack";
            this.btnRemveItemStack.UseVisualStyleBackColor = true;
            this.btnRemveItemStack.Click += new System.EventHandler(this.btnRemveItemStack_Click);
            // 
            // FormQueueStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 414);
            this.Controls.Add(this.btnRemveItemStack);
            this.Controls.Add(this.btnRemoveItemQueue);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstStack);
            this.Controls.Add(this.lstQueue);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQueueStack";
            this.Text = "QUEUE E STACK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.ListBox lstStack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveItemQueue;
        private System.Windows.Forms.Button btnRemveItemStack;
    }
}

