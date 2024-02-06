using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;



namespace Lunar_New_Year_Cowndown
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        bool mouse_down;
        private Point offset;
        // hh,mm,ss - dd/mm/yyyy - set time in arrays
        int[] remaning_time = {00,00,00,00,00,00};
        int[] current_time = { 00, 00, 00, 00, 00, 00 };
        int[] target_time = { 00, 00, 00, 10, 02, 2024 };
        int debug_mode = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouse_down == true)
            {
                Point currentSceenPos = PointToScreen(e.Location);
                Location = new Point(currentSceenPos.X - offset.X, currentSceenPos.Y - offset.Y);

            }
        }
        private void update_time()
        {
            
            if (debug_mode == 1)
            {
                current_time[0] = 01;
                current_time[1] = 00;
                current_time[2] = 00;
                current_time[3] = 01;
                current_time[4] = 02;
                current_time[5] = 00;
            }
            else if (debug_mode == 0) 
            {
                DateTime rawTime = DateTime.Now;
                current_time[0] = rawTime.Hour;
                current_time[1] = rawTime.Minute;
                current_time[2] = rawTime.Second;
                current_time[3] = rawTime.Day;
                current_time[4] = rawTime.Month;
                current_time[5] = rawTime.Year;
                
            }
            caluate_time();


        }
        private void caluate_time()
        {

            if (debug_mode == 2) 
            {
                remaning_time[0] = 00;
                remaning_time[1] = 00;
                remaning_time[2] = 5;
                remaning_time[3] = 01;
                remaning_time[4] = 00;
                current_time[5] = 00;

            }
            else if(debug_mode == 0)
            {
                remaning_time[5] = current_time[5] - target_time[5];
                remaning_time[4] = target_time[4] - current_time[4];
                int tichluythang = 31 * remaning_time[4];
                remaning_time[3] = target_time[3] - current_time[3] + tichluythang - 1;
                remaning_time[0] = target_time[0] - current_time[0] + 24 - 1;
                remaning_time[1] = target_time[1] - current_time[1] + 60 - 1;
                remaning_time[2] = target_time[2] - current_time[2] + 60 - 1;
            }

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouse_down = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private void quit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            remaning_time[2]--;
            if (remaning_time[2] < 0)
            {
                remaning_time[1]--;
                remaning_time[2] = 59;
            }
            if (remaning_time[1] < 0)
            {
                remaning_time[0]--;
                remaning_time[1] = 59;
                remaning_time[2] = 59;
            }
            if (remaning_time[0] < 0)
            {
                
                remaning_time[3]--;
                remaning_time[1] = 59;
                remaning_time[2] = 59;
                remaning_time[0] = 23;
                config_ui(1);
            }
            if (remaning_time[0] == 0 && remaning_time[1] == 0 && remaning_time[2] == 0 && remaning_time[3] == 0)
            {
                happy_new_year();
            }


            if (remaning_time[3] < 10)
            {
                day_num.Text = "0" + remaning_time[3].ToString();
            }
            else
            {
                day_num.Text = remaning_time[3].ToString();
            }
            
            if (remaning_time[0] < 10)
            {
                hour_num.Text = "0" + remaning_time[0].ToString();
            }
            else
            {
                hour_num.Text = remaning_time[0].ToString();
            }

            if (remaning_time[1] < 10)
            {
                min_num.Text = "0" + remaning_time[1].ToString();
            }
            else
            {
                min_num.Text = remaning_time[1].ToString();
            }

            if (remaning_time[2] < 10)
            {
                sec_num.Text = "0" + remaning_time[2].ToString();
            }
            else
            {
                sec_num.Text = remaning_time[2].ToString();
            }

        }
        private void config_ui(int ui_mode)
        {
            if(ui_mode == 1)
            {
                if (remaning_time[3] == 0)
                {
                    day_num.Visible = false;
                    day_tx.Visible = false;
                    time_pn.Location = new Point(-66, 109);
                    title2_tx.Text = "-30 TẾT-";
                }
            }
            else if(ui_mode == 2)
            {
                if (current_time[3] - target_time[3] == 0)
                {
                    // mong mot tet
                    title2_tx.Text = "-Mồng một tết-";
                }
                else if (current_time[3] - target_time[3] == 1)
                {
                    // mong hai tet
                    title2_tx.Text = "-Mồng hai tết-";
                }
                else if (current_time[3] - target_time[3] == 2)
                {
                    //mong ba tet
                    title2_tx.Text = "-Mồng ba tết-";
                }

            }


        }
        private void happy_new_year()
        {
            timer.Enabled = false;
            getupdate.Enabled = false;
            checkBox1.Checked = true;
            var myForm = new Form2();
            myForm.Show();

        }
        private void load_slogan()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 7);
            string[] slogan = { "Tính sương sương còn " + (remaning_time[2] + (remaning_time[1] + (remaning_time[0]+ remaning_time[3]*24) * 60) * 60).ToString() + " giây nữa là tới giao thừa", "Fix bug trầm cảm!", "Mong 4.4 ra trấn nahida!", 
                "Tết như l, bố m ghét tết" , "Klee & Nahida so cutee <3", "Tết như đb năm nào cũng như nhau", "App có lỗi j tự chịu nha, lười fix quá"};
            loichuc_tx.Text = slogan[randomNumber];
        }
        private void playbgm(bool playing)
        {
            int last_random, randomNumber;
            do
            {
                Random random = new Random();
                randomNumber = random.Next(1, 8);
                last_random = randomNumber;
            }
            while (last_random != randomNumber);
            //int randomNumber = 3;
            SoundPlayer simpleSound = new SoundPlayer(@"res/music/"+ randomNumber.ToString() +".wav");
            if (playing)
            {
                simpleSound.PlayLooping();

            }
            else
            {
                simpleSound.Stop();
            }

        }
        private void loadform(object sender, EventArgs e)
        {

            loichuc_tx.Text = "Đang đồng bộ thời gian!";
            update_time();

            config_ui(1);
            playbgm(true);
            if (current_time[3] < target_time[3])
            {
                timer.Enabled = true;
                getupdate.Enabled = true;
                timer.Interval = 1000; // 1 sec
                getupdate.Interval = 120000;

            }
            else
            { 
                timer.Enabled = false;
                getupdate.Enabled = false;  
                config_ui(2);

            }
            load_slogan();

        }

        private void getupdate_Tick(object sender, EventArgs e)
        {
            update_time();
            load_slogan();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                playbgm(false);
            }
            else
            {
                playbgm(true);
            }
        }

        private void loichuc_tx_Click(object sender, EventArgs e)
        {
            load_slogan();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Sản phẩm này thuộc bản quyền của @YangKlee\nĐể có trải nghiệm tốt nhất vui lòng cài và cập nhật đầy đủ bộ Net Famework và bộ font SVN\nỨng dụng này chỉ tương thích với win 10 trở lên. Thanks!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (MessageBox.Show(
        "Sản phẩm này thuộc bản quyền của @YangKlee\nĐể có trải nghiệm tốt nhất vui lòng cài và cập nhật đầy đủ bộ Net Famework và bộ font SVN\nỨng dụng này chỉ tương thích với win 10 trở lên.Thanks!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
    ) == DialogResult.Yes)
            {
                checkBox1.Checked = true;
                this.TopMost = false;
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=na9NpToMFkY");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost= false;
            }
        }
    }
}
