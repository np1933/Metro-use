namespace Metro_use
{
    partial class reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reports));
            this.close_addtax_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.close_addtax_btn.Location = new System.Drawing.Point(1176, 506);
            this.close_addtax_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_addtax_btn.Name = "close_addtax_btn";
            this.close_addtax_btn.Size = new System.Drawing.Size(176, 46);
            this.close_addtax_btn.TabIndex = 12;
            this.close_addtax_btn.Text = "   Close";
            this.close_addtax_btn.UseVisualStyleBackColor = false;
            this.close_addtax_btn.Click += new System.EventHandler(this.close_addtax_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(7, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 70);
            this.panel3.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 33);
            this.label14.TabIndex = 7;
            this.label14.Text = "Reports";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1345, 406);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1363, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.close_addtax_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "reports";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.addtax_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close_addtax_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}