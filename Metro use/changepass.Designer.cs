using System.Windows.Forms;

namespace Metro_use
{
    partial class changepass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changepass));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.close_addtax_btn = new System.Windows.Forms.Button();
            this.taxsv_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(191, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 30);
            this.textBox1.TabIndex = 9;
            // 
            // close_addtax_btn
            // 
            this.close_addtax_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.close_addtax_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.close_addtax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_addtax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_addtax_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_addtax_btn.Image")));
            this.close_addtax_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_addtax_btn.Location = new System.Drawing.Point(352, 235);
            this.close_addtax_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_addtax_btn.Name = "close_addtax_btn";
            this.close_addtax_btn.Size = new System.Drawing.Size(176, 46);
            this.close_addtax_btn.TabIndex = 12;
            this.close_addtax_btn.Text = "   Close";
            this.close_addtax_btn.UseVisualStyleBackColor = false;
            this.close_addtax_btn.Click += new System.EventHandler(this.close_addtax_btn_Click);
            // 
            // taxsv_btn
            // 
            this.taxsv_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.taxsv_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.taxsv_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taxsv_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxsv_btn.Image = ((System.Drawing.Image)(resources.GetObject("taxsv_btn.Image")));
            this.taxsv_btn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.taxsv_btn.Location = new System.Drawing.Point(147, 235);
            this.taxsv_btn.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.taxsv_btn.Name = "taxsv_btn";
            this.taxsv_btn.Size = new System.Drawing.Size(176, 46);
            this.taxsv_btn.TabIndex = 11;
            this.taxsv_btn.Text = "   Save";
            this.taxsv_btn.UseVisualStyleBackColor = false;
            this.taxsv_btn.Click += new System.EventHandler(this.taxsv_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "New Password :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(191, 165);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 30);
            this.textBox2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 71);
            this.panel3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "* password must be numeric only";
            // 
            // changepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(571, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_addtax_btn);
            this.Controls.Add(this.taxsv_btn);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "changepass";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Load += new System.EventHandler(this.addtax_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button close_addtax_btn;
        private System.Windows.Forms.Button taxsv_btn;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private TextBox textBox2;
        private Panel panel3;
        private Label label3;
        private Label label4;
    }
}