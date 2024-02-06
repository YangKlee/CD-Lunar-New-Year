namespace Lunar_New_Year_Cowndown
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.quit_bt = new System.Windows.Forms.Label();
            this.title_tx = new System.Windows.Forms.Label();
            this.title2_tx = new System.Windows.Forms.Label();
            this.remaning_tx = new System.Windows.Forms.Label();
            this.time_pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.day_tx = new System.Windows.Forms.Label();
            this.sec_num = new System.Windows.Forms.Label();
            this.min_num = new System.Windows.Forms.Label();
            this.haicham = new System.Windows.Forms.Label();
            this.hour_num = new System.Windows.Forms.Label();
            this.day_num = new System.Windows.Forms.Label();
            this.loichuc_tx = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.getupdate = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.time_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // quit_bt
            // 
            this.quit_bt.AutoSize = true;
            this.quit_bt.BackColor = System.Drawing.Color.Transparent;
            this.quit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_bt.ForeColor = System.Drawing.Color.Bisque;
            this.quit_bt.Location = new System.Drawing.Point(576, 3);
            this.quit_bt.Name = "quit_bt";
            this.quit_bt.Size = new System.Drawing.Size(27, 25);
            this.quit_bt.TabIndex = 0;
            this.quit_bt.Text = "X";
            this.quit_bt.Click += new System.EventHandler(this.quit_bt_Click);
            // 
            // title_tx
            // 
            this.title_tx.BackColor = System.Drawing.Color.Transparent;
            this.title_tx.Font = new System.Drawing.Font("SVN-Bree", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tx.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.title_tx.Location = new System.Drawing.Point(0, 11);
            this.title_tx.Name = "title_tx";
            this.title_tx.Size = new System.Drawing.Size(603, 43);
            this.title_tx.TabIndex = 1;
            this.title_tx.Text = "ĐẾM NGƯỢC TẾT NGUYÊN ĐÁN 2024";
            this.title_tx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // title2_tx
            // 
            this.title2_tx.BackColor = System.Drawing.Color.Transparent;
            this.title2_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2_tx.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.title2_tx.Location = new System.Drawing.Point(1, 54);
            this.title2_tx.Name = "title2_tx";
            this.title2_tx.Size = new System.Drawing.Size(602, 23);
            this.title2_tx.TabIndex = 2;
            this.title2_tx.Text = "-TẾT GIÁP THÌN-";
            this.title2_tx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // remaning_tx
            // 
            this.remaning_tx.BackColor = System.Drawing.Color.Transparent;
            this.remaning_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaning_tx.ForeColor = System.Drawing.Color.BurlyWood;
            this.remaning_tx.Location = new System.Drawing.Point(1, 90);
            this.remaning_tx.Name = "remaning_tx";
            this.remaning_tx.Size = new System.Drawing.Size(602, 29);
            this.remaning_tx.TabIndex = 3;
            this.remaning_tx.Text = "Thời gian còn lại:";
            this.remaning_tx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_pn
            // 
            this.time_pn.BackColor = System.Drawing.Color.Transparent;
            this.time_pn.Controls.Add(this.label1);
            this.time_pn.Controls.Add(this.label6);
            this.time_pn.Controls.Add(this.label4);
            this.time_pn.Controls.Add(this.label2);
            this.time_pn.Controls.Add(this.day_tx);
            this.time_pn.Controls.Add(this.sec_num);
            this.time_pn.Controls.Add(this.min_num);
            this.time_pn.Controls.Add(this.haicham);
            this.time_pn.Controls.Add(this.hour_num);
            this.time_pn.Controls.Add(this.day_num);
            this.time_pn.Location = new System.Drawing.Point(1, 109);
            this.time_pn.Name = "time_pn";
            this.time_pn.Size = new System.Drawing.Size(602, 131);
            this.time_pn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(414, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(471, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(346, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phút";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(227, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giờ";
            // 
            // day_tx
            // 
            this.day_tx.AutoSize = true;
            this.day_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_tx.ForeColor = System.Drawing.Color.BurlyWood;
            this.day_tx.Location = new System.Drawing.Point(74, 97);
            this.day_tx.Name = "day_tx";
            this.day_tx.Size = new System.Drawing.Size(73, 29);
            this.day_tx.TabIndex = 1;
            this.day_tx.Text = "Ngày";
            // 
            // sec_num
            // 
            this.sec_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec_num.ForeColor = System.Drawing.Color.BurlyWood;
            this.sec_num.Location = new System.Drawing.Point(441, 22);
            this.sec_num.Name = "sec_num";
            this.sec_num.Size = new System.Drawing.Size(119, 76);
            this.sec_num.TabIndex = 0;
            this.sec_num.Text = "00";
            this.sec_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // min_num
            // 
            this.min_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_num.ForeColor = System.Drawing.Color.BurlyWood;
            this.min_num.Location = new System.Drawing.Point(316, 22);
            this.min_num.Name = "min_num";
            this.min_num.Size = new System.Drawing.Size(119, 76);
            this.min_num.TabIndex = 0;
            this.min_num.Text = "00";
            this.min_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // haicham
            // 
            this.haicham.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haicham.ForeColor = System.Drawing.Color.BurlyWood;
            this.haicham.Location = new System.Drawing.Point(289, 5);
            this.haicham.Name = "haicham";
            this.haicham.Size = new System.Drawing.Size(40, 108);
            this.haicham.TabIndex = 0;
            this.haicham.Text = ":";
            this.haicham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_num
            // 
            this.hour_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_num.ForeColor = System.Drawing.Color.BurlyWood;
            this.hour_num.Location = new System.Drawing.Point(191, 22);
            this.hour_num.Name = "hour_num";
            this.hour_num.Size = new System.Drawing.Size(119, 76);
            this.hour_num.TabIndex = 0;
            this.hour_num.Text = "00";
            this.hour_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // day_num
            // 
            this.day_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_num.ForeColor = System.Drawing.Color.BurlyWood;
            this.day_num.Location = new System.Drawing.Point(41, 4);
            this.day_num.Name = "day_num";
            this.day_num.Size = new System.Drawing.Size(140, 91);
            this.day_num.TabIndex = 0;
            this.day_num.Text = "00";
            // 
            // loichuc_tx
            // 
            this.loichuc_tx.BackColor = System.Drawing.Color.Transparent;
            this.loichuc_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loichuc_tx.ForeColor = System.Drawing.Color.BurlyWood;
            this.loichuc_tx.Location = new System.Drawing.Point(4, 243);
            this.loichuc_tx.Name = "loichuc_tx";
            this.loichuc_tx.Size = new System.Drawing.Size(602, 44);
            this.loichuc_tx.TabIndex = 5;
            this.loichuc_tx.Text = "loichuc_tx";
            this.loichuc_tx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loichuc_tx.Click += new System.EventHandler(this.loichuc_tx_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // getupdate
            // 
            this.getupdate.Interval = 5000;
            this.getupdate.Tick += new System.EventHandler(this.getupdate_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.Brown;
            this.checkBox1.Location = new System.Drawing.Point(544, 311);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Tắt âm";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(4, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "@YangKlee2024 Rel 1.0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.ForeColor = System.Drawing.Color.Brown;
            this.checkBox2.Location = new System.Drawing.Point(463, 311);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Trên cùng";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 330);
            this.Controls.Add(this.remaning_tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.loichuc_tx);
            this.Controls.Add(this.time_pn);
            this.Controls.Add(this.title2_tx);
            this.Controls.Add(this.quit_bt);
            this.Controls.Add(this.title_tx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dem nguoc nam moi";
            this.Load += new System.EventHandler(this.loadform);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.time_pn.ResumeLayout(false);
            this.time_pn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quit_bt;
        private System.Windows.Forms.Label title_tx;
        private System.Windows.Forms.Label title2_tx;
        private System.Windows.Forms.Label remaning_tx;
        private System.Windows.Forms.Panel time_pn;
        private System.Windows.Forms.Label day_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label day_tx;
        private System.Windows.Forms.Label hour_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sec_num;
        private System.Windows.Forms.Label min_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label haicham;
        private System.Windows.Forms.Label loichuc_tx;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer getupdate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

