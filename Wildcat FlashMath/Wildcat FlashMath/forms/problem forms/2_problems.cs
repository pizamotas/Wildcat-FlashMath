using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wildcat_FlashMath
{
    public partial class _2_problems : Form
    {
        //the right answer to the problem to compare the input to
        public string answer = "";
        public List<string> problem_list = new List<string>();
        private int score = 0;
        public double time_elasped = 0;
        private int number_of_questions = 0;
        public string name;
        int number_1;
        int number_2;
        private string problem_type;
        private string input;

        private string correct_answer;
        private string correct_ans_bot;

        private bool next_clicked_first_time = false;
        private bool picture_problem_yes;


        //panaikina flickeringa (kazkodel) bet nerodo formos kol loadina todel reikia po apacia ka nors apdet kad nerodytu tuscio ekrano
        //nuo cia
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
        //iki cia
        public void SetAllControlsFont(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                ctrl.Margin = new Padding(0,0,0,0);
            }
        }



        public void new_problem()
        {
            answer_tb.Text = "";
            picture_answer_tb.Text = "";
            Random rnd = new Random();
            int number_selected = rnd.Next(0, problem_list.Count);
            string problem_selected = problem_list[number_selected];
            problem_type = problem_selected;

            switch (problem_selected)
            {
                case "add":
                    question_lb.Text = "Add the numbers";
                    picture_answer_tb.Visible = false;
                    picture_problem.Visible = false;
                    answer_tb.Visible = true;
                    problem_itself_lb.Visible = true;

                    Halves.Visible = false;
                    Thirds.Visible = false;
                    six_btn.Visible = false;
                    quarter_btn.Visible = false;
                    eight_btn.Visible = false;
                    next_btn.Visible = true;

                    int add_1_10;
                    add_1_10 = rnd.Next(1, 3);
                    if (add_1_10 == 1)
                    {
                        number_1 = rnd.Next(1, 99);
                        int w8 = rnd.Next(1, 100);
                        System.Threading.Thread.Sleep(w8);
                        number_2 = rnd.Next(1, 99);

                        int num_1 = number_1 * 10;
                        int num_2 = number_2 * 10;

                        problem_itself_lb.Text = num_1 + " + " + num_2 + " = ";
                        answer = Convert.ToString(num_1 + num_2);
                    }
                    else
                    {
                        number_1 = rnd.Next(1, 99);
                        int w8 = rnd.Next(1, 100);
                        System.Threading.Thread.Sleep(w8);
                        number_2 = rnd.Next(1, 99);


                        problem_itself_lb.Text = number_1 + " + " + number_2 + " = ";
                        answer = Convert.ToString(number_1 + number_2);
                    }
                    correct_answer = answer;
                    picture_problem_yes = false;
                    break;

                case "sub":
                    question_lb.Text = "Subtract the numbers";
                    picture_answer_tb.Visible = false;
                    picture_problem.Visible = false;
                    answer_tb.Visible = true;
                    problem_itself_lb.Visible = true;
                    Halves.Visible = false;
                    Thirds.Visible = false;
                    six_btn.Visible = false;
                    quarter_btn.Visible = false;
                    eight_btn.Visible = false;
                    next_btn.Visible = true;

                    int sub;
                    sub = rnd.Next(1, 3);

                    if (sub == 1)
                    {
                        number_1 = rnd.Next(50, 99);
                        int w8 = rnd.Next(1, 100);
                        System.Threading.Thread.Sleep(w8);
                        number_2 = rnd.Next(1, 50);

                        int num_1 = number_1 * 10;
                        int num_2 = number_2 * 10;

                        problem_itself_lb.Text = num_1 + " - " + num_2 + " = ";
                        answer = Convert.ToString(num_1 - num_2);

                    }
                    else
                    {
                        number_1 = rnd.Next(50, 99);
                        int w8 = rnd.Next(1, 100);
                        System.Threading.Thread.Sleep(w8);
                        number_2 = rnd.Next(1, 50);


                        problem_itself_lb.Text = number_1 + " - " + number_2 + " = ";
                        answer = Convert.ToString(number_1 - number_2);

                    }
                    correct_answer = answer;
                    picture_problem_yes = false;

                    break;

                case "money":
                    question_lb.Text = "Add the money";
                    picture_answer_tb.Visible = true;
                    picture_problem.Visible = true;
                    answer_tb.Visible = false;
                    problem_itself_lb.Visible = false;
                    Halves.Visible = false;
                    Thirds.Visible = false;
                    six_btn.Visible = false;
                    quarter_btn.Visible = false;
                    eight_btn.Visible = false;
                    next_btn.Visible = true;
                    picture_answer_tb.Text = "$0.00";


                    int pic_nub = 0;
                    pic_nub = rnd.Next(1, 21);

                    switch (pic_nub)
                    {
                        case 1:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_1;
                            answer = Convert.ToString(99);
                            correct_answer = "0." + answer + "$";
                            break;
                        case 2:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_2;
                            answer = "98";
                            correct_answer = "0." + answer + "$";

                            break;
                        case 3:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_3;
                            answer = "97";
                            correct_answer = "0." + answer + "$";

                            break;
                        case 4:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_4;
                            answer = "96";
                            correct_answer = "0." + answer + "$";

                            break;
                        case 5:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_5;
                            answer = "95";
                            correct_answer = "0." + answer + "$";

                            break;
                        case 6:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_6;
                            answer = "87";
                            correct_answer = "0." + answer + "$";

                            break;
                        case 7:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_7;
                            answer = "86";
                            correct_answer = "0." + answer + "$";

                            break;
                        case 8:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_8;
                            answer = "85";
                            correct_answer = "0." + answer + "$";

                            break;
                        case 9:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_9;
                            answer = "84";
                            correct_answer = "0." + answer + "$";

                            break;
                        case 10:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_10;
                            answer = "83";
                            correct_answer = "0." + answer + "$";

                            break;

                        case 11:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_1;
                            answer = "5600";
                            correct_answer = "56.00$";

                            break;
                        case 12:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_2;
                            answer = "6535";
                            correct_answer = "65.35$";

                            break;
                        case 13:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_3;
                            answer = "3535";
                            correct_answer = "35.35$";

                            break;
                        case 14:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_4;
                            answer = "3520";
                            correct_answer = "35.20$";

                            break;
                        case 15:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_5;
                            answer = "3020";
                            correct_answer = "30.20$";

                            break;
                        case 16:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_6;
                            answer = "2535";
                            correct_answer = "25.35$";

                            break;
                        case 17:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_7;
                            answer = "2520";
                            correct_answer = "25.20$";

                            break;
                        case 18:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_8;
                            answer = "2035";
                            correct_answer = "20.35$";

                            break;
                        case 19:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_9;
                            answer = "1520";
                            correct_answer = "15.20$";

                            break;
                        case 20:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_money_10;
                            answer = "1035";
                            correct_answer = "10.35$";

                            break;
                    }
                    picture_problem_yes = true;

                    break;

                case "time":
                    if (rnd.Next(1, 1)==1)
                    {
                        //time telling
                        question_lb.Text = "What time is it?";
                        picture_answer_tb.Visible = true;
                        picture_problem.Visible = true;
                        answer_tb.Visible = false;
                        problem_itself_lb.Visible = false;
                        Halves.Visible = false;
                        Thirds.Visible = false;
                        six_btn.Visible = false;
                        quarter_btn.Visible = false;
                        eight_btn.Visible = false;
                        next_btn.Visible = true;
                        picture_answer_tb.Text = "hh:mm";

                        int clock_number = 0;
                        clock_number= rnd.Next(1, 10);
                        switch (clock_number)
                        {
                            case 1:
                                picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_time_1;
                                answer = "1137";
                                correct_answer = "11:37";

                                break;
                            case 2:
                                picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_time_2;
                                answer = "712";
                                correct_answer = "7:12";

                                break;
                            case 3:
                                picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_time_3;
                                answer = "633";
                                correct_answer = "6:33";

                                break;
                            case 4:
                                picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_time_4;
                                answer = "645";
                                correct_answer = "6:45";

                                break;
                            case 5:
                                picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_time_5;
                                answer = "832";
                                correct_answer = "5:32";

                                break;
                            case 6:
                                picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_time_6;
                                answer = "925";
                                correct_answer = "9:25";

                                break;
                            case 7:
                                picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_time_7;
                                answer = "559";
                                correct_answer = "5:59";

                                break;
                            case 8:
                                picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_time_8;
                                answer = "1022";
                                correct_answer = "10:22";

                                break;
                            case 9:
                                picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_time_9;
                                answer = "144";
                                correct_answer = "1:44";

                                break;

                        }
                        picture_problem_yes = true;


                    }

                    break;

                case "fractions":
                    question_lb.Text = "Is the figure divided into?";
                    picture_answer_tb.Visible = false;
                    picture_problem.Visible = true;
                    answer_tb.Visible = false;
                    problem_itself_lb.Visible = false;
                    Halves.Visible = true;
                    Thirds.Visible = true;
                    six_btn.Visible = true;
                    quarter_btn.Visible = true;
                    eight_btn.Visible = true;
                    next_btn.Visible = false;


                    int num = 0;
                    num = rnd.Next(1, 25);
                    switch (num)
                    {
                        case 1:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_1;
                            answer = "8";
                            correct_answer = "Eighths";
                            break;
                        case 2:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_2;
                            answer = "4";
                            correct_answer = "Quarters";

                            break;
                        case 3:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_3;
                            answer = "2";
                            correct_answer = "Halves";

                            break;
                        case 4:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_4;
                            answer = "4";
                            correct_answer = "Quarters";

                            break;
                        case 5:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_5;
                            answer = "2";
                            correct_answer = "Halves";

                            break;
                        case 6:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_6;
                            answer = "6";
                            correct_answer = "Sixths";

                            break;
                        case 7:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_7;
                            answer = "8";
                            correct_answer = "Eighths";

                            break;
                        case 8:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_8;
                            answer = "2";
                            correct_answer = "Halves";

                            break;
                        case 9:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_9;
                            answer = "8";
                            correct_answer = "Eighths";

                            break;
                        case 10:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_10;
                            answer = "4";
                            correct_answer = "Quarters";

                            break;
                        case 11:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_11;
                            answer = "2";
                            correct_answer = "Halves";

                            break;
                        case 12:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_12;
                            answer = "2";
                            correct_answer = "Halves";

                            break;
                        case 13:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_13;
                            answer = "2";
                            correct_answer = "Halves";

                            break;
                        case 14:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_14;
                            answer = "3";
                            correct_answer = "Sixths";

                            break;
                        case 15:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_15;
                            answer = "6";
                            correct_answer = "Sixths";

                            break;
                        case 16:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_16;
                            answer = "4";
                            correct_answer = "Quarters";

                            break;
                        case 17:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_17;
                            answer = "2";
                            correct_answer = "Halves";

                            break;
                        case 18:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_18;
                            answer = "4";
                            correct_answer = "Quarters";

                            break;
                        case 19:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_19;
                            answer = "6";
                            correct_answer = "Sixths";

                            break;
                        case 20:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_20;
                            answer = "3";
                            correct_answer = "Thirds";

                            break;
                        case 21:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_21;
                            answer = "3";
                            correct_answer = "Thirds";

                            break;
                        case 22:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_22;
                            answer = "2";
                            correct_answer = "Halves";

                            break;
                        case 23:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_23;
                            answer = "3";
                            correct_answer = "Thirds";

                            break;
                        case 24:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_2_fraction_24;
                            answer = "6";
                            correct_answer = "Sixths";

                            break;
                    }

                    break;




                default:
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
                    final.grade = "2";
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
                wrong.frac = false;
                wrong.Show();
                number_of_questions++;
                if (number_of_questions == 20)
                {
                    timer1.Enabled = false;
                    final_score final = new final_score();
                    System.Threading.Thread.Sleep(500);
                    final.grade = "2";
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

        public _2_problems()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            problem_select_test test = new problem_select_test();
            test.Show();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _2_problems_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.username;
            new_problem();
            SetAllControlsFont(tableLayoutPanel1.Controls);



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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void half_btn_Click(object sender, EventArgs e)
        {
            input = "2";
            check_input();

        }

        private void third_btn_Click(object sender, EventArgs e)
        {
            input = "3";
            check_input();

        }

        private void quarter_btn_Click(object sender, EventArgs e)
        {
            input = "4";
            check_input();

        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            input = "6";
            check_input();

        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            input = "8";
            check_input();

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (answer_tb.Text == "" && (picture_answer_tb.Text == "" || picture_answer_tb.Text == "hh:mm" || picture_answer_tb.Text == "$0.00"))
            {
                if (MessageBox.Show(
                        "Not answering the question will count as a wrong answer." + Environment.NewLine +
                        " Are you sure you want to do that?",
                        "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    check_input();
                }
                else
                {
                    return;
                }
            }
            else
            {
                switch (problem_type)
                {
                    case "add":
                        input = answer_tb.Text;
                        break;
                    case "sub":
                        input = answer_tb.Text;
                        break;
                    case "money":
                        string input_first = picture_answer_tb.Text;
                        input_first = input_first.Replace("0.", "");
                        input_first = input_first.Replace("0 ", "");
                        input_first = input_first.Replace("0:", "");
                        input_first = input_first.Replace("0,", "");
                        input_first = input_first.Replace("$", "");
                        input_first = input_first.Replace(".", "");
                        input_first = input_first.Replace(" ", "");
                        input_first = input_first.Replace(":", "");
                        input_first = input_first.Replace(",", "");


                        if (input_first == "")
                        {
                            if (MessageBox.Show(
                                    "Not answering the question will count as a wrong answer." +
                                    Environment.NewLine +
                                    " Are you sure you want to do that?",
                                    "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {

                                answer = "1234567890";
                                check_input();

                            }
                            else
                            {
                                return;
                            }


                        }
                        else
                        {

                            input = input_first;
                        }
                        break;

                    case "time":
                        string input_first_t = picture_answer_tb.Text;
                        input_first_t = input_first_t.Replace("$", "");
                        input_first_t = input_first_t.Replace(".", "");
                        input_first_t = input_first_t.Replace(" ", "");
                        input_first_t = input_first_t.Replace(":", "");

                        if (input_first_t == "")
                        {
                            if (MessageBox.Show(
                                    "Not answering the question will count as a wrong answer." +
                                    Environment.NewLine +
                                    " Are you sure you want to do that?",
                                    "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {

                                answer = "1234567890";
                                check_input();

                            }
                            else
                            {
                                return;
                            }


                        }
                        else
                        {
                            input = input_first_t;
                        }
                        break;
                }
                check_input();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_elasped = time_elasped + 0.1;
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

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel1.BackgroundImage == null)
            {
                return;
            }
            var bm = new Bitmap(this.tableLayoutPanel1.BackgroundImage, new Size(tableLayoutPanel1.Size.Width, tableLayoutPanel1.Height));
            tableLayoutPanel1.BackgroundImage = bm;

            picture_problem.Size = new Size(picture_problem.Width * (1920 / Screen.PrimaryScreen.Bounds.Width), picture_problem.Height * (1080 / Screen.PrimaryScreen.Bounds.Height));

        }

        private void Halves_Click(object sender, EventArgs e)
        {
            input = "2";
            check_input();

        }

        private void Thirds_Click(object sender, EventArgs e)
        {
            input = "3";
            check_input();

        }

        private void quarter_btn_Click_1(object sender, EventArgs e)
        {
            input = "4";
            check_input();

        }

        private void six_btn_Click_1(object sender, EventArgs e)
        {
            input = "6";
            check_input();

        }

        private void eight_btn_Click_1(object sender, EventArgs e)
        {
            input = "8";
            check_input();

        }
    }
}
