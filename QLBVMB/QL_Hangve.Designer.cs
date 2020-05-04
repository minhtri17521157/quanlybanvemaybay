namespace QLBVMB
{
    partial class QL_Hangve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_Hangve));
            this.textBox_tenhv = new System.Windows.Forms.TextBox();
            this.textBox_mahv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tyle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.dataGridView_hangve = new System.Windows.Forms.DataGridView();
            this.comboBox_tinhtrang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hangve)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_tenhv
            // 
            this.textBox_tenhv.Location = new System.Drawing.Point(267, 98);
            this.textBox_tenhv.Name = "textBox_tenhv";
            this.textBox_tenhv.Size = new System.Drawing.Size(201, 20);
            this.textBox_tenhv.TabIndex = 8;
            // 
            // textBox_mahv
            // 
            this.textBox_mahv.Location = new System.Drawing.Point(267, 61);
            this.textBox_mahv.Name = "textBox_mahv";
            this.textBox_mahv.ReadOnly = true;
            this.textBox_mahv.Size = new System.Drawing.Size(201, 20);
            this.textBox_mahv.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên hạng vé:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã hạng vé:";
            // 
            // textBox_tyle
            // 
            this.textBox_tyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox_tyle.Location = new System.Drawing.Point(266, 174);
            this.textBox_tyle.Name = "textBox_tyle";
            this.textBox_tyle.Size = new System.Drawing.Size(76, 20);
            this.textBox_tyle.TabIndex = 10;
            this.textBox_tyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_tyle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tyle_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tỷ lệ giá so với giá gốc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tình trạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "%";
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(234, 244);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(84, 39);
            this.button_Delete.TabIndex = 16;
            this.button_Delete.Text = "Xóa";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(356, 244);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(84, 39);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "Thêm";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(105, 244);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(84, 39);
            this.button_Update.TabIndex = 14;
            this.button_Update.Text = "Cập nhật";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // dataGridView_hangve
            // 
            this.dataGridView_hangve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_hangve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hangve.Location = new System.Drawing.Point(34, 301);
            this.dataGridView_hangve.Name = "dataGridView_hangve";
            this.dataGridView_hangve.ReadOnly = true;
            this.dataGridView_hangve.Size = new System.Drawing.Size(492, 342);
            this.dataGridView_hangve.TabIndex = 17;
            this.dataGridView_hangve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hangve_CellClick);
            // 
            // comboBox_tinhtrang
            // 
            this.comboBox_tinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tinhtrang.FormattingEnabled = true;
            this.comboBox_tinhtrang.Items.AddRange(new object[] {
            "Khả dụng",
            "Không khả dụng"});
            this.comboBox_tinhtrang.Location = new System.Drawing.Point(266, 133);
            this.comboBox_tinhtrang.Name = "comboBox_tinhtrang";
            this.comboBox_tinhtrang.Size = new System.Drawing.Size(201, 21);
            this.comboBox_tinhtrang.TabIndex = 18;
            // 
            // QL_Hangve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 659);
            this.Controls.Add(this.comboBox_tinhtrang);
            this.Controls.Add(this.dataGridView_hangve);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_tyle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_tenhv);
            this.Controls.Add(this.textBox_mahv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QL_Hangve";
            this.Text = "Quản lý hạng vé";
            this.Load += new System.EventHandler(this.QL_Hangve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hangve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tenhv;
        private System.Windows.Forms.TextBox textBox_mahv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tyle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.DataGridView dataGridView_hangve;
        private System.Windows.Forms.ComboBox comboBox_tinhtrang;
    }
}