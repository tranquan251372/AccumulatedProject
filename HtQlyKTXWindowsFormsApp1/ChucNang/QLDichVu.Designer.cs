namespace HtQlyKTXWindowsFormsApp1.ChucNang
{
    partial class QLDichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMadv = new System.Windows.Forms.TextBox();
            this.txtGiadien = new System.Windows.Forms.TextBox();
            this.txtGianuoc = new System.Windows.Forms.TextBox();
            this.txtDV_khac = new System.Windows.Forms.TextBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnLuuMoi = new System.Windows.Forms.Button();
            this.dgvDSDichvu = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichvu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(204, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã dịch vụ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn giá điện:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá nước";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dịch vụ khác:";
            // 
            // txtMadv
            // 
            this.txtMadv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMadv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMadv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMadv.Location = new System.Drawing.Point(188, 120);
            this.txtMadv.Multiline = true;
            this.txtMadv.Name = "txtMadv";
            this.txtMadv.Size = new System.Drawing.Size(146, 34);
            this.txtMadv.TabIndex = 2;
            // 
            // txtGiadien
            // 
            this.txtGiadien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGiadien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiadien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGiadien.Location = new System.Drawing.Point(514, 120);
            this.txtGiadien.Multiline = true;
            this.txtGiadien.Name = "txtGiadien";
            this.txtGiadien.Size = new System.Drawing.Size(146, 34);
            this.txtGiadien.TabIndex = 2;
            this.txtGiadien.Text = "0";
            this.txtGiadien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiadien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiadien_KeyPress);
            // 
            // txtGianuoc
            // 
            this.txtGianuoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGianuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGianuoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGianuoc.Location = new System.Drawing.Point(188, 217);
            this.txtGianuoc.Multiline = true;
            this.txtGianuoc.Name = "txtGianuoc";
            this.txtGianuoc.Size = new System.Drawing.Size(146, 34);
            this.txtGianuoc.TabIndex = 2;
            this.txtGianuoc.Text = "0";
            this.txtGianuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGianuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGianuoc_KeyPress);
            // 
            // txtDV_khac
            // 
            this.txtDV_khac.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDV_khac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDV_khac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDV_khac.Location = new System.Drawing.Point(514, 213);
            this.txtDV_khac.Multiline = true;
            this.txtDV_khac.Name = "txtDV_khac";
            this.txtDV_khac.Size = new System.Drawing.Size(146, 34);
            this.txtDV_khac.TabIndex = 2;
            this.txtDV_khac.Text = "0";
            this.txtDV_khac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDV_khac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDV_khac_KeyPress);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemDV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemDV.Location = new System.Drawing.Point(392, 303);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(82, 30);
            this.btnThemDV.TabIndex = 3;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaDV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDV.Location = new System.Drawing.Point(500, 303);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(82, 30);
            this.btnSuaDV.TabIndex = 3;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.UseVisualStyleBackColor = false;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnLuuMoi
            // 
            this.btnLuuMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuMoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuMoi.Location = new System.Drawing.Point(603, 303);
            this.btnLuuMoi.Name = "btnLuuMoi";
            this.btnLuuMoi.Size = new System.Drawing.Size(86, 30);
            this.btnLuuMoi.TabIndex = 3;
            this.btnLuuMoi.Text = "Lưu";
            this.btnLuuMoi.UseVisualStyleBackColor = false;
            this.btnLuuMoi.Click += new System.EventHandler(this.btnLuuMoi_Click);
            // 
            // dgvDSDichvu
            // 
            this.dgvDSDichvu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSDichvu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSDichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDichvu.Location = new System.Drawing.Point(-2, 365);
            this.dgvDSDichvu.MultiSelect = false;
            this.dgvDSDichvu.Name = "dgvDSDichvu";
            this.dgvDSDichvu.RowHeadersWidth = 51;
            this.dgvDSDichvu.RowTemplate.Height = 24;
            this.dgvDSDichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDichvu.Size = new System.Drawing.Size(804, 150);
            this.dgvDSDichvu.TabIndex = 4;
            this.dgvDSDichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDichvu_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(695, 303);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 1);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 1);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 252);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 1);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(514, 251);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 1);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 184);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // QLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvDSDichvu);
            this.Controls.Add(this.btnLuuMoi);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.txtDV_khac);
            this.Controls.Add(this.txtGianuoc);
            this.Controls.Add(this.txtGiadien);
            this.Controls.Add(this.txtMadv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "QLDichVu";
            this.Text = "QLDichVu";
            this.Load += new System.EventHandler(this.QLDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichvu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMadv;
        private System.Windows.Forms.TextBox txtGiadien;
        private System.Windows.Forms.TextBox txtGianuoc;
        private System.Windows.Forms.TextBox txtDV_khac;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnLuuMoi;
        private System.Windows.Forms.DataGridView dgvDSDichvu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}