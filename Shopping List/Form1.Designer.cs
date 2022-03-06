namespace Shopping_List
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.BackgroundImage = global::Shopping_List.Properties.Resources.simplefoods;
            this.grpBox1.Controls.Add(this.btnUpdate);
            this.grpBox1.Controls.Add(this.btnDelete);
            this.grpBox1.Controls.Add(this.btnAdd);
            this.grpBox1.Controls.Add(this.grpBox2);
            this.grpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBox1.Location = new System.Drawing.Point(12, 12);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(903, 894);
            this.grpBox1.TabIndex = 0;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Shopping";
            // 
            // grpBox2
            // 
            this.grpBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox2.Controls.Add(this.numUpDown1);
            this.grpBox2.Controls.Add(this.label1);
            this.grpBox2.Controls.Add(this.dataGridView1);
            this.grpBox2.Controls.Add(this.comboBox1);
            this.grpBox2.Controls.Add(this.txtBoxName);
            this.grpBox2.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.grpBox2.Location = new System.Drawing.Point(123, 41);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(680, 600);
            this.grpBox2.TabIndex = 7;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Add An Item";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxName.Location = new System.Drawing.Point(21, 56);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(224, 62);
            this.txtBoxName.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 40);
            this.comboBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.GridColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.Location = new System.Drawing.Point(21, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 399);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(123, 656);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 75);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(651, 656);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 75);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(263, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity :";
            // 
            // numUpDown1
            // 
            this.numUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown1.Location = new System.Drawing.Point(406, 69);
            this.numUpDown1.Name = "numUpDown1";
            this.numUpDown1.Size = new System.Drawing.Size(120, 39);
            this.numUpDown1.TabIndex = 11;
            this.numUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(392, 656);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 75);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(926, 785);
            this.Controls.Add(this.grpBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List";
            this.Text = "Your Personal Shopping List";
            this.Load += new System.EventHandler(this.List_Load);
            this.grpBox1.ResumeLayout(false);
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDown1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

