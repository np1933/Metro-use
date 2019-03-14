namespace Metro_use
{
    partial class alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alert));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.close_addtax_btn = new System.Windows.Forms.Button();
            this.restaurantDataSet = new Metro_use.restaurantDataSet();
            this.shopinventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shop_inventoryTableAdapter = new Metro_use.restaurantDataSetTableAdapters.shop_inventoryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopinventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_addtax_btn
            // 
            this.close_addtax_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.close_addtax_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.close_addtax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_addtax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_addtax_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_addtax_btn.Image")));
            this.close_addtax_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_addtax_btn.Location = new System.Drawing.Point(480, 481);
            this.close_addtax_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_addtax_btn.Name = "close_addtax_btn";
            this.close_addtax_btn.Size = new System.Drawing.Size(176, 46);
            this.close_addtax_btn.TabIndex = 12;
            this.close_addtax_btn.Text = "   Close";
            this.close_addtax_btn.UseVisualStyleBackColor = false;
            this.close_addtax_btn.Click += new System.EventHandler(this.close_addtax_btn_Click);
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "restaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopinventoryBindingSource
            // 
            this.shopinventoryBindingSource.DataMember = "shop_inventory";
            this.shopinventoryBindingSource.DataSource = this.restaurantDataSet;
            // 
            // shop_inventoryTableAdapter
            // 
            this.shop_inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(7, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 358);
            this.dataGridView1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 71);
            this.panel3.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Alert";
            // 
            // alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(687, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close_addtax_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "alert";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Load += new System.EventHandler(this.addtax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopinventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close_addtax_btn;
        private restaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource shopinventoryBindingSource;
        private restaurantDataSetTableAdapters.shop_inventoryTableAdapter shop_inventoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}