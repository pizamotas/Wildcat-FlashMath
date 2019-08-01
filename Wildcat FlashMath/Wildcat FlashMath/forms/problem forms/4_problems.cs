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
    public partial class _4_problems : Form
    {
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
        private string frac_ans_top = "";
        private string frac_ans_bot = "";

        private string correct_answer;
        private string correct_bot;
        private bool wrong_frac = false;

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
                ctrl.Margin = new Padding(0,0,0,0);
                if (Screen.PrimaryScreen.Bounds.Width <1400)
                {
                    ctrl.Font = new Font("Impact", ctrl.Font.Size / 4);
                    ctrl.Font = new Font("Impact", ctrl.Font.Size * 3);
                    if (Screen.PrimaryScreen.Bounds.Width <1000)
                    {
                        ctrl.Font = new Font("Impact", ctrl.Font.Size /4);
                        ctrl.Font = new Font("Impact", ctrl.Font.Size *3);

                    }
                }

            }
        }


        private void new_problem()
        {
            answer_tb.Text = "";
            long_problem_tb.Text = "";
            fraction_1_bot.Text = "";
            fraction_2_bot.Text = "";
            fraction_1_top.Text = "";
            fraction_2_top.Text = "";
            word_problem_answer.Text = "";
            fraction_answer_top.Text = "";
            fraction_answer_bot.Text = "";



            Random rnd = new Random();
            int number_selected = rnd.Next(0, problem_list.Count);
            string problem_selected = problem_list[number_selected];



            switch (problem_selected)
            {
                case "add":
                    word_problem_answer.Visible = false;
                    question_lb.Text = "Find the answer to the question";

                    fraction_1_top.Visible = false;
                    fraction_2_top.Visible = false;
                    fraction_1_bot.Visible = false;
                    fraction_2_bot.Visible = false;
                    frac_line_1.Visible = false;
                    frac_line_2.Visible = false;
                    frac_line_3.Visible = false;
                    fraction_answer_bot.Visible = false;
                    fraction_answer_top.Visible = false;
                    fraction_symbol_tb.Visible = false;
                    textBox8.Visible = false; //lygu po frac
                    problem_type = "add";

                    long_problem_tb.Visible = true;
                    answer_tb.Visible = true;

                    int add_1 = rnd.Next(1, 500);
                    int w8 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w8);
                    int add_2 = rnd.Next(1, 500);

                    long_problem_tb.Text = add_1 + " + " + add_2;
                    answer = Convert.ToString(add_2 + add_1);
                    correct_answer = answer;
                    wrong_frac = false;
                    break;
                case "sub":
                    word_problem_answer.Visible = false;
                    question_lb.Text = "Find the answer to the question";

                    fraction_1_top.Visible = false;
                    fraction_2_top.Visible = false;
                    fraction_1_bot.Visible = false;
                    fraction_2_bot.Visible = false;
                    frac_line_1.Visible = false;
                    frac_line_2.Visible = false;
                    frac_line_3.Visible = false;
                    fraction_answer_bot.Visible = false;
                    fraction_answer_top.Visible = false;
                    fraction_symbol_tb.Visible = false;
                    textBox8.Visible = false; //lygu po frac
                    problem_type = "sub";

                    long_problem_tb.Visible = true;
                    answer_tb.Visible = true;

                    int sub_1 = rnd.Next(250, 500);
                    w8 = rnd.Next(1, 250);
                    System.Threading.Thread.Sleep(w8);
                    int sub_2 = rnd.Next(1, 250);

                    long_problem_tb.Text = sub_1 + " - " + sub_2;
                    answer = Convert.ToString(sub_2 + sub_1);
                    correct_answer = answer;
                    wrong_frac = false;

                    break;
                case "multi":
                    word_problem_answer.Visible = false;
                    question_lb.Text = "Find the answer to the question";

                    fraction_1_top.Visible = false;
                    fraction_2_top.Visible = false;
                    fraction_1_bot.Visible = false;
                    fraction_2_bot.Visible = false;
                    frac_line_1.Visible = false;
                    frac_line_2.Visible = false;
                    frac_line_3.Visible = false;
                    fraction_answer_bot.Visible = false;
                    fraction_answer_top.Visible = false;
                    fraction_symbol_tb.Visible = false;
                    textBox8.Visible = false; //lygu po frac
                    problem_type = "multi";

                    long_problem_tb.Visible = true;
                    answer_tb.Visible = true;

                    int multi_1 = rnd.Next(1, 13);
                    w8 = rnd.Next(1, 250);
                    System.Threading.Thread.Sleep(w8);
                    int multi_2 = rnd.Next(1, 13);

                    long_problem_tb.Text = multi_1 + " x " + multi_2;
                    answer = Convert.ToString(multi_2 * multi_1);
                    correct_answer = answer;
                    wrong_frac = false;

                    break;
                case "div":
                    word_problem_answer.Visible = false;
                    question_lb.Text = "Find the answer to the question";

                    fraction_1_top.Visible = false;
                    fraction_2_top.Visible = false;
                    fraction_1_bot.Visible = false;
                    fraction_2_bot.Visible = false;
                    frac_line_1.Visible = false;
                    frac_line_2.Visible = false;
                    frac_line_3.Visible = false;
                    fraction_answer_bot.Visible = false;
                    fraction_answer_top.Visible = false;
                    fraction_symbol_tb.Visible = false;
                    textBox8.Visible = false; //lygu po frac
                    problem_type = "div";

                    long_problem_tb.Visible = true;
                    answer_tb.Visible = true;

                    int div_1 = rnd.Next(1, 13);
                    w8 = rnd.Next(1, 250);
                    System.Threading.Thread.Sleep(w8);
                    int div_2 = rnd.Next(1, 13);

                    int div_3 = div_1 * div_2;

                    long_problem_tb.Text = div_3 + " ÷ " + div_2;
                    answer = Convert.ToString(div_1);
                    correct_answer = answer;
                    wrong_frac = false;


                    break;
                case "measurments":
                    word_problem_answer.Visible = false;
                    question_lb.Text = "Find the answer to the question";

                    fraction_1_top.Visible = false;
                    fraction_2_top.Visible = false;
                    fraction_1_bot.Visible = false;
                    fraction_2_bot.Visible = false;
                    frac_line_1.Visible = false;
                    frac_line_2.Visible = false;
                    frac_line_3.Visible = false;
                    fraction_answer_bot.Visible = false;
                    fraction_answer_top.Visible = false;
                    fraction_symbol_tb.Visible = false;
                    textBox8.Visible = false; //lygu po frac
                    problem_type = "measurments";
                    long_problem_tb.Visible = true;
                    answer_tb.Visible = true;


                    int measurment = 0;
                    measurment = rnd.Next(1, 10);
                    int switch1 = 0;
                    switch1 = rnd.Next(1, 13);
                    switch (switch1)
                    {
                        case 1:
                            //mi - yd 1760
                            long_problem_tb.Text = measurment + "mi = ? yd";
                            answer = Convert.ToString(measurment * 1760);
                            break;
                        case 2:
                            //yd - ft 3
                            long_problem_tb.Text = measurment + "yd = ? ft";
                            answer = Convert.ToString(measurment * 3);
                            break;
                        case 3:
                            //ft - in 12
                            long_problem_tb.Text = measurment + "ft = ? in";
                            answer = Convert.ToString(measurment * 12);
                            break;
                        case 4:
                            //gal - qt 4
                            long_problem_tb.Text = measurment + "gal = ? qt";
                            answer = Convert.ToString(measurment * 4);
                            break;
                        case 5:
                            //qt - pt 2
                            long_problem_tb.Text = measurment + "qt = ? pt";
                            answer = Convert.ToString(measurment * 2);

                            break;
                        case 6:
                            //pt - oz 16 
                            long_problem_tb.Text = measurment + "pt = ? oz";
                            answer = Convert.ToString(measurment * 16);

                            break;
                        case 7:
                            //t - lb 2000
                            long_problem_tb.Text = measurment + "t = ? lb";
                            answer = Convert.ToString(measurment * 2000);

                            break;
                        case 8:
                            //lb - oz 16
                            long_problem_tb.Text = measurment + "lb = ? oz";
                            answer = Convert.ToString(measurment * 16);

                            break;
                        case 9:
                            //l - ml 1000
                            long_problem_tb.Text = measurment + "l = ? ml";
                            answer = Convert.ToString(measurment * 1000);

                            break;
                        case 10:
                            //kg - g 1000
                            long_problem_tb.Text = measurment + "kg = ? g";
                            answer = Convert.ToString(measurment * 1000);

                            break;
                        case 11:
                            //m - cm 100
                            long_problem_tb.Text = measurment + "m = ? cm";
                            answer = Convert.ToString(measurment * 100);

                            break;
                        case 12:
                            //cm - mm 10
                            long_problem_tb.Text = measurment + "cm = ? mm";
                            answer = Convert.ToString(measurment * 10);

                            break;
                    }
                    correct_answer = answer;
                    wrong_frac = false;
                    break;

                case "fractions":
                    word_problem_answer.Visible = false;
                    question_lb.Text = "Find the answer to the question";

                    fraction_1_top.Visible = true;
                    fraction_2_top.Visible = true;
                    fraction_1_bot.Visible = true;
                    fraction_2_bot.Visible = true;
                    frac_line_1.Visible = true;
                    frac_line_2.Visible = true;
                    frac_line_3.Visible = true;
                    fraction_answer_bot.Visible = true;
                    fraction_answer_top.Visible = true;
                    fraction_symbol_tb.Visible = true;
                    textBox8.Visible = true; //lygu po frac
                    problem_type = "frac";

                    long_problem_tb.Visible = false;
                    answer_tb.Visible = false;


                    int frac_1;
                    int frac_2;
                    int frac_3;

                    int frac = 0;
                    frac = rnd.Next(0, 2);

                    switch (frac)
                    {
                        case 1:
                            frac_1 = rnd.Next(1, 10);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            frac_2 = rnd.Next(1, 10);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            frac_3 = rnd.Next(1, 10);

                            fraction_1_top.Text = Convert.ToString(frac_1);
                            fraction_2_top.Text = Convert.ToString(frac_2);
                            fraction_1_bot.Text = Convert.ToString(frac_3);
                            fraction_2_bot.Text = Convert.ToString(frac_3);

                            fraction_symbol_tb.Text = "+";

                            frac_ans_top = Convert.ToString(frac_1 + frac_2);
                            frac_ans_bot = Convert.ToString(frac_3);

                            break;
                        case 0:
                            frac_1 = rnd.Next(5, 10);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            frac_2 = rnd.Next(1, 5);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            frac_3 = rnd.Next(1, 10);

                            fraction_1_top.Text = Convert.ToString(frac_1);
                            fraction_2_top.Text = Convert.ToString(frac_2);
                            fraction_1_bot.Text = Convert.ToString(frac_3);
                            fraction_2_bot.Text = Convert.ToString(frac_3);

                            fraction_symbol_tb.Text = "-";

                            frac_ans_top = Convert.ToString(frac_1 - frac_2);
                            frac_ans_bot = Convert.ToString(frac_3);



                            break;

                    }
                    correct_answer = frac_ans_top;
                    correct_bot = frac_ans_bot;
                    wrong_frac = true;
                    break;
                case "word":

                    word_problem_answer.Visible = true;
                    question_lb.Text = "";
                    question_lb.Visible = true;

                    fraction_1_top.Visible = false;
                    fraction_2_top.Visible = false;
                    fraction_1_bot.Visible = false;
                    fraction_2_bot.Visible = false;
                    frac_line_1.Visible = false;
                    frac_line_2.Visible = false;
                    frac_line_3.Visible = false;
                    fraction_answer_bot.Visible = false;
                    fraction_answer_top.Visible = false;
                    fraction_symbol_tb.Visible = false;
                    textBox8.Visible = false; //lygu po frac
                    problem_type = "word";

                    long_problem_tb.Visible = false;
                    answer_tb.Visible = false;
                    string problem = "";

                    int word_1 = 0;
                    w8 = rnd.Next(1, 250);
                    System.Threading.Thread.Sleep(w8);
                    int word_2 = 0;
                    int word_3 = 0;


                    switch (rnd.Next(1, 8))
                    {
                        case 1:
                            word_1 = rnd.Next(900, 3000);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            word_2 = rnd.Next(1, 800);
                             problem =
                                "Ellen had "+ word_1 + " Legos, but she lost "+word_2+" Legos.How many Legos does she have now ?";
                            answer = Convert.ToString(word_1 - word_2);
                            break;
                        case 2:
                            word_1 = rnd.Next(1, 300);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            word_2 = rnd.Next(1, 50);

                            problem =
                                "Arthur baked "+ word_1 +" muffins. James baked "+word_2+" times as many. How many muffins did James bake?";
                            answer = Convert.ToString(word_1 * word_2);

                            break;
                        case 3:
                            word_1 = rnd.Next(1, 300);
                            w8 = rnd.Next(1, 100);
                            System.Threading.Thread.Sleep(w8);
                            word_2 = rnd.Next(1, 11);
                            word_3 = word_2 * word_1;

                            problem =
                                "There are "+word_3+" books in a library. They are arranged on shelves that hold "+word_2+" books each. How many shelves are in the library? ";
                            answer = Convert.ToString(word_1);
                            break;
                        case 4:
                            word_1 = rnd.Next(1000, 2000);
                            w8 = rnd.Next(1, 100);
                            System.Threading.Thread.Sleep(w8);
                            word_2 = rnd.Next(1, 250);

                            problem =
                                "Willy has "+word_1+" crayons. Lucy has "+word_2+" crayons. How many more crayons does Willy have than Lucy? ";
                            answer = Convert.ToString(word_1 - word_2);

                            break;
                        case 5:
                            word_1 = rnd.Next(1000, 30000);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            word_2 = rnd.Next(1, 1000);

                            problem =
                                "Brad has "+word_1+" balloons. "+word_2+" of them are red and the rest are green. How many green balloons does Brad have? ";
                            answer = Convert.ToString(word_1 - word_2);
                            break;
                        case 7:
                            word_1 = rnd.Next(5, 10);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            word_2 = rnd.Next(5, 10);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            word_3 = rnd.Next(1, 25);

                            problem =
                                "Mrs. Hilt bought "+word_1+" pizzas with "+word_2+" slices each. She and her friends ate "+word_3+" slices of the pizza. How many slices were left? ";
                            answer = Convert.ToString(word_1 * word_2 - word_3);

                            break;
                        default:
                            word_1 = rnd.Next(1, 11);
                            w8 = rnd.Next(1, 250);
                            System.Threading.Thread.Sleep(w8);
                            word_2 = rnd.Next(1, 100);

                            problem =
                                "Mrs. Hilt gave "+word_1+" apples to each fourth grader. If there are "+word_2+" fourth graders, how many apples did Mrs. Hilt give away? ";
                            answer = Convert.ToString(word_1 * word_2);
                            break;
                    }
                    question_lb.Text = problem;
                    correct_answer = answer;
                    wrong_frac = false;



                    break;
                case "decimals":

                    word_problem_answer.Visible = false;
                    question_lb.Text = "Find the answer to the question";

                    fraction_1_top.Visible = false;
                    fraction_2_top.Visible = false;
                    fraction_1_bot.Visible = false;
                    fraction_2_bot.Visible = false;
                    frac_line_1.Visible = false;
                    frac_line_2.Visible = false;
                    frac_line_3.Visible = false;
                    fraction_answer_bot.Visible = false;
                    fraction_answer_top.Visible = false;
                    fraction_symbol_tb.Visible = false;
                    textBox8.Visible = false; //lygu po frac
                    problem_type = "decimals";

                    long_problem_tb.Visible = true;
                    answer_tb.Visible = true;

                    int dec_1 = rnd.Next(5, 10);
                    w8 = rnd.Next(1, 250);
                    System.Threading.Thread.Sleep(w8);
                    int dec_2 = rnd.Next(1, 10);
                    w8 = rnd.Next(1, 250);
                    System.Threading.Thread.Sleep(w8);
                    int dec_3 = rnd.Next(1, 5);
                    w8 = rnd.Next(1, 250);
                    System.Threading.Thread.Sleep(w8);
                    int dec_4 = rnd.Next(1, 10);
                    w8 = rnd.Next(1, 250);
                    System.Threading.Thread.Sleep(w8);

                    int decimals = 0;
                    decimals = rnd.Next(0, 2);
                    switch (decimals)
                    {
                        case 0:
                            long_problem_tb.Text = dec_1 + "." + dec_2 + " + " + dec_3 + "." + dec_4;

                            double deci = dec_1 + dec_3;
                            double deci2 = dec_2 + dec_4;
                            double deci_3 = deci2 / 10;
                            double deci_4 = deci + deci_3;
                            answer = Convert.ToString(deci_4);
                            break;
                        case 1:
                            long_problem_tb.Text = dec_1 + "." + dec_2 + " - " + dec_3 + "." + dec_4;
                            double deca_1 = dec_1 - dec_3;
                            double deca_2 = dec_2 - dec_4;
                            double deca_4 = deca_2 / 10;
                            double deca_3 = deca_1 + deca_4;
                            answer = Convert.ToString(deca_3);
                            break;
                    }
                    correct_answer = answer;
                    wrong_frac = false;
                    break;
            }
            number_selected = 0;


        }

        public void check_answer()
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
                    final.grade = "4";
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
                if (wrong_frac)
                {
                    wrong.frac = true;
                    wrong.answer = correct_answer;
                    wrong.ans_bot = correct_bot;
                }
                else
                {
                    wrong.answer = correct_answer;
                    wrong.frac = false;
                }
                wrong.Show();
                number_of_questions++;
                if (number_of_questions == 20)
                {
                    timer1.Enabled = false;
                    final_score final = new final_score();
                    System.Threading.Thread.Sleep(500);
                    final.grade = "4";
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


        public _4_problems()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_elasped = time_elasped + 0.1;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (answer_tb.Text == "" && fraction_answer_bot.Text == "" && fraction_answer_top.Text == "" && word_problem_answer.Text == "")
            {
                if (MessageBox.Show(
                        "Not answering the question will count as a wrong answer." + Environment.NewLine +
                        " Are you sure you want to do that?",
                        "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    input = "1234567890";
                    check_answer();
                }
                else
                {
                    return;
                }
            }
            else
            {


                if (problem_type == "word")
                {
                    input = word_problem_answer.Text;
                    check_answer();
                }
                else if (problem_type == "frac")
                {
                    check_answer();
                }
                else if (problem_type == "decimals")
                {
                    string ans = answer_tb.Text;
                    //ans = ans.Replace(".", ",");
                    if (ans =="")
                    {
                        
                    }
                    input = ans;
                    check_answer();
                }
                else
                {
                    input = answer_tb.Text;
                    check_answer();
                }
            }
        }

        private void _4_problems_Load(object sender, EventArgs e)
        {
            new_problem();
            label3.Text = Form1.username;
            SetAllControlsFont(tableLayoutPanel1.Controls);
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
