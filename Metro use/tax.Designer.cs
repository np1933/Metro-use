namespace Metro_use
{
    partial class tax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tax));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh_tax_btn = new System.Windows.Forms.Button();
            this.close_taxgrid_btn = new System.Windows.Forms.Button();
            this.delete_tax_btn = new System.Windows.Forms.Button();
            this.edit_tax_btn = new System.Windows.Forms.Button();
            this.new_tax_btn = new System.Windows.Forms.Button();
            this.dataGridView_tax = new System.Windows.Forms.DataGridView();
            this.restaurantDataSet = new Metro_use.restaurantDataSet();
            this.restaurantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.refresh_tax_btn);
            this.panel1.Controls.Add(this.close_taxgrid_btn);
            this.panel1.Controls.Add(this.delete_tax_btn);
            this.panel1.Controls.Add(this.edit_tax_btn);
            this.panel1.Controls.Add(this.new_tax_btn);
            this.panel1.Controls.Add(this.dataGridView_tax);
            this.panel1.Location = new System.Drawing.Point(19, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 333);
            this.panel1.TabIndex = 1;
            // 
            // refresh_tax_btn
            // 
            this.refresh_tax_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.refresh_tax_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refresh_tax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_tax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_tax_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_tax_btn.Location = new System.Drawing.Point(436, 33);
            this.refresh_tax_btn.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_tax_btn.Name = "refresh_tax_btn";
            this.refresh_tax_btn.Size = new System.Drawing.Size(292, 38);
            this.refresh_tax_btn.TabIndex = 10;
            this.refresh_tax_btn.Text = "   Refresh";
            this.refresh_tax_btn.UseVisualStyleBackColor = false;
            this.refresh_tax_btn.Visible = false;
            this.refresh_tax_btn.Click += new System.EventHandler(this.refresh_tax_btn_Click);
            // 
            // close_taxgrid_btn
            // 
            this.close_taxgrid_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.close_taxgrid_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.close_taxgrid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_taxgrid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_taxgrid_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_taxgrid_btn.Image")));
            this.close_taxgrid_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_taxgrid_btn.Location = new System.Drawing.Point(436, 267);
            this.close_taxgrid_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_taxgrid_btn.Name = "close_taxgrid_btn";
            this.close_taxgrid_btn.Size = new System.Drawing.Size(292, 39);
            this.close_taxgrid_btn.TabIndex = 9;
            this.close_taxgrid_btn.Text = "   Close";
            this.close_taxgrid_btn.UseVisualStyleBackColor = false;
            this.close_taxgrid_btn.Click += new System.EventHandler(this.close_taxgrid_btn_Click);
            // 
            // delete_tax_btn
            // 
            this.delete_tax_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.delete_tax_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_tax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_tax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_tax_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_tax_btn.Image")));
            this.delete_tax_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_tax_btn.Location = new System.Drawing.Point(436, 208);
            this.delete_tax_btn.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.delete_tax_btn.Name = "delete_tax_btn";
            this.delete_tax_btn.Size = new System.Drawing.Size(292, 41);
            this.delete_tax_btn.TabIndex = 8;
            this.delete_tax_btn.Text = "   Delete";
            this.delete_tax_btn.UseVisualStyleBackColor = false;
            this.delete_tax_btn.Click += new System.EventHandler(this.delete_tax_btn_Click);
            // 
            // edit_tax_btn
            // 
            this.edit_tax_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.edit_tax_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.edit_tax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_tax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_tax_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_tax_btn.Image")));
            this.edit_tax_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_tax_btn.Location = new System.Drawing.Point(436, 145);
            this.edit_tax_btn.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.edit_tax_btn.Name = "edit_tax_btn";
            this.edit_tax_btn.Size = new System.Drawing.Size(292, 39);
            this.edit_tax_btn.TabIndex = 7;
            this.edit_tax_btn.Text = "   Edit";
            this.edit_tax_btn.UseVisualStyleBackColor = false;
            this.edit_tax_btn.Click += new System.EventHandler(this.edit_tax_btn_Click);
            // 
            // new_tax_btn
            // 
            this.new_tax_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.new_tax_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.new_tax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_tax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_tax_btn.Image = ((System.Drawing.Image)(resources.GetObject("new_tax_btn.Image")));
            this.new_tax_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_tax_btn.Location = new System.Drawing.Point(436, 87);
            this.new_tax_btn.Margin = new System.Windows.Forms.Padding(4);
            this.new_tax_btn.Name = "new_tax_btn";
            this.new_tax_btn.Size = new System.Drawing.Size(292, 38);
            this.new_tax_btn.TabIndex = 6;
            this.new_tax_btn.Text = "   New";
            this.new_tax_btn.UseVisualStyleBackColor = false;
            this.new_tax_btn.Click += new System.EventHandler(this.new_tax_btn_Click);
            // 
            // dataGridView_tax
            // 
            this.dataGridView_tax.AllowUserToOrderColumns = true;
            this.dataGridView_tax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_tax.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_tax.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_tax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_tax.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView_tax.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_tax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_tax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_tax.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_tax.Location = new System.Drawing.Point(33, 25);
            this.dataGridView_tax.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_tax.Name = "dataGridView_tax";
            this.dataGridView_tax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tax.Size = new System.Drawing.Size(364, 283);
            this.dataGridView_tax.TabIndex = 2;
            this.dataGridView_tax.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "restaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantDataSetBindingSource
            // 
            this.restaurantDataSetBindingSource.DataSource = this.restaurantDataSet;
            this.restaurantDataSetBindingSource.Position = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 71);
            this.panel3.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tax Setup";
            // 
            // tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tax";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.tax_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_tax;
        private System.Windows.Forms.Button close_taxgrid_btn;
        private System.Windows.Forms.Button delete_tax_btn;
        private System.Windows.Forms.Button edit_tax_btn;
        private System.Windows.Forms.Button new_tax_btn;
        private System.Windows.Forms.BindingSource restaurantDataSetBindingSource;
        private restaurantDataSet restaurantDataSet;
        private System.Windows.Forms.Button refresh_tax_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}