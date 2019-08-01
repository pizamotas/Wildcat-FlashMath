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
    public partial class problem_select_test : Form
    {
        private List<string> problem_list = new List<string>();
        public problem_select_test()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;
            

        }

        public static string grade = Form1.grade;

        public void checkbox_test()
        {
            string checked_boxes = "";
            int number_of_boxes = 0;

            List<string> problemsList = new List<string>();
            CheckBox[] box = new CheckBox[8];
            box[0] = checkBox1;
            box[1] = checkBox2;
            box[2] = checkBox3;
            box[3] = checkBox4;
            box[4] = checkBox5;
            box[5] = checkBox6;
            box[6] = checkBox7;
            box[7] = checkBox8;

            switch (grade)
            {
                case "1":
                    number_of_boxes = 4;
                    break;
                case "2":
                    number_of_boxes = 5;
                    break;
                case "3":
                    number_of_boxes = 5;
                    break;
                case "4":
                    number_of_boxes = 8;
                    break;
                case "5":
                    number_of_boxes = 8;
                    break;
                case "K":
                    number_of_boxes = 4;
                    break;

            }


            for (int i = 0; i < number_of_boxes; i++)
            {
                try
                {
                    if (box[i].Checked)
                    {
                        problemsList.Add(box[i].Text);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            problem_list = problemsList;
        }

        private void problem_select_test_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.username;
            label2.Text = "Grade: " + Form1.grade;
            string grade = Form1.grade;

            if (grade == "1")
            {
                button_1.Text = "Addition";
                button_2.Text = "Subtraction";
                button_3.Text = "Counting money";
                butoon_4.Text = "Telling time";

                checkBox1.Text = "add";
                checkBox2.Text = "sub";
                checkBox3.Text = "money";
                checkBox4.Text = "time";

                button_5.Visible = false;
                button_6.Visible = false;
                button_7.Visible = false;
                button_8.Visible = false;
                picture_5.Visible = false;
                picture_6.Visible = false;
                picture_7.Visible = false;
                picture_8.Visible = false;
            }
            else if (grade == "2")
            {
                button_1.Text = "Addition";
                button_2.Text = "Subtraction";
                button_3.Text = "Counting money";
                butoon_4.Text = "Telling time";
                button_5.Text = "Fractions";

                checkBox1.Text = "add";
                checkBox2.Text = "sub";
                checkBox3.Text = "money";
                checkBox4.Text = "time";
                checkBox5.Text = "fractions";


                button_6.Visible = false;
                button_7.Visible = false;
                button_8.Visible = false;
                picture_6.Visible = false;
                picture_7.Visible = false;
                picture_8.Visible = false;

            }
            else if (grade == "3")
            {
                button_1.Text = "Addition";
                button_2.Text = "Subtraction";
                button_3.Text = "Multiplication ";
                butoon_4.Text = "Division";
                button_5.Text = "Order of operations";

                checkBox1.Text = "add";
                checkBox2.Text = "sub";
                checkBox3.Text = "multi";
                checkBox4.Text = "div";
                checkBox5.Text = "order";
                
                button_6.Visible = false;
                button_7.Visible = false;
                button_8.Visible = false;
                picture_6.Visible = false;
                picture_7.Visible = false;
                picture_8.Visible = false;

            }
            else if (grade == "K")
            {
                button_1.Text = "Addition";
                button_2.Text = "Subtraction";
                button_3.Text = "Money ";
                butoon_4.Text = "Graphing";

                checkBox1.Text = "add";
                checkBox2.Text = "sub";
                checkBox3.Text = "money";
                checkBox4.Text = "graph";

                button_5.Visible = false;
                button_6.Visible = false;
                button_7.Visible = false;
                button_8.Visible = false;
                picture_5.Visible = false;
                picture_6.Visible = false;
                picture_7.Visible = false;
                picture_8.Visible = false;

            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
                picture_1.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_1.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox1.Checked = true;
                picture_1.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_1.BackColor = Color.FromArgb(255, 255, 128, 0);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
                picture_2.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_2.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox2.Checked = true;
                picture_2.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_2.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Checked = false;
                picture_3.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_3.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox3.Checked = true;
                picture_3.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_3.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;
                picture_4.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                butoon_4.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox4.Checked = true;
                picture_4.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                butoon_4.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Checked = false;
                picture_5.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_5.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox5.Checked = true;
                picture_5.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_5.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.Checked = false;
                picture_6.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_6.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox6.Checked = true;
                picture_6.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_6.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.Checked = false;
                picture_7.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_7.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox7.Checked = true;
                picture_7.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_7.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox8.Checked = false;
                picture_8.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_8.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox8.Checked = true;
                picture_8.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_8.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            picture_1.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_1.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox2.Checked = true;
            picture_2.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_2.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox3.Checked = true;
            picture_3.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_3.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox4.Checked = true;
            picture_4.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            butoon_4.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox5.Checked = true;
            picture_5.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_5.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox6.Checked = true;
            picture_6.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_6.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox7.Checked = true;
            picture_7.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_7.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox8.Checked = true;
            picture_8.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_8.BackColor = Color.FromArgb(255, 255, 128, 0);

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            checkbox_test();

            if (Form1.grade == "1")
            {
                _1_problems problems = new _1_problems();
                problems.problems_list = problem_list;
                problems.name = Form1.username;
                problems.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_menu mai = new main_menu();
            mai.Show();
            this.Close();        
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
