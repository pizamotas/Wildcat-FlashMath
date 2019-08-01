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
    public partial class k_problems : Form
    {
        public string answer_str = "";
        public int answer = 0;
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

        private void answer_check()
        {
            if (input == answer_str)
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


                    final.grade = "k";
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

                    final.grade = "k";
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

        private void new_problem()
        {
            Random rnd = new Random();
            int number_selected = rnd.Next(0, problem_list.Count);
            string problem_selected = problem_list[number_selected];
            picture_problem.Visible = false;
            picture_answer.Visible = false;
            long_problem_tb.Visible = false;
            answer_tb.Visible = false;
            picture_answer.Text = "";
            answer_tb.Text = "";

            switch (problem_selected)
            {
                case "add":
                    picture_problem.Visible = true;
                    picture_answer.Visible = true;
                    problem_type = "add";
                    question_lb.Text = "Find the answer to the question";

                    switch (rnd.Next(1, 33))
                    {
                        case 1:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_1;
                            answer = 21;
                            break;
                        case 2:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_2;
                            answer = 23;

                            break;
                        case 3:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_3;
                            answer = 20;

                            break;
                        case 4:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_4;
                            answer = 18;

                            break;
                        case 5:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_5;
                            answer = 14;

                            break;
                        case 6:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_6;
                            answer = 15;

                            break;
                        case 7:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_7;
                            answer = 9;

                            break;
                        case 8:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_8;
                            answer = 13;

                            break;
                        case 9:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_9;
                            answer = 17;

                            break;
                        case 10:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_10;
                            answer = 28;

                            break;
                        case 11:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_11;
                            answer = 22;

                            break;
                        case 12:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_12;
                            answer = 3;

                            break;
                        case 13:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_13;
                            answer = 6;

                            break;
                        case 14:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_14;
                            answer = 14;

                            break;
                        case 15:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_15;
                            answer = 7;

                            break;
                        case 16:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_16;
                            answer = 15;

                            break;
                        case 17:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_17;
                            answer = 19;

                            break;
                        case 18:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_18;
                            answer = 12;

                            break;
                        case 19:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_19;
                            answer = 15;

                            break;
                        case 20:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_20;
                            answer = 16;

                            break;
                        case 21:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_21;
                            answer = 18;

                            break;
                        case 22:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_22;
                            answer = 16;

                            break;
                        case 23:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_23;
                            answer = 24;

                            break;
                        case 24:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_24;
                            answer = 14;

                            break;
                        case 25:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_25;
                            answer = 4;

                            break;
                        case 26:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_26;
                            answer = 19;

                            break;
                        case 27:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_27;
                            answer = 23;

                            break;
                        case 28:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_28;
                            answer = 18;

                            break;
                        case 29:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_29;
                            answer = 22;

                            break;
                        case 30:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_30;
                            answer = 10;

                            break;
                        case 31:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_31;
                            answer = 19;

                            break;
                        case 32:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.add_32;
                            answer = 14;

                            break;

                        default:
                            break;

                    }
                    correct_answer = answer.ToString();


                    break;
                case "sub":
                    problem_type = "sub";
                    question_lb.Text = "Find the answer to the question";

                    int num_1;
                    int num_2;
                    num_1 = rnd.Next(8, 20);
                    int w8 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w8);
                    num_2 = rnd.Next(1, 8);
                    long_problem_tb.Text = num_1 + " - " + num_2 + " = ";
                    answer = num_1 - num_2;
                    long_problem_tb.Visible = true;
                    answer_tb.Visible = true;
                    correct_answer = answer.ToString();


                    break;
                case "money":
                    problem_type = "money";
                    picture_problem.Visible = true;
                    picture_answer.Visible = true;
                    question_lb.Text = "Add the coins";


                    switch (rnd.Next(1, 21))
                    {
                        case 1:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_1;
                            answer = 99;
                            break;
                        case 2:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_2;
                            answer = 98;
                            break;
                        case 3:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_3;
                            answer = 97;
                            break;
                        case 4:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_4;
                            answer = 96;
                            break;
                        case 5:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_5;
                            answer = 95;
                            break;
                        case 6:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_6;
                            answer = 87;
                            break;
                        case 7:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_7;
                            answer = 86;
                            break;
                        case 8:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_8;
                            answer = 85;
                            break;
                        case 9:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_9;
                            answer = 84;
                            break;
                        case 10:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_10;
                            answer = 83;
                            break;
                        case 11:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_11;
                            answer = 81;
                            break;
                        case 12:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_12;
                            answer = 70;
                            break;
                        case 13:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_13;
                            answer = 64;
                            break;
                        case 14:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_14;
                            answer = 53;
                            break;
                        case 15:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_15;
                            answer = 48;
                            break;
                        case 16:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_16;
                            answer = 37;
                            break;
                        case 17:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_17;
                            answer = 23;
                            break;
                        case 18:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_18;
                            answer = 14;
                            break;
                        case 19:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_19;
                            answer = 12;
                            break;
                        case 20:
                            picture_problem.Image = Wildcat_FlashMath.Properties.Resources.grade_k_20;
                            answer = 4;
                            break;


                    }
                    correct_answer = answer.ToString();

                    break;

            }
        }

        public k_problems()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;

        }

        private void k_problems_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.username;
            new_problem();
            SetAllControlsFont(tableLayoutPanel1.Controls);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_elasped = time_elasped + 0.1;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (answer_tb.Text == "" && picture_answer.Text == "")
            {
                if (MessageBox.Show(
                        "Not answering the question will count as a wrong answer." + Environment.NewLine +
                        " Are you sure you want to do that?",
                        "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    input = "1234567890";
                    answer_check();
                }
                else
                {
                    return;
                }
            }
            else
            {

                answer_str = Convert.ToString(answer);
                if (problem_type == "sub")
                {
                    input = answer_tb.Text;
                }
                else
                {
                    input = picture_answer.Text;
                }
                answer_check();
            }
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
    }
}
