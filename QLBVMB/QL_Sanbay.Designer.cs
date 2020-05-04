namespace QLBVMB
{
    partial class QL_Sanbay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_Sanbay));
            this.dataGridView_Sanbay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_masb = new System.Windows.Forms.TextBox();
            this.textBox_tensb = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_slcanxoa = new System.Windows.Forms.Label();
            this.label_realslcanxoa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_hd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sanbay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Sanbay
            // 
            this.dataGridView_Sanbay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sanbay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sanbay.Location = new System.Drawing.Point(12, 262);
            this.dataGridView_Sanbay.Name = "dataGridView_Sanbay";
            this.dataGridView_Sanbay.ReadOnly = true;
            this.dataGridView_Sanbay.Size = new System.Drawing.Size(492, 356);
            this.dataGridView_Sanbay.TabIndex = 0;
            this.dataGridView_Sanbay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Sanbay_CellClick);
            this.dataGridView_Sanbay.SelectionChanged += new System.EventHandler(this.dataGridView_Sanbay_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sân bay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sân bay:";
            // 
            // textBox_masb
            // 
            this.textBox_masb.Location = new System.Drawing.Point(184, 25);
            this.textBox_masb.Name = "textBox_masb";
            this.textBox_masb.ReadOnly = true;
            this.textBox_masb.Size = new System.Drawing.Size(201, 20);
            this.textBox_masb.TabIndex = 3;
            // 
            // textBox_tensb
            // 
            this.textBox_tensb.Location = new System.Drawing.Point(184, 56);
            this.textBox_tensb.Name = "textBox_tensb";
            this.textBox_tensb.Size = new System.Drawing.Size(201, 20);
            this.textBox_tensb.TabIndex = 4;
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(92, 190);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(84, 39);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Cập nhật";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(343, 190);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(84, 39);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Thêm";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(221, 190);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(84, 39);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Xóa";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_slcanxoa
            // 
            this.label_slcanxoa.AutoSize = true;
            this.label_slcanxoa.BackColor = System.Drawing.Color.Transparent;
            this.label_slcanxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slcanxoa.Location = new System.Drawing.Point(128, 141);
            this.label_slcanxoa.Name = "label_slcanxoa";
            this.label_slcanxoa.Size = new System.Drawing.Size(240, 24);
            this.label_slcanxoa.TabIndex = 8;
            this.label_slcanxoa.Text = "*Số lượng sân bay cần xóa:";
            // 
            // label_realslcanxoa
            // 
            this.label_realslcanxoa.BackColor = System.Drawing.Color.Salmon;
            this.label_realslcanxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_realslcanxoa.Location = new System.Drawing.Point(383, 141);
            this.label_realslcanxoa.Name = "label_realslcanxoa";
            this.label_realslcanxoa.Size = new System.Drawing.Size(66, 24);
            this.label_realslcanxoa.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tình trạng:";
            // 
            // comboBox_hd
            // 
            this.comboBox_hd.AutoCompleteCustomSource.AddRange(new string[] {
            "Hoạt động",
            "Không hoạt động"});
            this.comboBox_hd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hd.FormattingEnabled = true;
            this.comboBox_hd.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.comboBox_hd.Location = new System.Drawing.Point(184, 92);
            this.comboBox_hd.Name = "comboBox_hd";
            this.comboBox_hd.Size = new System.Drawing.Size(121, 21);
            this.comboBox_hd.TabIndex = 11;
            // 
            // QL_Sanbay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 634);
            this.Controls.Add(this.comboBox_hd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_realslcanxoa);
            this.Controls.Add(this.label_slcanxoa);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_tensb);
            this.Controls.Add(this.textBox_masb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Sanbay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QL_Sanbay";
            this.Text = "Quản lý sân bay";
            this.Load += new System.EventHandler(this.QL_Sanbay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sanbay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Sanbay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_masb;
        private System.Windows.Forms.TextBox textBox_tensb;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label_slcanxoa;
        private System.Windows.Forms.Label label_realslcanxoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_hd;
    }
}