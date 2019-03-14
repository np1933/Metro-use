namespace Metro_use
{
    partial class Attedance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attedance));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.attedance_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attedance_comboBox = new System.Windows.Forms.ComboBox();
            this.absent_btn = new System.Windows.Forms.Button();
            this.close_attedance_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-1, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 64);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Attedance";
            // 
            // attedance_dateTimePicker
            // 
            this.attedance_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attedance_dateTimePicker.Location = new System.Drawing.Point(130, 90);
            this.attedance_dateTimePicker.Name = "attedance_dateTimePicker";
            this.attedance_dateTimePicker.Size = new System.Drawing.Size(290, 26);
            this.attedance_dateTimePicker.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Employee Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name :";
            // 
            // attedance_comboBox
            // 
            this.attedance_comboBox.FormattingEnabled = true;
            this.attedance_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.attedance_comboBox.Location = new System.Drawing.Point(130, 155);
            this.attedance_comboBox.Name = "attedance_comboBox";
            this.attedance_comboBox.Size = new System.Drawing.Size(115, 21);
            this.attedance_comboBox.TabIndex = 17;
            // 
            // absent_btn
            // 
            this.absent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.absent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.absent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.absent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absent_btn.Image = ((System.Drawing.Image)(resources.GetObject("absent_btn.Image")));
            this.absent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.absent_btn.Location = new System.Drawing.Point(301, 155);
            this.absent_btn.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.absent_btn.Name = "absent_btn";
            this.absent_btn.Size = new System.Drawing.Size(132, 37);
            this.absent_btn.TabIndex = 18;
            this.absent_btn.Text = "     Absent";
            this.absent_btn.UseVisualStyleBackColor = false;
            // 
            // close_attedance_btn
            // 
            this.close_attedance_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.close_attedance_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.close_attedance_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_attedance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_attedance_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_attedance_btn.Image")));
            this.close_attedance_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_attedance_btn.Location = new System.Drawing.Point(392, 428);
            this.close_attedance_btn.Name = "close_attedance_btn";
            this.close_attedance_btn.Size = new System.Drawing.Size(132, 37);
            this.close_attedance_btn.TabIndex = 19;
            this.close_attedance_btn.Text = "   Close";
            this.close_attedance_btn.UseVisualStyleBackColor = false;
            this.close_attedance_btn.Click += new System.EventHandler(this.close_empdetails_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // Attedance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close_attedance_btn);
            this.Controls.Add(this.absent_btn);
            this.Controls.Add(this.attedance_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attedance_dateTimePicker);
            this.Controls.Add(this.panel3);
            this.Name = "Attedance";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.Attedance_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker attedance_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox attedance_comboBox;
        private System.Windows.Forms.Button absent_btn;
        private System.Windows.Forms.Button close_attedance_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}