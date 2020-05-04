namespace QLBVMB
{
    partial class Baocao_Nam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baocao_Nam));
            this.label_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_doanhthu_nam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nam = new System.Windows.Forms.TextBox();
            this.button_tra_cuu = new System.Windows.Forms.Button();
            this.label_nam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_dthu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dthu)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.Location = new System.Drawing.Point(59, 11);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(553, 29);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Báo cáo doanh thu năm bán vé các chuyển bay";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 56);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label_doanhthu_nam);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox_nam);
            this.panel3.Controls.Add(this.button_tra_cuu);
            this.panel3.Controls.Add(this.label_nam);
            this.panel3.Location = new System.Drawing.Point(5, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 124);
            this.panel3.TabIndex = 4;
            // 
            // label_doanhthu_nam
            // 
            this.label_doanhthu_nam.BackColor = System.Drawing.Color.Transparent;
            this.label_doanhthu_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_doanhthu_nam.Location = new System.Drawing.Point(372, 9);
            this.label_doanhthu_nam.Name = "label_doanhthu_nam";
            this.label_doanhthu_nam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_doanhthu_nam.Size = new System.Drawing.Size(183, 28);
            this.label_doanhthu_nam.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng doanh thu năm:";
            // 
            // textBox_nam
            // 
            this.textBox_nam.Location = new System.Drawing.Point(59, 11);
            this.textBox_nam.MaxLength = 5;
            this.textBox_nam.Name = "textBox_nam";
            this.textBox_nam.Size = new System.Drawing.Size(96, 20);
            this.textBox_nam.TabIndex = 5;
            this.textBox_nam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nam_KeyPress);
            // 
            // button_tra_cuu
            // 
            this.button_tra_cuu.BackgroundImage = global::QLBVMB.Properties.Resources.btnTimKiem;
            this.button_tra_cuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_tra_cuu.FlatAppearance.BorderSize = 0;
            this.button_tra_cuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tra_cuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tra_cuu.Location = new System.Drawing.Point(86, 49);
            this.button_tra_cuu.Name = "button_tra_cuu";
            this.button_tra_cuu.Size = new System.Drawing.Size(69, 36);
            this.button_tra_cuu.TabIndex = 4;
            this.button_tra_cuu.UseVisualStyleBackColor = true;
            this.button_tra_cuu.Click += new System.EventHandler(this.button_tra_cuu_Click);
            // 
            // label_nam
            // 
            this.label_nam.AutoSize = true;
            this.label_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nam.Location = new System.Drawing.Point(8, 12);
            this.label_nam.Name = "label_nam";
            this.label_nam.Size = new System.Drawing.Size(50, 20);
            this.label_nam.TabIndex = 3;
            this.label_nam.Text = "Năm:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dataGridView_dthu);
            this.panel2.Location = new System.Drawing.Point(5, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 392);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView_dthu
            // 
            this.dataGridView_dthu.AllowUserToAddRows = false;
            this.dataGridView_dthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dthu.Location = new System.Drawing.Point(18, 17);
            this.dataGridView_dthu.Name = "dataGridView_dthu";
            this.dataGridView_dthu.ReadOnly = true;
            this.dataGridView_dthu.RowHeadersVisible = false;
            this.dataGridView_dthu.Size = new System.Drawing.Size(613, 360);
            this.dataGridView_dthu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "VNĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tra cứu";
            // 
            // Baocao_Nam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 596);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Baocao_Nam";
            this.Text = "Báo cáo doanh thu năm";
            this.Load += new System.EventHandler(this.Baocao_Nam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_nam;
        private System.Windows.Forms.Button button_tra_cuu;
        private System.Windows.Forms.Label label_nam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_dthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_doanhthu_nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}