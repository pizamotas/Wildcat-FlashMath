namespace Wildcat_FlashMath
{
    partial class wrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wrong));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.text_pnl = new System.Windows.Forms.Panel();
            this.answer_text = new System.Windows.Forms.Label();
            this.frac_line_2 = new System.Windows.Forms.PictureBox();
            this.frac_pnl = new System.Windows.Forms.Panel();
            this.ans_frac_bot = new System.Windows.Forms.Label();
            this.ans_frac_top = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.text_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frac_line_2)).BeginInit();
            this.frac_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(272, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 117);
            this.label1.TabIndex = 2;
            this.label1.Text = "WRONG!";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "The correct answer was:";
            // 
            // next_btn
            // 
            this.next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(202)))), ((int)(((byte)(1)))));
            this.next_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(202)))), ((int)(((byte)(1)))));
            this.next_btn.FlatAppearance.BorderSize = 5;
            this.next_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.next_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.next_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.next_btn.Location = new System.Drawing.Point(617, 202);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(167, 82);
            this.next_btn.TabIndex = 24;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // text_pnl
            // 
            this.text_pnl.Controls.Add(this.answer_text);
            this.text_pnl.Location = new System.Drawing.Point(365, 184);
            this.text_pnl.Name = "text_pnl";
            this.text_pnl.Size = new System.Drawing.Size(246, 100);
            this.text_pnl.TabIndex = 25;
            // 
            // answer_text
            // 
            this.answer_text.AutoSize = true;
            this.answer_text.Font = new System.Drawing.Font("Impact", 36F);
            this.answer_text.Location = new System.Drawing.Point(1, 18);
            this.answer_text.Name = "answer_text";
            this.answer_text.Size = new System.Drawing.Size(186, 60);
            this.answer_text.TabIndex = 32;
            this.answer_text.Text = "Eightths";
            this.answer_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frac_line_2
            // 
            this.frac_line_2.BackColor = System.Drawing.Color.Black;
            this.frac_line_2.Location = new System.Drawing.Point(4, 68);
            this.frac_line_2.Name = "frac_line_2";
            this.frac_line_2.Size = new System.Drawing.Size(45, 10);
            this.frac_line_2.TabIndex = 28;
            this.frac_line_2.TabStop = false;
            this.frac_line_2.Click += new System.EventHandler(this.frac_line_2_Click);
            // 
            // frac_pnl
            // 
            this.frac_pnl.Controls.Add(this.frac_line_2);
            this.frac_pnl.Controls.Add(this.ans_frac_bot);
            this.frac_pnl.Controls.Add(this.ans_frac_top);
            this.frac_pnl.Location = new System.Drawing.Point(376, 159);
            this.frac_pnl.Name = "frac_pnl";
            this.frac_pnl.Size = new System.Drawing.Size(54, 148);
            this.frac_pnl.TabIndex = 29;
            // 
            // ans_frac_bot
            // 
            this.ans_frac_bot.AutoSize = true;
            this.ans_frac_bot.Font = new System.Drawing.Font("Impact", 36F);
            this.ans_frac_bot.Location = new System.Drawing.Point(3, 81);
            this.ans_frac_bot.Margin = new System.Windows.Forms.Padding(0);
            this.ans_frac_bot.Name = "ans_frac_bot";
            this.ans_frac_bot.Size = new System.Drawing.Size(69, 60);
            this.ans_frac_bot.TabIndex = 31;
            this.ans_frac_bot.Text = "10";
            this.ans_frac_bot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ans_frac_top
            // 
            this.ans_frac_top.AutoSize = true;
            this.ans_frac_top.Font = new System.Drawing.Font("Impact", 36F);
            this.ans_frac_top.Location = new System.Drawing.Point(3, 5);
            this.ans_frac_top.Margin = new System.Windows.Forms.Padding(0);
            this.ans_frac_top.Name = "ans_frac_top";
            this.ans_frac_top.Size = new System.Drawing.Size(69, 60);
            this.ans_frac_top.TabIndex = 30;
            this.ans_frac_top.Text = "10";
            this.ans_frac_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 319);
            this.Controls.Add(this.frac_pnl);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_pnl);
            this.Name = "wrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wrong";
            this.Load += new System.EventHandler(this.wrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.text_pnl.ResumeLayout(false);
            this.text_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frac_line_2)).EndInit();
            this.frac_pnl.ResumeLayout(false);
            this.frac_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Panel text_pnl;
        private System.Windows.Forms.PictureBox frac_line_2;
        private System.Windows.Forms.Panel frac_pnl;
        private System.Windows.Forms.Label answer_text;
        private System.Windows.Forms.Label ans_frac_bot;
        private System.Windows.Forms.Label ans_frac_top;
    }
}