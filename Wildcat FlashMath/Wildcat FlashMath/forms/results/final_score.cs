using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Wildcat_FlashMath
{
    public partial class final_score : Form
    {
        public double time;
        public string user;
        public int score;
        public string grade;
        public int score_percent;
        public List<string> problem_list;
        private string lessons;

        problem_select_test select = new problem_select_test();

        public final_score()
        {
            InitializeComponent();
        }

        public void send_email()
        {
            try
            {

            string save_file = "Date:" + DateTime.Today.Year + "-" + DateTime.Today.Day + "-" +
                               DateTime.Today.Month +
                               Environment.NewLine
                               + "Name: " + user + Environment.NewLine + "Grade: " + grade +
                               Environment.NewLine +
                               "Score: " + score_percent + "%" + Environment.NewLine + "Time: " +
                               time.ToString() + "seconds"
                               + Environment.NewLine + "Lessons: ";

            save_file = save_file.Remove(save_file.Length - 1);

            foreach (string name in problem_list)
            {
                switch (name)
                {
                    case "add":
                        save_file += "addition, ";
                        break;
                    case "sub":
                        save_file += "subtraction, ";
                        break;
                    case "money":
                        save_file += "counting money, ";
                        break;
                    case "time":
                        save_file += "telling time, ";
                        break;
                    case "fractions":
                        save_file += "fractions, ";
                        break;
                    case "div":
                        save_file += "division, ";
                        break;
                    case "multi":
                        save_file += "multiplication, ";
                        break;
                    case "order":
                        save_file += "order of operations, ";
                        break;
                    case "decimals":
                        save_file += "decimals, ";
                        break;
                    case "word":
                        save_file += "word problems, ";
                        break;
                    case "measurments":
                        save_file += "measurments, ";
                        break;
                    default:
                        save_file += name + ", ";
                        break;
                }
            }
            save_file = save_file.Remove(save_file.Length - 2);


                var fromAddress = new MailAddress("wildcatflashmath@gmail.com");
                var toAddress = new MailAddress(Properties.Settings.Default.email);
                const string fromPassword = "WildcatFlashmathPassword1595";
                string subject = DateTime.Today.Date.ToString() + " " + user + " report";
                string body = save_file;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }


        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public void SetAllControlsFont(Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    SetAllControlsFont(ctrl.Controls);
                ctrl.Margin = new Padding(0, 0, 0, 0);
                if (Screen.PrimaryScreen.Bounds.Width < 1400)
                {
                    ctrl.Font = new Font("Impact", ctrl.Font.Size / 2);
                    if (Screen.PrimaryScreen.Bounds.Width < 1000)
                    {
                        ctrl.Font = new Font("Impact", ctrl.Font.Size / 4);
                        ctrl.Font = new Font("Impact", ctrl.Font.Size * 3);

                    }
                }

            }
        }

        private void final_score_Load(object sender, EventArgs e)
        {
            SetAllControlsFont(tableLayoutPanel1.Controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;
            button1.FlatAppearance.BorderSize = 0;

            label5.Text = user;
            label6.Text = grade;

            int tm = Convert.ToInt32(time);
            if (tm > 60)
            {
                int tm_min = tm / 60;
                int tm_sec = tm - tm_min * 60;
                string tm_full = tm_min.ToString() +" Minutes "+ Environment.NewLine + tm_sec + " seconds";
                label7.Text = tm_full;
            }
            else
            {
                label7.Text = time.ToString("0.0") + " Seconds";

            }

            score_percent = score * 5;
            label9.Text = score_percent + "%";

            if (score_percent < 80)
            {
                pictureBox1.Image = Wildcat_FlashMath.Properties.Resources.needs_improvement_jpg;
            }
            
            @select.CreateControl();
            @select.CreateGraphics();

            foreach (string name in problem_list)
            {
                switch (name)
                {
                    case "add":
                        lessons += "addition, ";
                        break;
                    case "sub":
                        lessons += "subtraction, ";
                        break;
                    case "money":
                        lessons += "counting money, ";
                        break;
                    case "time":
                        lessons += "telling time, ";
                        break;
                    case "fractions":
                        lessons += "fractions, ";
                        break;
                    case "div":
                        lessons += "division, ";
                        break;
                    case "multi":
                        lessons += "multiplication, ";
                        break;
                    case "order":
                        lessons += "order of operations, ";
                        break;
                    case "decimals":
                        lessons += "decimals, ";
                        break;
                    case "word":
                        lessons += "word problems, ";
                        break;
                    case "measurments":
                        lessons += "measurments, ";
                        break;
                    default:
                        lessons += name + ", ";
                        break;
                }
            }
            lessons = lessons.Remove(lessons.Length - 2);
            label11.Text = lessons;

            send_email();
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel1.BackgroundImage == null)
            {
                return;
            }
            var bm = new Bitmap(this.tableLayoutPanel1.BackgroundImage, new Size(tableLayoutPanel1.Size.Width, tableLayoutPanel1.Height));
            tableLayoutPanel1.BackgroundImage = bm;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            main_menu main = new main_menu();
            System.Threading.Thread.Sleep(500);
            main.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        //    if (Properties.Settings.Default["save_location_test"].ToString() == "null")
        //    {
        //    saveFileDialog1.FileName = user + " " + DateTime.Today.Year + "-" + DateTime.Today.Day + "-" +
        //                               DateTime.Today.Month;
        //    saveFileDialog1.Filter = "Text (*.txt)|*.txt";
        //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            string save_file = "Date:" + DateTime.Today.Year + "-" + DateTime.Today.Day + "-" +
        //                               DateTime.Today.Month +
        //                               Environment.NewLine
        //                               + "Name: " + user + Environment.NewLine + "Grade: " + grade +
        //                               Environment.NewLine +
        //                               "Score: " + score_percent + "%" + Environment.NewLine + "Time: " +
        //                               time.ToString() + "seconds"
        //                               + Environment.NewLine + "Lessons: ";

        //            save_file = save_file.Remove(save_file.Length - 1);

        //            foreach (string name in problem_list)
        //            {
        //                switch (name)
        //                {
        //                    case "add":
        //                        save_file += "addition, ";
        //                        break;
        //                    case "sub":
        //                        save_file += "subtraction, ";
        //                        break;
        //                    case "money":
        //                        save_file += "counting money, ";
        //                        break;
        //                    case "time":
        //                        save_file += "telling time, ";
        //                        break;
        //                    case "fractions":
        //                        save_file += "fractions, ";
        //                        break;
        //                    case "div":
        //                        save_file += "division, ";
        //                        break;
        //                    case "multi":
        //                        save_file += "multiplication, ";
        //                        break;
        //                    case "order":
        //                        save_file += "order of operations, ";
        //                        break;
        //                    case "decimals":
        //                        save_file += "decimals, ";
        //                        break;
        //                    case "word":
        //                        save_file += "word problems, ";
        //                        break;
        //                    case "measurments":
        //                        save_file += "measurments, ";
        //                        break;
        //                    default:
        //                        save_file += name + ", ";
        //                        break;
        //                }
        //            }
        //            save_file = save_file.Remove(save_file.Length - 2);


        //            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
        //            sw.Write(save_file);
        //            sw.Close();
        //        }
        //    }
        //    else
        //    {
        //        saveFileDialog1.FileName = user + " " + DateTime.Today.Year + "-" + DateTime.Today.Day + "-" +
        //                                   DateTime.Today.Month;
        //        saveFileDialog1.Filter = "Text (*.txt)|*.txt";

        //        string save_file = "Date:" + DateTime.Today.Year + "-" + DateTime.Today.Day + "-" +
        //                           DateTime.Today.Month +
        //                           Environment.NewLine
        //                           + "Name: " + user + Environment.NewLine + "Grade: " + grade +
        //                           Environment.NewLine +
        //                           "Score: " + score_percent + "%" + Environment.NewLine + "Time: " +
        //                           time.ToString() + "seconds"
        //                           + Environment.NewLine + "Lessons: ";

        //        save_file = save_file.Remove(save_file.Length - 1);

        //        foreach (string name in problem_list)
        //        {
        //            switch (name)
        //            {
        //                case "add":
        //                    save_file += "addition, ";
        //                    break;
        //                case "sub":
        //                    save_file += "subtraction, ";
        //                    break;
        //                case "money":
        //                    save_file += "counting money, ";
        //                    break;
        //                case "time":
        //                    save_file += "telling time, ";
        //                    break;
        //                case "fractions":
        //                    save_file += "fractions, ";
        //                    break;
        //                case "div":
        //                    save_file += "division, ";
        //                    break;
        //                case "multi":
        //                    save_file += "multiplication, ";
        //                    break;
        //                case "order":
        //                    save_file += "order of operations, ";
        //                    break;
        //                case "decimals":
        //                    save_file += "decimals, ";
        //                    break;
        //                case "word":
        //                    save_file += "word problems, ";
        //                    break;
        //                case "measurments":
        //                    save_file += "measurments, ";
        //                    break;
        //                default:
        //                    save_file += name + ", ";
        //                    break;
        //            }
        //        }
        //        save_file = save_file.Remove(save_file.Length - 2);


        //        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
        //        sw.Write(save_file);
        //        sw.Close();

        //    }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            @select.Show();
            this.Close();
        }
    }
}
