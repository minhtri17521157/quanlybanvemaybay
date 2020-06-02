namespace QLBVMB
{
    partial class NhanLichChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanLichChuyenBay));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_sbtrunggian = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SANBAYTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_xoa_sb_tg = new System.Windows.Forms.Button();
            this.label_ghichu_note = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_note_ghichu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_thoigiandung = new System.Windows.Forms.TextBox();
            this.button_them_sb_tg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_sb_trung_gian = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_xoa_hangghe = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_slghe = new System.Windows.Forms.TextBox();
            this.button_them_hv = new System.Windows.Forms.Button();
            this.comboBox_hangve = new System.Windows.Forms.ComboBox();
            this.dataGridView_hangve = new System.Windows.Forms.DataGridView();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TENHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLGHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button_nhan_lich = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_macb = new System.Windows.Forms.TextBox();
            this.textBox_thoigianbay = new System.Windows.Forms.TextBox();
            this.comboBox_sbdi = new System.Windows.Forms.ComboBox();
            this.comboBox_sbden = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_ngaygio = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_giave = new System.Windows.Forms.ComboBox();
            this.button_swap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_tuyenbay_khadung = new System.Windows.Forms.Label();
            this.pictureBox_check = new System.Windows.Forms.PictureBox();
            this.label_note_check2sb = new System.Windows.Forms.Label();
            this.label_note_tgbay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sbtrunggian)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hangve)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_check)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhận lịch chuyến bay";
            // 
            // dataGridView_sbtrunggian
            // 
            this.dataGridView_sbtrunggian.AllowUserToAddRows = false;
            this.dataGridView_sbtrunggian.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView_sbtrunggian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sbtrunggian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.STT,
            this.SANBAYTG,
            this.THOIGIANDUNG,
            this.GHICHU});
            this.dataGridView_sbtrunggian.Location = new System.Drawing.Point(25, 172);
            this.dataGridView_sbtrunggian.Name = "dataGridView_sbtrunggian";
            this.dataGridView_sbtrunggian.RowHeadersVisible = false;
            this.dataGridView_sbtrunggian.Size = new System.Drawing.Size(569, 163);
            this.dataGridView_sbtrunggian.TabIndex = 9;
            // 
            // select
            // 
            this.select.HeaderText = "Chọn";
            this.select.Name = "select";
            this.select.Width = 50;
            // 
            // STT
            // 
            this.STT.FillWeight = 101.5228F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // SANBAYTG
            // 
            this.SANBAYTG.FillWeight = 99.49239F;
            this.SANBAYTG.HeaderText = "Sân bay trung gian";
            this.SANBAYTG.Name = "SANBAYTG";
            this.SANBAYTG.Width = 195;
            // 
            // THOIGIANDUNG
            // 
            this.THOIGIANDUNG.FillWeight = 99.49239F;
            this.THOIGIANDUNG.HeaderText = "Thời gian dừng";
            this.THOIGIANDUNG.Name = "THOIGIANDUNG";
            this.THOIGIANDUNG.Width = 122;
            // 
            // GHICHU
            // 
            this.GHICHU.FillWeight = 99.49239F;
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Width = 199;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 58);
            this.panel1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button_xoa_sb_tg);
            this.groupBox2.Controls.Add(this.label_ghichu_note);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox_note_ghichu);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label_note);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox_thoigiandung);
            this.groupBox2.Controls.Add(this.button_them_sb_tg);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox_sb_trung_gian);
            this.groupBox2.Controls.Add(this.dataGridView_sbtrunggian);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(503, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 341);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sân bay trung gian";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_xoa_sb_tg
            // 
            this.button_xoa_sb_tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa_sb_tg.ForeColor = System.Drawing.Color.Black;
            this.button_xoa_sb_tg.Location = new System.Drawing.Point(510, 75);
            this.button_xoa_sb_tg.Name = "button_xoa_sb_tg";
            this.button_xoa_sb_tg.Size = new System.Drawing.Size(75, 27);
            this.button_xoa_sb_tg.TabIndex = 36;
            this.button_xoa_sb_tg.Text = "Xóa";
            this.button_xoa_sb_tg.UseVisualStyleBackColor = true;
            this.button_xoa_sb_tg.Click += new System.EventHandler(this.button_xoa_sb_tg_Click);
            // 
            // label_ghichu_note
            // 
            this.label_ghichu_note.BackColor = System.Drawing.Color.Transparent;
            this.label_ghichu_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ghichu_note.Location = new System.Drawing.Point(97, 111);
            this.label_ghichu_note.Name = "label_ghichu_note";
            this.label_ghichu_note.Size = new System.Drawing.Size(362, 20);
            this.label_ghichu_note.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(23, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Ghi chú:";
            // 
            // textBox_note_ghichu
            // 
            this.textBox_note_ghichu.BackColor = System.Drawing.Color.White;
            this.textBox_note_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_note_ghichu.ForeColor = System.Drawing.Color.Black;
            this.textBox_note_ghichu.Location = new System.Drawing.Point(27, 133);
            this.textBox_note_ghichu.MaxLength = 100;
            this.textBox_note_ghichu.Name = "textBox_note_ghichu";
            this.textBox_note_ghichu.Size = new System.Drawing.Size(567, 26);
            this.textBox_note_ghichu.TabIndex = 33;
            this.textBox_note_ghichu.TextChanged += new System.EventHandler(this.textBox_note_ghichu_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(341, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Phút";
            // 
            // label_note
            // 
            this.label_note.BackColor = System.Drawing.Color.Transparent;
            this.label_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_note.Location = new System.Drawing.Point(9, 26);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(585, 20);
            this.label_note.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(220, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Thời gian dừng:";
            // 
            // textBox_thoigiandung
            // 
            this.textBox_thoigiandung.BackColor = System.Drawing.Color.White;
            this.textBox_thoigiandung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_thoigiandung.ForeColor = System.Drawing.Color.Black;
            this.textBox_thoigiandung.Location = new System.Drawing.Point(224, 76);
            this.textBox_thoigiandung.Name = "textBox_thoigiandung";
            this.textBox_thoigiandung.Size = new System.Drawing.Size(111, 26);
            this.textBox_thoigiandung.TabIndex = 29;
            this.textBox_thoigiandung.TextChanged += new System.EventHandler(this.textBox_thoigiandung_TextChanged);
            this.textBox_thoigiandung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_thoigiandung_KeyPress);
            // 
            // button_them_sb_tg
            // 
            this.button_them_sb_tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_sb_tg.ForeColor = System.Drawing.Color.Black;
            this.button_them_sb_tg.Location = new System.Drawing.Point(418, 76);
            this.button_them_sb_tg.Name = "button_them_sb_tg";
            this.button_them_sb_tg.Size = new System.Drawing.Size(75, 27);
            this.button_them_sb_tg.TabIndex = 20;
            this.button_them_sb_tg.Text = "Thêm";
            this.button_them_sb_tg.UseVisualStyleBackColor = true;
            this.button_them_sb_tg.Click += new System.EventHandler(this.button_them_sb_tg_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Chọn sân bay trung gian:";
            // 
            // comboBox_sb_trung_gian
            // 
            this.comboBox_sb_trung_gian.BackColor = System.Drawing.Color.White;
            this.comboBox_sb_trung_gian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sb_trung_gian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_sb_trung_gian.FormattingEnabled = true;
            this.comboBox_sb_trung_gian.Location = new System.Drawing.Point(27, 75);
            this.comboBox_sb_trung_gian.Name = "comboBox_sb_trung_gian";
            this.comboBox_sb_trung_gian.Size = new System.Drawing.Size(183, 28);
            this.comboBox_sb_trung_gian.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button_xoa_hangghe);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox_slghe);
            this.groupBox3.Controls.Add(this.button_them_hv);
            this.groupBox3.Controls.Add(this.comboBox_hangve);
            this.groupBox3.Controls.Add(this.dataGridView_hangve);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(503, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 256);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hạng ghế";
            // 
            // button_xoa_hangghe
            // 
            this.button_xoa_hangghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa_hangghe.Location = new System.Drawing.Point(510, 50);
            this.button_xoa_hangghe.Name = "button_xoa_hangghe";
            this.button_xoa_hangghe.Size = new System.Drawing.Size(75, 27);
            this.button_xoa_hangghe.TabIndex = 37;
            this.button_xoa_hangghe.Text = "Xóa";
            this.button_xoa_hangghe.UseVisualStyleBackColor = true;
            this.button_xoa_hangghe.Click += new System.EventHandler(this.button_xoa_hangghe_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(341, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ghế";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(220, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Chọn hạng vé:";
            // 
            // textBox_slghe
            // 
            this.textBox_slghe.BackColor = System.Drawing.Color.White;
            this.textBox_slghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_slghe.ForeColor = System.Drawing.Color.Black;
            this.textBox_slghe.Location = new System.Drawing.Point(224, 50);
            this.textBox_slghe.Name = "textBox_slghe";
            this.textBox_slghe.Size = new System.Drawing.Size(111, 26);
            this.textBox_slghe.TabIndex = 26;
            this.textBox_slghe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // button_them_hv
            // 
            this.button_them_hv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_hv.Location = new System.Drawing.Point(418, 49);
            this.button_them_hv.Name = "button_them_hv";
            this.button_them_hv.Size = new System.Drawing.Size(75, 27);
            this.button_them_hv.TabIndex = 25;
            this.button_them_hv.Text = "Thêm";
            this.button_them_hv.UseVisualStyleBackColor = true;
            this.button_them_hv.Click += new System.EventHandler(this.button_them_hv_Click);
            // 
            // comboBox_hangve
            // 
            this.comboBox_hangve.BackColor = System.Drawing.Color.White;
            this.comboBox_hangve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hangve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_hangve.FormattingEnabled = true;
            this.comboBox_hangve.Location = new System.Drawing.Point(25, 50);
            this.comboBox_hangve.Name = "comboBox_hangve";
            this.comboBox_hangve.Size = new System.Drawing.Size(183, 28);
            this.comboBox_hangve.TabIndex = 24;
            // 
            // dataGridView_hangve
            // 
            this.dataGridView_hangve.AllowUserToAddRows = false;
            this.dataGridView_hangve.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView_hangve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hangve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon,
            this.TENHV,
            this.SLGHE});
            this.dataGridView_hangve.Location = new System.Drawing.Point(26, 86);
            this.dataGridView_hangve.Name = "dataGridView_hangve";
            this.dataGridView_hangve.RowHeadersVisible = false;
            this.dataGridView_hangve.Size = new System.Drawing.Size(567, 159);
            this.dataGridView_hangve.TabIndex = 23;
            // 
            // chon
            // 
            this.chon.FillWeight = 152.2843F;
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            this.chon.Width = 80;
            // 
            // TENHV
            // 
            this.TENHV.FillWeight = 73.85786F;
            this.TENHV.HeaderText = "Tên hạng vé";
            this.TENHV.Name = "TENHV";
            this.TENHV.Width = 300;
            // 
            // SLGHE
            // 
            this.SLGHE.FillWeight = 73.85786F;
            this.SLGHE.HeaderText = "Số lượng ghế";
            this.SLGHE.Name = "SLGHE";
            this.SLGHE.Width = 184;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.button_nhan_lich);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 495);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 172);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao tác";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(225, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "Nhận lịch";
            // 
            // button_nhan_lich
            // 
            this.button_nhan_lich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_nhan_lich.BackgroundImage")));
            this.button_nhan_lich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_nhan_lich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nhan_lich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nhan_lich.Location = new System.Drawing.Point(215, 37);
            this.button_nhan_lich.Name = "button_nhan_lich";
            this.button_nhan_lich.Size = new System.Drawing.Size(103, 65);
            this.button_nhan_lich.TabIndex = 26;
            this.button_nhan_lich.UseVisualStyleBackColor = true;
            this.button_nhan_lich.Click += new System.EventHandler(this.button_nhan_lich_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chuyến bay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá vé:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sân bay đi:";
            // 
            // textBox_macb
            // 
            this.textBox_macb.BackColor = System.Drawing.Color.White;
            this.textBox_macb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_macb.ForeColor = System.Drawing.Color.Black;
            this.textBox_macb.Location = new System.Drawing.Point(194, 39);
            this.textBox_macb.Name = "textBox_macb";
            this.textBox_macb.ReadOnly = true;
            this.textBox_macb.Size = new System.Drawing.Size(207, 26);
            this.textBox_macb.TabIndex = 11;
            // 
            // textBox_thoigianbay
            // 
            this.textBox_thoigianbay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_thoigianbay.Location = new System.Drawing.Point(194, 366);
            this.textBox_thoigianbay.Name = "textBox_thoigianbay";
            this.textBox_thoigianbay.Size = new System.Drawing.Size(119, 26);
            this.textBox_thoigianbay.TabIndex = 13;
            this.textBox_thoigianbay.TextChanged += new System.EventHandler(this.textBox_thoigianbay_TextChanged);
            this.textBox_thoigianbay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_thoigianbay_KeyPress);
            // 
            // comboBox_sbdi
            // 
            this.comboBox_sbdi.BackColor = System.Drawing.Color.White;
            this.comboBox_sbdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sbdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_sbdi.FormattingEnabled = true;
            this.comboBox_sbdi.Location = new System.Drawing.Point(194, 139);
            this.comboBox_sbdi.Name = "comboBox_sbdi";
            this.comboBox_sbdi.Size = new System.Drawing.Size(207, 28);
            this.comboBox_sbdi.TabIndex = 16;
            this.comboBox_sbdi.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sbdi_SelectionChangeCommitted);
            // 
            // comboBox_sbden
            // 
            this.comboBox_sbden.BackColor = System.Drawing.Color.White;
            this.comboBox_sbden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sbden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_sbden.FormattingEnabled = true;
            this.comboBox_sbden.Location = new System.Drawing.Point(194, 212);
            this.comboBox_sbden.Name = "comboBox_sbden";
            this.comboBox_sbden.Size = new System.Drawing.Size(207, 28);
            this.comboBox_sbden.TabIndex = 17;
            this.comboBox_sbden.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sbden_SelectionChangeCommitted);
            // 
            // dateTimePicker_ngaygio
            // 
            this.dateTimePicker_ngaygio.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePicker_ngaygio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker_ngaygio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaygio.Location = new System.Drawing.Point(194, 303);
            this.dateTimePicker_ngaygio.Name = "dateTimePicker_ngaygio";
            this.dateTimePicker_ngaygio.Size = new System.Drawing.Size(207, 26);
            this.dateTimePicker_ngaygio.TabIndex = 18;
            this.dateTimePicker_ngaygio.ValueChanged += new System.EventHandler(this.dateTimePicker_ngaygio_ValueChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(413, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "VNĐ";
            // 
            // comboBox_giave
            // 
            this.comboBox_giave.BackColor = System.Drawing.Color.White;
            this.comboBox_giave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_giave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_giave.FormattingEnabled = true;
            this.comboBox_giave.Location = new System.Drawing.Point(194, 88);
            this.comboBox_giave.Name = "comboBox_giave";
            this.comboBox_giave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_giave.Size = new System.Drawing.Size(207, 28);
            this.comboBox_giave.TabIndex = 22;
            // 
            // button_swap
            // 
            this.button_swap.BackColor = System.Drawing.Color.Transparent;
            this.button_swap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_swap.BackgroundImage")));
            this.button_swap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_swap.Location = new System.Drawing.Point(427, 163);
            this.button_swap.Name = "button_swap";
            this.button_swap.Size = new System.Drawing.Size(40, 50);
            this.button_swap.TabIndex = 36;
            this.button_swap.UseVisualStyleBackColor = false;
            this.button_swap.Click += new System.EventHandler(this.button_swap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_swap);
            this.groupBox1.Controls.Add(this.label_tuyenbay_khadung);
            this.groupBox1.Controls.Add(this.pictureBox_check);
            this.groupBox1.Controls.Add(this.label_note_check2sb);
            this.groupBox1.Controls.Add(this.label_note_tgbay);
            this.groupBox1.Controls.Add(this.comboBox_giave);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker_ngaygio);
            this.groupBox1.Controls.Add(this.comboBox_sbden);
            this.groupBox1.Controls.Add(this.comboBox_sbdi);
            this.groupBox1.Controls.Add(this.textBox_thoigianbay);
            this.groupBox1.Controls.Add(this.textBox_macb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 425);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label_tuyenbay_khadung
            // 
            this.label_tuyenbay_khadung.BackColor = System.Drawing.Color.Transparent;
            this.label_tuyenbay_khadung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tuyenbay_khadung.ForeColor = System.Drawing.Color.White;
            this.label_tuyenbay_khadung.Location = new System.Drawing.Point(191, 263);
            this.label_tuyenbay_khadung.Name = "label_tuyenbay_khadung";
            this.label_tuyenbay_khadung.Size = new System.Drawing.Size(259, 25);
            this.label_tuyenbay_khadung.TabIndex = 35;
            // 
            // pictureBox_check
            // 
            this.pictureBox_check.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_check.Location = new System.Drawing.Point(133, 240);
            this.pictureBox_check.Name = "pictureBox_check";
            this.pictureBox_check.Size = new System.Drawing.Size(50, 51);
            this.pictureBox_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_check.TabIndex = 34;
            this.pictureBox_check.TabStop = false;
            // 
            // label_note_check2sb
            // 
            this.label_note_check2sb.BackColor = System.Drawing.Color.Transparent;
            this.label_note_check2sb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_note_check2sb.Location = new System.Drawing.Point(187, 180);
            this.label_note_check2sb.Name = "label_note_check2sb";
            this.label_note_check2sb.Size = new System.Drawing.Size(231, 20);
            this.label_note_check2sb.TabIndex = 33;
            this.label_note_check2sb.Visible = false;
            // 
            // label_note_tgbay
            // 
            this.label_note_tgbay.BackColor = System.Drawing.Color.Transparent;
            this.label_note_tgbay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_note_tgbay.ForeColor = System.Drawing.Color.White;
            this.label_note_tgbay.Location = new System.Drawing.Point(169, 337);
            this.label_note_tgbay.Name = "label_note_tgbay";
            this.label_note_tgbay.Size = new System.Drawing.Size(298, 20);
            this.label_note_tgbay.TabIndex = 32;
            this.label_note_tgbay.Click += new System.EventHandler(this.label_note_tgbay_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(319, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Phút";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời gian bay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày giờ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sân bay đến:";
            // 
            // NhanLichChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBVMB.Properties.Resources.flight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 701);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NhanLichChuyenBay";
            this.Text = "Nhận lịch chuyến bay";
            this.Load += new System.EventHandler(this.NhanLichChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sbtrunggian)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hangve)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_check)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_sbtrunggian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_them_sb_tg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_sb_trung_gian;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_slghe;
        private System.Windows.Forms.Button button_them_hv;
        private System.Windows.Forms.ComboBox comboBox_hangve;
        private System.Windows.Forms.DataGridView dataGridView_hangve;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_nhan_lich;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_thoigiandung;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_note_ghichu;
        private System.Windows.Forms.Label label_ghichu_note;
        private System.Windows.Forms.Button button_xoa_sb_tg;
        private System.Windows.Forms.Button button_xoa_hangghe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLGHE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SANBAYTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_macb;
        private System.Windows.Forms.TextBox textBox_thoigianbay;
        private System.Windows.Forms.ComboBox comboBox_sbdi;
        private System.Windows.Forms.ComboBox comboBox_sbden;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaygio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_giave;
        private System.Windows.Forms.Button button_swap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_tuyenbay_khadung;
        private System.Windows.Forms.PictureBox pictureBox_check;
        private System.Windows.Forms.Label label_note_check2sb;
        private System.Windows.Forms.Label label_note_tgbay;
    }
}