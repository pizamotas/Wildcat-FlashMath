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
    public partial class _3_problems : Form
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

        public void SetAllControlsFont(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                ctrl.Margin = new Padding(0, 0, 0, 0);
                if (Screen.PrimaryScreen.Bounds.Width < 1400)
                {
                    ctrl.Font = new Font("Impact", ctrl.Font.Size / 2);
                    if (Screen.PrimaryScreen.Bounds.Width < 1000)
                    {
                        ctrl.Font = new Font("Impact", ctrl.Font.Size / 2);
                    }
                }
            }
        }



        private void new_problem()
        {
            answer_tb.Text = "";
            long_problem_tb.Text = "";

            Random rnd = new Random();
            int number_selected = rnd.Next(0, problem_list.Count);
            string problem_selected = problem_list[number_selected];

            switch (problem_selected)
            {
                case "add":
                    int num_1 = rnd.Next(1, 100);
                    int w8 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w8);
                    int num_2 = rnd.Next(1, 100);
                    w8 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w8);
                    int num_3 = rnd.Next(1, 100);
                    w8 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w8);
                    int num_4 = rnd.Next(1, 100);

                    long_problem_tb.Text = num_1 + " + " + num_2 + " + " + num_3 + " + " + num_4 + " =";
                    answer =Convert.ToString(num_1 + num_2 + num_3 + num_4);
                    correct_answer = answer;
                    break;

                case  "sub":
                    int numb_1 = rnd.Next(100, 900);
                    w8 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w8);
                    int numb_2 = rnd.Next(1, 10) * 10;
                    answer =Convert.ToString(numb_1 - numb_2);
                    long_problem_tb.Text = numb_1 + " - " + numb_2 + " =";
                    correct_answer = answer;
                    break;

                case "multi":
                    int numbe_1 = rnd.Next(1, 11);
                    w8 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w8);
                    int numbe_2 = rnd.Next(1, 13);
                    long_problem_tb.Text = numbe_1 + " x " + numbe_2 + " =";
                    answer = Convert.ToString(numbe_1 * numbe_2);
                    correct_answer = answer;
                    break;


                case "div":
                    int number_1 = rnd.Next(1, 10);
                    w8 = rnd.Next(1, 100);
                    System.Threading.Thread.Sleep(w8);
                    int number_2 = rnd.Next(1, 10);
                    int number_3 = number_2 * number_1;

                    long_problem_tb.Text = number_3 + " ÷ " + number_2;
                    answer = Convert.ToString(number_1);
                    correct_answer = answer;
                    break;

                case "order":
                    int nb_1 = rnd.Next(1, 10);
                    w8 = rnd.Next(1, 10);
                    System.Threading.Thread.Sleep(w8);
                    int nb_2 = rnd.Next(1, 10);
                    w8 = rnd.Next(1, 10);
                    System.Threading.Thread.Sleep(w8);
                    int nb_3 = rnd.Next(1, 40);
                    w8 = rnd.Next(1, 50);
                    System.Threading.Thread.Sleep(w8);
                    int nb_4 = rnd.Next(1, 10);
                    w8 = rnd.Next(1, 10);
                    System.Threading.Thread.Sleep(w8);
                    int nb_5 = rnd.Next(1, 10);
                    w8 = rnd.Next(1, 10);
                    System.Threading.Thread.Sleep(w8);
                    int nb_6 = rnd.Next(1, 40);
                    w8 = rnd.Next(1, 50);
                    System.Threading.Thread.Sleep(w8);

                    int random_select = 0;
                    random_select =  rnd.Next(1, 5);
                    int random_select_2  = 0;
                    random_select_2 = rnd.Next(1, 6);

                    switch (random_select_2)
                    {
                        case 1:
                            // ( 1 - 2 ) - 3 - 4 - 5 - 6
                            switch (random_select)
                            {
                                case 1:
                                    // 1 + 2 - 3 * 4 - 5 + 6
                                    long_problem_tb.Text =
                                        " ( " + nb_1 + " + " + nb_2 + " ) " + " - " + nb_3 + " x " + nb_4 + " - " +
                                        nb_5 + " + " + nb_6 + " = ";
                                    answer = Convert.ToString( (nb_1 + nb_2) - nb_3 * nb_4 - nb_5 + nb_6);
                                    break;
                                case 2:
                                    // 1 - 2 * 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        " ( " + nb_1 + " - " + nb_2 + " ) " + " x " + nb_3 + " + " + nb_4 + " ÷ " +
                                        nb_5 + " - " + nb_6 + " = ";
                                    answer = Convert.ToString((nb_1 - nb_2) * nb_3 + nb_4 + nb_5 - nb_6);
                                    break;
                                case 3:
                                    // 1 * 2 - 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        " ( " + nb_1 + " x " + nb_2 + " ) " + " - " + nb_3 + " + " + nb_4 + " + " +
                                        nb_5 + " - " + nb_6 + " = ";
                                    answer = Convert.ToString((nb_1 * nb_2) - nb_3 + nb_4 + nb_5 - nb_6);
                                    break;
                                case 4:
                                    // 1 + 2 * 3 + 4 - 5 - 6
                                    long_problem_tb.Text =
                                        " ( " + nb_1 + " + " + nb_2 + " ) " + " x " + nb_3 + " + " + nb_4 + " - " +
                                        nb_5 + " - " + nb_6 + " = ";
                                    answer = Convert.ToString((nb_1 + nb_2) * nb_3 + nb_4 - nb_5 - nb_6);
                                    break;
                            }
                            break;

                        case 2:
                            //  1 - ( 2  - 3 ) - 4 - 5 - 6
                            switch (random_select)
                            {
                                case 1:
                                    // 1 + 2 - 3 * 4 - 5 + 6
                                    long_problem_tb.Text =
                                        nb_1 + " + " + " ( " + nb_2 + " - " + nb_3 + " ) " + " x " + nb_4 + " - " +
                                        nb_5 + " + " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 + (nb_2 - nb_3) * nb_4 - nb_5 + nb_6);

                                    break;
                                case 2:
                                    // 1 - 2 * 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " - " + " ( " + nb_2 + " x " + nb_3 + " ) " + " + " + nb_4 + " ÷ " +
                                        nb_5 + " - " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 - (nb_2 * nb_3) + nb_4 + nb_5 - nb_6);

                                    break;
                                case 3:
                                    // 1 * 2 - 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " x " + " ( " + nb_2 + " - " + nb_3 + " ) " + " + " + nb_4 + " + " +
                                        nb_5 + " - " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 * (nb_2 - nb_3) + nb_4 + nb_5 - nb_6);

                                    break;
                                case 4:
                                    // 1 + 2 * 3 + 4 - 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " + " + " ( " + nb_2   + " x " + nb_3 + " ) " + " + " + nb_4 + " - " +
                                        nb_5 + " - " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 + (nb_2 * nb_3) + nb_4 - nb_5 - nb_6);

                                    break;
                            }
                            break;
                        case 3:
                            //  1 - 2 - ( 3 - 4 ) - 5 - 6
                            switch (random_select)
                            {
                                case 1:
                                    // 1 + 2 - 3 * 4 - 5 + 6
                                    long_problem_tb.Text =
                                        nb_1 + " + " + nb_2 + " - " + " ( " + nb_3  + " x " + nb_4 + " ) " + " - " +
                                        nb_5 + " + " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 + nb_2 - (nb_3 * nb_4) - nb_5 + nb_6);


                                    break;
                                case 2:
                                    // 1 - 2 * 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " - " + nb_2  + " x " + " ( " + nb_3   + " + " + nb_4 + " ) " + " ÷ " +
                                        nb_5 + " - " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 - nb_2 * (nb_3 + nb_4) + nb_5 - nb_6);


                                    break;
                                case 3:
                                    // 1 * 2 - 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " x "  + nb_2 + " - " + " ( " + nb_3   + " + " + nb_4 + " ) " + " + " +
                                        nb_5 + " - " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 * nb_2 - (nb_3 + nb_4) + nb_5 - nb_6);


                                    break;
                                case 4:
                                    // 1 + 2 * 3 + 4 - 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " + " + nb_2  + " x " + " ( " + nb_3   + " + " + nb_4 + " ) " + " - " +
                                        nb_5 + " - " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 + nb_2 * (nb_3 + nb_4) - nb_5 - nb_6);


                                    break;
                            }
                            break;
                        case 4:
                            //  1 - 2  - 3 - ( 4 - 5 ) - 6
                            switch (random_select)
                            {
                                case 1:
                                    // 1 + 2 - 3 * 4 - 5 + 6
                                    long_problem_tb.Text =
                                        nb_1 + " + " + nb_2 + " - " + nb_3 + " x " + " ( " + nb_4  + " - " +
                                        nb_5 + " ) " + " + " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 + nb_2 - nb_3 * (nb_4 - nb_5) + nb_6);



                                    break;
                                case 2:
                                    // 1 - 2 * 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " - " + nb_2 + " x " + nb_3  + " + " + " ( " + nb_4   + " ÷ " +
                                        nb_5 + " ) " + " - " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 - nb_2 * nb_3 + (nb_4 + nb_5) - nb_6);


                                    break;
                                case 3:
                                    // 1 * 2 - 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " x " + nb_2 + " - " + nb_3  + " + " + " ( " + nb_4   + " + " +
                                        nb_5 + " ) " + " - " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 * nb_2 - nb_3 + (nb_4 + nb_5) - nb_6);


                                    break;
                                case 4:
                                    // 1 + 2 * 3 + 4 - 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " + " + nb_2 + " x " + nb_3  + " + " + " ( " + nb_4   + " - " +
                                        nb_5 + " ) " + " - " + nb_6 + " = ";
                                    answer = Convert.ToString(nb_1 + nb_2 * nb_3 + (nb_4 - nb_5) - nb_6);


                                    break;
                            }
                            break;
                        case 5:
                            //  1 - 2 - 3 - 4 - ( 5 - 6 )
                            switch (random_select)
                            {
                                case 1:
                                    // 1 + 2 - 3 * 4 - 5 + 6
                                    long_problem_tb.Text =
                                        nb_1 + " + " + nb_2 + " - " + nb_3 + " x " + nb_4  + " ÷-" + " ( " +
                                        nb_5   + " + " + nb_6 + " ) " + " = ";
                                    answer = Convert.ToString(nb_1 + nb_2 - nb_3 * nb_4 - (nb_5 + nb_6));


                                    break;
                                case 2:
                                    // 1 - 2 * 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " - " + nb_2 + " x " + nb_3 + " + " + nb_4  + " ÷ " + " ( " +
                                        nb_5   + " - " + nb_6 + " ) " + " = ";
                                    answer = Convert.ToString(nb_1 - nb_2 * nb_3 + nb_4 + (nb_5 - nb_6));


                                    break;
                                case 3:
                                    // 1 * 2 - 3 + 4 + 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " x " + nb_2 + " - " + nb_3 + " + " + nb_4  + " + " + " ( " +
                                        nb_5   + " - " + nb_6 + " ) " + " = ";
                                    answer = Convert.ToString(nb_1 * nb_2 - nb_3 + nb_4 + (nb_5 - nb_6));


                                    break;
                                case 4:
                                    // 1 + 2 * 3 + 4 - 5 - 6
                                    long_problem_tb.Text =
                                        nb_1 + " + " + nb_2 + " x " + nb_3 + " + " + nb_4  + " - " + " ( " +
                                        nb_5   + " - " + nb_6 + " ) " + " = ";
                                    answer = Convert.ToString(nb_1 + nb_2 * nb_3 + nb_4 - (nb_5 - nb_6));


                                    break;
                            }
                            break;
                    }
                    correct_answer = answer;
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
                    final.grade = "3";
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
                    final.grade = "3";
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

        public _3_problems()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;

        }

        private void _3_problems_Load(object sender, EventArgs e)
        {
            new_problem();
            label3.Text = Form1.username;
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



        private void timer1_Tick(object sender, EventArgs e)
        {
            time_elasped = time_elasped + 0.1;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (answer_tb.Text == "")
            {
                if (MessageBox.Show(
                        "Not answering the question will count as a wrong answer." + Environment.NewLine +
                        " Are you sure you want to do that?",
                        "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    check_answer();
                }
                else
                {
                    return;
                }
            }
            else
            {


                input = answer_tb.Text;
                check_answer();
            }
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

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel1.BackgroundImage == null)
            {
                return;
            }
            var bm = new Bitmap(this.tableLayoutPanel1.BackgroundImage, new Size(tableLayoutPanel1.Size.Width, tableLayoutPanel1.Height));
            tableLayoutPanel1.BackgroundImage = bm;

        }
    }
}
