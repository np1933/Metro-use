﻿namespace Metro_use
{
    partial class Employee_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Details));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.new_emp_btn = new System.Windows.Forms.Button();
            this.edit_emp_btn = new System.Windows.Forms.Button();
            this.delete_emp_btn = new System.Windows.Forms.Button();
            this.close_empdetails_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 130);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(907, 385);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // new_emp_btn
            // 
            this.new_emp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.new_emp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.new_emp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_emp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_emp_btn.Image = ((System.Drawing.Image)(resources.GetObject("new_emp_btn.Image")));
            this.new_emp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_emp_btn.Location = new System.Drawing.Point(31, 558);
            this.new_emp_btn.Margin = new System.Windows.Forms.Padding(4);
            this.new_emp_btn.Name = "new_emp_btn";
            this.new_emp_btn.Size = new System.Drawing.Size(176, 46);
            this.new_emp_btn.TabIndex = 1;
            this.new_emp_btn.Text = "   New";
            this.new_emp_btn.UseVisualStyleBackColor = false;
            this.new_emp_btn.Click += new System.EventHandler(this.new_emp_btn_Click);
            // 
            // edit_emp_btn
            // 
            this.edit_emp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.edit_emp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.edit_emp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_emp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_emp_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_emp_btn.Image")));
            this.edit_emp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_emp_btn.Location = new System.Drawing.Point(240, 558);
            this.edit_emp_btn.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.edit_emp_btn.Name = "edit_emp_btn";
            this.edit_emp_btn.Size = new System.Drawing.Size(176, 46);
            this.edit_emp_btn.TabIndex = 2;
            this.edit_emp_btn.Text = "   Edit";
            this.edit_emp_btn.UseVisualStyleBackColor = false;
            this.edit_emp_btn.Click += new System.EventHandler(this.edit_emp_btn_Click);
            // 
            // delete_emp_btn
            // 
            this.delete_emp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.delete_emp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_emp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_emp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_emp_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_emp_btn.Image")));
            this.delete_emp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_emp_btn.Location = new System.Drawing.Point(447, 558);
            this.delete_emp_btn.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.delete_emp_btn.Name = "delete_emp_btn";
            this.delete_emp_btn.Size = new System.Drawing.Size(176, 46);
            this.delete_emp_btn.TabIndex = 3;
            this.delete_emp_btn.Text = "   Delete";
            this.delete_emp_btn.UseVisualStyleBackColor = false;
            this.delete_emp_btn.Click += new System.EventHandler(this.delete_emp_btn_Click);
            // 
            // close_empdetails_btn
            // 
            this.close_empdetails_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.close_empdetails_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.close_empdetails_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_empdetails_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_empdetails_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_empdetails_btn.Image")));
            this.close_empdetails_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_empdetails_btn.Location = new System.Drawing.Point(761, 558);
            this.close_empdetails_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_empdetails_btn.Name = "close_empdetails_btn";
            this.close_empdetails_btn.Size = new System.Drawing.Size(176, 46);
            this.close_empdetails_btn.TabIndex = 4;
            this.close_empdetails_btn.Text = "   Close";
            this.close_empdetails_btn.UseVisualStyleBackColor = false;
            this.close_empdetails_btn.Click += new System.EventHandler(this.close_empdetails_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(5, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 79);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(734, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "   Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(968, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.close_empdetails_btn);
            this.Controls.Add(this.delete_emp_btn);
            this.Controls.Add(this.edit_emp_btn);
            this.Controls.Add(this.new_emp_btn);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee_Details";
            this.Padding = new System.Windows.Forms.Padding(27, 37, 27, 25);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Employee_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button new_emp_btn;
        private System.Windows.Forms.Button edit_emp_btn;
        private System.Windows.Forms.Button delete_emp_btn;
        private System.Windows.Forms.Button close_empdetails_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}