using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Wildcat_FlashMath
{
    public partial class _1_problems : Form
    {
        public bool add;
        public bool sub;
        public bool money;
        public bool time;
        public string name;
        public List<string> problem_list = new List<string>();
        private int answer = 0;
        private int score = 0;
        private string problem_type;
        private int input;

        private string correct_answer;

        public double time_elasped = 0;

        private int number_of_questions = 0;

        private int money_answer = 0;

        private string clock_answer = "0";

        private int sub_num_1 = 0;
        private int sub_num_2 = 0;

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
                    ctrl.Font = new Font("Impact", ctrl.Font.Size / 4);
                    ctrl.Font = new Font("Impact", ctrl.Font.Size * 3);
                    if (Screen.PrimaryScreen.Bounds.Width < 1000)
                    {
                        ctrl.Font = new Font("Impact", ctrl.Font.Size / 4);
                        ctrl.Font = new Font("Impact", ctrl.Font.Size * 3);

                    }
                }

            }
        }


        private void new_problem()
        {
            Random rnd = new Random();
            answer_tb.Text = "";
            picture_answer_tb.Text = "";
            int number_selected = rnd.Next(0, problem_list.Count);
            string problem_selected = problem_list[number_selected];
            problem_type = problem_selected;
            picture_problem.Visible = false;
            picture_answer_tb.Visible = false;
            picture_answer_tb.Text = "";
            problem_itself_lb.Visible = false;
            answer_tb.Text = "";
            answer_tb.Visible = false;


            switch (problem_selected)
            {
                case "add":
                    question_lb.Text = "Add the numbers";
                    int num_1 = rnd.Next(1, 11);
                    int w8 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w8);
                    int num_2 = rnd.Next(1, 11);
                    problem_itself_lb.Visible = true;
                    problem_itself_lb.Text = num_1 + " + " + num_2 + " = ";
                    answer = num_2 + num_1;
                    answer_tb.Visible = true;
                    problem_type = "add";
                    correct_answer = answer.ToString();
                    break;

                case "sub":
                    question_lb.Text = "Subtract the numbers";
                    int nb_1 = rnd.Next(5, 10);
                    int w82 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w82);
                    int nb_2 = rnd.Next(1, 5);
                    problem_itself_lb.Visible = true;
                    answer_tb.Visible = true;
                    answer = nb_1 - nb_2;
                    problem_itself_lb.Text = nb_1 + " - " + nb_2 + " = ";
                    problem_type = "sub";
                    correct_answer = answer.ToString();
                    break;

                case "money":
                    question_lb.Text = "Add the coins";
                    picture_problem.Visible = true;
                    picture_answer_tb.Visible = true;
                    problem_type = "money";
                    picture_answer_tb.Text = "$0.00";
                    int money = 0;
                    money = rnd.Next(1, 21);
                    switch (money)
                    {
                        case 1:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_1;
                            answer = 99;
                            correct_answer = "0." + answer.ToString() + "$";
                            break;
                        case 2:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_2;
                            answer = 98;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 3:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_3;
                            answer = 97;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 4:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_4;
                            answer = 96;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 5:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_5;
                            answer = 95;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 6:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_6;
                            answer = 87;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 7:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_7;
                            answer = 86;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 8:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_8;
                            answer = 85;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 9:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_9;
                            answer = 84;
                            correct_answer = "0." + answer.ToString() + "$";
                            break;
                        case 10:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_10;
                            answer = 83;
                            correct_answer = "0." + answer.ToString() + "$";
                            break;
                        case 11:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_11;
                            answer = 81;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 12:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_12;
                            answer = 70;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 13:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_13;
                            answer = 64;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 14:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_14;
                            answer = 53;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 15:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_15;
                            answer = 48;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 16:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_16;
                            answer = 37;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 17:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_17;
                            answer = 23;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 18:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_18;
                            answer = 14;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 19:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_19;
                            answer = 12;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                        case 20:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_20;
                            answer = 4;
                            correct_answer = "0." + answer.ToString() + "$";

                            break;
                    }
                    break;

                case "time":
                    question_lb.Text = "What time is it?";
                    picture_problem.Visible = true;
                    picture_answer_tb.Visible = true;
                    problem_type = "time";
                    picture_answer_tb.Text = "hh:mm";
                    int time = 0;
                    time = rnd.Next(1, 18);
                    switch (time)
                    {
                        case 1:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_1;
                            answer = 400;
                            correct_answer = "4:00";
                            break;
                        case 2:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_2;
                            answer = 1100;
                            correct_answer = "11:00";

                            break;

                        case 3:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_3;
                            answer = 800;
                            correct_answer = "8:00";

                            break;

                        case 4:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_4;
                            answer = 700;
                            correct_answer = "7:00";

                            break;

                        case 5:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_5;
                            answer = 300;
                            correct_answer = "3:00";

                            break;

                        case 6:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_6;
                            answer = 500;
                            correct_answer = "5:00";

                            break;

                        case 7:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_7;
                            answer = 600;
                            correct_answer = "6:00";

                            break;

                        case 8:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_8;
                            answer = 1000;
                            correct_answer = "10:00";

                            break;

                        case 9:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_9;
                            answer = 100;
                            correct_answer = "1:00";

                            break;

                        case 10:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_10;
                            answer = 430;
                            correct_answer = "4:30";

                            break;

                        case 11:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_11;
                            answer = 1130;
                            correct_answer = "11:30";

                            break;

                        case 12:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_12;
                            answer = 830;
                            correct_answer = "8:30";

                            break;

                        case 13:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_13;
                            answer = 730;
                            correct_answer = "7:30";

                            break;

                        case 14:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_14;
                            answer = 330;
                            correct_answer = "3:30";

                            break;

                        case 15:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_15;
                            answer = 530;
                            correct_answer = "5:30";

                            break;

                        case 16:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_16;
                            answer = 630;
                            correct_answer = "6:30";

                            break;

                        case 17:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_17;
                            answer = 1030;
                            correct_answer = "10:30";

                            break;

                        case 18:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.clock_18;
                            answer = 130;
                            correct_answer = "1:30";
                            break;

                    }
                    break;
            }
            number_selected = 0;
        }

        public void check_input()
        {
            if (input == answer)
            {
                correct correct = new correct();
                correct.Show();
                score++;
                number_of_questions++;
                if (number_of_questions == 20)
                {

                    timer1.Enabled = false;
                    final_score final = new final_score();
                    System.Threading.Thread.Sleep(500);
                    final.grade = "1";
                    final.score = score;
                    final.time = time_elasped;
                    final.user = Form1.username;
                    final.problem_list = problem_list;
                    final.Show();
                    this.Close();
                }
                else
                {
                    new_problem();
                }
            }
            else
            {
                wrong wrong = new wrong();
                wrong.answer = correct_answer;
                wrong.Show();
                number_of_questions++;
                if (number_of_questions == 20)
                {
                    timer1.Enabled = false;
                    final_score final = new final_score();
                    System.Threading.Thread.Sleep(500);
                    final.grade = "1";
                    final.score = score;
                    final.time = time_elasped;
                    final.user = Form1.username;
                    final.problem_list = problem_list;
                    final.Show();
                    this.Close();
                }
                else
                {
                    new_problem();
                }

            }
        }



        public _1_problems()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;
        }


        private void _1_problems_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.username;
            new_problem();
            SetAllControlsFont(tableLayoutPanel1.Controls);


        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel1.BackgroundImage == null)
            {
                return;
            }
            var bm = new Bitmap(this.tableLayoutPanel1.BackgroundImage,
                new Size(tableLayoutPanel1.Size.Width, tableLayoutPanel1.Height));
            tableLayoutPanel1.BackgroundImage = bm;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            problem_select_test test = new problem_select_test();
            test.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_elasped = time_elasped + 0.1;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (problem_type == "money")
            {
                if (picture_answer_tb.Text == "" || picture_answer_tb.Text == "$0.00")
                {
                    if (MessageBox.Show(
                            "Not answering the question will count as a wrong answer." + Environment.NewLine +
                            " Are you sure you want to do that?",
                            "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        answer = 1234567890;
                        check_input();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    string ans_2 = picture_answer_tb.Text;
                    ans_2 = ans_2.Replace("$", "");
                    ans_2 = ans_2.Replace(":", "");
                    ans_2 = ans_2.Replace(".", "");
                    ans_2 = ans_2.Replace(" ", "");
                    ans_2 = ans_2.Replace(",", "");

                    if (ans_2 == "")
                    {
                        if (MessageBox.Show(
                                "Not answering the question will count as a wrong answer." + Environment.NewLine +
                                " Are you sure you want to do that?",
                                "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            answer = 1234567890;
                            check_input();

                        }
                        else
                        {
                            return;
                        }


                    }
                    else
                    {

                        input = Convert.ToInt32(ans_2);
                        check_input();
                    }
                }
            }
            else if (problem_type == "time")
            {
                if (picture_answer_tb.Text == "hh:mm" || picture_answer_tb.Text == "")
                {
                    if (MessageBox.Show(
                            "Not answering the question will count as a wrong answer." + Environment.NewLine +
                            " Are you sure you want to do that?",
                            "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        answer = 1234567890;
                        check_input();

                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    string ans = picture_answer_tb.Text;
                    ans = ans.Replace("h", "");
                    ans = ans.Replace("m", "");
                    ans = ans.Replace(":", "");
                    ans = ans.Replace(",", "");
                    if (ans == "")
                    {
                        if (picture_answer_tb.Text == "hh:mm" || picture_answer_tb.Text == "")
                        {
                            if (MessageBox.Show(
                                    "Not answering the question will count as a wrong answer." + Environment.NewLine +
                                    " Are you sure you want to do that?",
                                    "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {

                                answer = 1234567890;
                                check_input();

                            }
                            else
                            {
                                return;
                            }
                        }

                    }
                    else
                    {
                        input = Convert.ToInt32(ans);
                        check_input();
                    }

                }
            }

            else
            {
                if (answer_tb.Text == "")
                {
                    if (MessageBox.Show(
                            "Not answering the question will count as a wrong answer." + Environment.NewLine +
                            " Are you sure you want to do that?",
                            "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        answer = 1234567890;
                        check_input();

                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    input = Convert.ToInt32(answer_tb.Text);
                    check_input();
                }
            }
        }

        private void picture_answer_tb_Click(object sender, EventArgs e)
        {
            if (picture_answer_tb.Text == "hh:mm")
            {
                picture_answer_tb.Text = "";
            }
            else if (picture_answer_tb.Text == "$0.00")
            {
                picture_answer_tb.Text = "$";
            }
        }
    }
}

