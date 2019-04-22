namespace Desktop_Project
{
    partial class Calc
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
            this.txt_res = new System.Windows.Forms.TextBox();
            this.calc_mc = new System.Windows.Forms.Button();
            this.calc_mr = new System.Windows.Forms.Button();
            this.calc_ms = new System.Windows.Forms.Button();
            this.calc_mplus = new System.Windows.Forms.Button();
            this.calc_mmin = new System.Windows.Forms.Button();
            this.calc_back = new System.Windows.Forms.Button();
            this.calc_ce = new System.Windows.Forms.Button();
            this.calc_c = new System.Windows.Forms.Button();
            this.calc_plusmin = new System.Windows.Forms.Button();
            this.calc_root = new System.Windows.Forms.Button();
            this.calc_slash = new System.Windows.Forms.Button();
            this.calc_percent = new System.Windows.Forms.Button();
            this.calc_asth = new System.Windows.Forms.Button();
            this.calc_1slashx = new System.Windows.Forms.Button();
            this.calc_min = new System.Windows.Forms.Button();
            this.calc_plus = new System.Windows.Forms.Button();
            this.calc_equ = new System.Windows.Forms.Button();
            this.calc_7 = new System.Windows.Forms.Button();
            this.calc_8 = new System.Windows.Forms.Button();
            this.calc_9 = new System.Windows.Forms.Button();
            this.calc_4 = new System.Windows.Forms.Button();
            this.calc_5 = new System.Windows.Forms.Button();
            this.calc_6 = new System.Windows.Forms.Button();
            this.calc_1 = new System.Windows.Forms.Button();
            this.calc_2 = new System.Windows.Forms.Button();
            this.calc_3 = new System.Windows.Forms.Button();
            this.calc_0 = new System.Windows.Forms.Button();
            this.calc_dot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_res
            // 
            this.txt_res.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_res.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_res.Location = new System.Drawing.Point(15, 9);
            this.txt_res.Multiline = true;
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(199, 50);
            this.txt_res.TabIndex = 0;
            this.txt_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_res.TextChanged += new System.EventHandler(this.txt_res_TextChanged);
            // 
            // calc_mc
            // 
            this.calc_mc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calc_mc.Location = new System.Drawing.Point(13, 65);
            this.calc_mc.Name = "calc_mc";
            this.calc_mc.Size = new System.Drawing.Size(35, 29);
            this.calc_mc.TabIndex = 1;
            this.calc_mc.Text = "MC";
            this.calc_mc.UseVisualStyleBackColor = false;
            // 
            // calc_mr
            // 
            this.calc_mr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calc_mr.Location = new System.Drawing.Point(54, 65);
            this.calc_mr.Name = "calc_mr";
            this.calc_mr.Size = new System.Drawing.Size(35, 29);
            this.calc_mr.TabIndex = 2;
            this.calc_mr.Text = "MR";
            this.calc_mr.UseVisualStyleBackColor = false;
            // 
            // calc_ms
            // 
            this.calc_ms.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calc_ms.Location = new System.Drawing.Point(95, 65);
            this.calc_ms.Name = "calc_ms";
            this.calc_ms.Size = new System.Drawing.Size(35, 29);
            this.calc_ms.TabIndex = 3;
            this.calc_ms.Text = "MS";
            this.calc_ms.UseVisualStyleBackColor = false;
            // 
            // calc_mplus
            // 
            this.calc_mplus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calc_mplus.Location = new System.Drawing.Point(136, 65);
            this.calc_mplus.Name = "calc_mplus";
            this.calc_mplus.Size = new System.Drawing.Size(35, 29);
            this.calc_mplus.TabIndex = 4;
            this.calc_mplus.Text = "M+";
            this.calc_mplus.UseVisualStyleBackColor = false;
            // 
            // calc_mmin
            // 
            this.calc_mmin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calc_mmin.Location = new System.Drawing.Point(177, 65);
            this.calc_mmin.Name = "calc_mmin";
            this.calc_mmin.Size = new System.Drawing.Size(35, 29);
            this.calc_mmin.TabIndex = 5;
            this.calc_mmin.Text = "M-";
            this.calc_mmin.UseVisualStyleBackColor = false;
            // 
            // calc_back
            // 
            this.calc_back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_back.Location = new System.Drawing.Point(13, 100);
            this.calc_back.Name = "calc_back";
            this.calc_back.Size = new System.Drawing.Size(35, 29);
            this.calc_back.TabIndex = 6;
            this.calc_back.Text = "←";
            this.calc_back.UseVisualStyleBackColor = false;
            this.calc_back.Click += new System.EventHandler(this.calc_back_Click);
            // 
            // calc_ce
            // 
            this.calc_ce.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_ce.Location = new System.Drawing.Point(54, 100);
            this.calc_ce.Name = "calc_ce";
            this.calc_ce.Size = new System.Drawing.Size(35, 29);
            this.calc_ce.TabIndex = 7;
            this.calc_ce.Text = "CE";
            this.calc_ce.UseVisualStyleBackColor = false;
            this.calc_ce.Click += new System.EventHandler(this.calc_ce_Click);
            // 
            // calc_c
            // 
            this.calc_c.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_c.Location = new System.Drawing.Point(95, 100);
            this.calc_c.Name = "calc_c";
            this.calc_c.Size = new System.Drawing.Size(35, 29);
            this.calc_c.TabIndex = 8;
            this.calc_c.Text = "C";
            this.calc_c.UseVisualStyleBackColor = false;
            this.calc_c.Click += new System.EventHandler(this.calc_c_Click);
            // 
            // calc_plusmin
            // 
            this.calc_plusmin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_plusmin.Location = new System.Drawing.Point(136, 100);
            this.calc_plusmin.Name = "calc_plusmin";
            this.calc_plusmin.Size = new System.Drawing.Size(35, 29);
            this.calc_plusmin.TabIndex = 9;
            this.calc_plusmin.Text = "±";
            this.calc_plusmin.UseVisualStyleBackColor = false;
            // 
            // calc_root
            // 
            this.calc_root.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_root.Location = new System.Drawing.Point(177, 100);
            this.calc_root.Name = "calc_root";
            this.calc_root.Size = new System.Drawing.Size(35, 29);
            this.calc_root.TabIndex = 10;
            this.calc_root.Text = "√";
            this.calc_root.UseVisualStyleBackColor = false;
            this.calc_root.Click += new System.EventHandler(this.calc_root_Click);
            // 
            // calc_slash
            // 
            this.calc_slash.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_slash.Location = new System.Drawing.Point(136, 135);
            this.calc_slash.Name = "calc_slash";
            this.calc_slash.Size = new System.Drawing.Size(35, 29);
            this.calc_slash.TabIndex = 11;
            this.calc_slash.Text = "/";
            this.calc_slash.UseVisualStyleBackColor = false;
            this.calc_slash.Click += new System.EventHandler(this.calc_slash_Click);
            // 
            // calc_percent
            // 
            this.calc_percent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_percent.Location = new System.Drawing.Point(177, 135);
            this.calc_percent.Name = "calc_percent";
            this.calc_percent.Size = new System.Drawing.Size(35, 29);
            this.calc_percent.TabIndex = 12;
            this.calc_percent.Text = "%";
            this.calc_percent.UseVisualStyleBackColor = false;
            this.calc_percent.Click += new System.EventHandler(this.calc_percent_Click);
            // 
            // calc_asth
            // 
            this.calc_asth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_asth.Location = new System.Drawing.Point(136, 170);
            this.calc_asth.Name = "calc_asth";
            this.calc_asth.Size = new System.Drawing.Size(35, 29);
            this.calc_asth.TabIndex = 13;
            this.calc_asth.Text = "*";
            this.calc_asth.UseVisualStyleBackColor = false;
            this.calc_asth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calc_asth_MouseClick);
            // 
            // calc_1slashx
            // 
            this.calc_1slashx.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_1slashx.Location = new System.Drawing.Point(177, 170);
            this.calc_1slashx.Name = "calc_1slashx";
            this.calc_1slashx.Size = new System.Drawing.Size(35, 29);
            this.calc_1slashx.TabIndex = 14;
            this.calc_1slashx.Text = "1/x";
            this.calc_1slashx.UseVisualStyleBackColor = false;
            // 
            // calc_min
            // 
            this.calc_min.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_min.Location = new System.Drawing.Point(136, 205);
            this.calc_min.Name = "calc_min";
            this.calc_min.Size = new System.Drawing.Size(35, 29);
            this.calc_min.TabIndex = 15;
            this.calc_min.Text = "-";
            this.calc_min.UseVisualStyleBackColor = false;
            this.calc_min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calc_min_MouseClick);
            // 
            // calc_plus
            // 
            this.calc_plus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_plus.Location = new System.Drawing.Point(136, 240);
            this.calc_plus.Name = "calc_plus";
            this.calc_plus.Size = new System.Drawing.Size(35, 29);
            this.calc_plus.TabIndex = 16;
            this.calc_plus.Text = "+";
            this.calc_plus.UseVisualStyleBackColor = false;
            this.calc_plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calc_plus_MouseClick);
            // 
            // calc_equ
            // 
            this.calc_equ.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calc_equ.Location = new System.Drawing.Point(177, 205);
            this.calc_equ.Name = "calc_equ";
            this.calc_equ.Size = new System.Drawing.Size(35, 64);
            this.calc_equ.TabIndex = 17;
            this.calc_equ.Text = "=";
            this.calc_equ.UseVisualStyleBackColor = false;
            this.calc_equ.Click += new System.EventHandler(this.calc_equ_Click);
            // 
            // calc_7
            // 
            this.calc_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_7.Location = new System.Drawing.Point(13, 135);
            this.calc_7.Name = "calc_7";
            this.calc_7.Size = new System.Drawing.Size(35, 29);
            this.calc_7.TabIndex = 18;
            this.calc_7.Text = "7";
            this.calc_7.UseVisualStyleBackColor = false;
            this.calc_7.Click += new System.EventHandler(this.calc_7_Click);
            // 
            // calc_8
            // 
            this.calc_8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_8.Location = new System.Drawing.Point(54, 135);
            this.calc_8.Name = "calc_8";
            this.calc_8.Size = new System.Drawing.Size(35, 29);
            this.calc_8.TabIndex = 19;
            this.calc_8.Text = "8";
            this.calc_8.UseVisualStyleBackColor = false;
            this.calc_8.Click += new System.EventHandler(this.calc_8_Click);
            // 
            // calc_9
            // 
            this.calc_9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_9.Location = new System.Drawing.Point(95, 135);
            this.calc_9.Name = "calc_9";
            this.calc_9.Size = new System.Drawing.Size(35, 29);
            this.calc_9.TabIndex = 20;
            this.calc_9.Text = "9";
            this.calc_9.UseVisualStyleBackColor = false;
            this.calc_9.Click += new System.EventHandler(this.calc_9_Click);
            // 
            // calc_4
            // 
            this.calc_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_4.Location = new System.Drawing.Point(13, 170);
            this.calc_4.Name = "calc_4";
            this.calc_4.Size = new System.Drawing.Size(35, 29);
            this.calc_4.TabIndex = 21;
            this.calc_4.Text = "4";
            this.calc_4.UseVisualStyleBackColor = false;
            this.calc_4.Click += new System.EventHandler(this.calc_4_Click);
            // 
            // calc_5
            // 
            this.calc_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_5.Location = new System.Drawing.Point(54, 170);
            this.calc_5.Name = "calc_5";
            this.calc_5.Size = new System.Drawing.Size(35, 29);
            this.calc_5.TabIndex = 22;
            this.calc_5.Text = "5";
            this.calc_5.UseVisualStyleBackColor = false;
            this.calc_5.Click += new System.EventHandler(this.calc_5_Click);
            // 
            // calc_6
            // 
            this.calc_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_6.Location = new System.Drawing.Point(95, 170);
            this.calc_6.Name = "calc_6";
            this.calc_6.Size = new System.Drawing.Size(35, 29);
            this.calc_6.TabIndex = 23;
            this.calc_6.Text = "6";
            this.calc_6.UseVisualStyleBackColor = false;
            this.calc_6.Click += new System.EventHandler(this.calc_6_Click);
            // 
            // calc_1
            // 
            this.calc_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_1.Location = new System.Drawing.Point(13, 205);
            this.calc_1.Name = "calc_1";
            this.calc_1.Size = new System.Drawing.Size(35, 29);
            this.calc_1.TabIndex = 24;
            this.calc_1.Text = "1";
            this.calc_1.UseVisualStyleBackColor = false;
            this.calc_1.Click += new System.EventHandler(this.calc_1_Click);
            // 
            // calc_2
            // 
            this.calc_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_2.Location = new System.Drawing.Point(54, 205);
            this.calc_2.Name = "calc_2";
            this.calc_2.Size = new System.Drawing.Size(35, 29);
            this.calc_2.TabIndex = 25;
            this.calc_2.Text = "2";
            this.calc_2.UseVisualStyleBackColor = false;
            this.calc_2.Click += new System.EventHandler(this.calc_2_Click);
            // 
            // calc_3
            // 
            this.calc_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_3.Location = new System.Drawing.Point(95, 205);
            this.calc_3.Name = "calc_3";
            this.calc_3.Size = new System.Drawing.Size(35, 29);
            this.calc_3.TabIndex = 26;
            this.calc_3.Text = "3";
            this.calc_3.UseVisualStyleBackColor = false;
            this.calc_3.Click += new System.EventHandler(this.calc_3_Click);
            // 
            // calc_0
            // 
            this.calc_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_0.Location = new System.Drawing.Point(12, 240);
            this.calc_0.Name = "calc_0";
            this.calc_0.Size = new System.Drawing.Size(76, 29);
            this.calc_0.TabIndex = 27;
            this.calc_0.Text = "0";
            this.calc_0.UseVisualStyleBackColor = false;
            this.calc_0.Click += new System.EventHandler(this.calc_0_Click);
            // 
            // calc_dot
            // 
            this.calc_dot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calc_dot.Location = new System.Drawing.Point(95, 240);
            this.calc_dot.Name = "calc_dot";
            this.calc_dot.Size = new System.Drawing.Size(35, 29);
            this.calc_dot.TabIndex = 28;
            this.calc_dot.Text = ".";
            this.calc_dot.UseVisualStyleBackColor = false;
            this.calc_dot.Click += new System.EventHandler(this.button28_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(226, 283);
            this.Controls.Add(this.calc_dot);
            this.Controls.Add(this.calc_0);
            this.Controls.Add(this.calc_3);
            this.Controls.Add(this.calc_2);
            this.Controls.Add(this.calc_1);
            this.Controls.Add(this.calc_6);
            this.Controls.Add(this.calc_5);
            this.Controls.Add(this.calc_4);
            this.Controls.Add(this.calc_9);
            this.Controls.Add(this.calc_8);
            this.Controls.Add(this.calc_7);
            this.Controls.Add(this.calc_equ);
            this.Controls.Add(this.calc_plus);
            this.Controls.Add(this.calc_min);
            this.Controls.Add(this.calc_1slashx);
            this.Controls.Add(this.calc_asth);
            this.Controls.Add(this.calc_percent);
            this.Controls.Add(this.calc_slash);
            this.Controls.Add(this.calc_root);
            this.Controls.Add(this.calc_plusmin);
            this.Controls.Add(this.calc_c);
            this.Controls.Add(this.calc_ce);
            this.Controls.Add(this.calc_back);
            this.Controls.Add(this.calc_mmin);
            this.Controls.Add(this.calc_mplus);
            this.Controls.Add(this.calc_ms);
            this.Controls.Add(this.calc_mr);
            this.Controls.Add(this.calc_mc);
            this.Controls.Add(this.txt_res);
            this.Name = "Calc";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Button calc_mc;
        private System.Windows.Forms.Button calc_mr;
        private System.Windows.Forms.Button calc_ms;
        private System.Windows.Forms.Button calc_mplus;
        private System.Windows.Forms.Button calc_mmin;
        private System.Windows.Forms.Button calc_back;
        private System.Windows.Forms.Button calc_ce;
        private System.Windows.Forms.Button calc_c;
        private System.Windows.Forms.Button calc_plusmin;
        private System.Windows.Forms.Button calc_root;
        private System.Windows.Forms.Button calc_slash;
        private System.Windows.Forms.Button calc_percent;
        private System.Windows.Forms.Button calc_asth;
        private System.Windows.Forms.Button calc_1slashx;
        private System.Windows.Forms.Button calc_min;
        private System.Windows.Forms.Button calc_plus;
        private System.Windows.Forms.Button calc_equ;
        private System.Windows.Forms.Button calc_7;
        private System.Windows.Forms.Button calc_8;
        private System.Windows.Forms.Button calc_9;
        private System.Windows.Forms.Button calc_4;
        private System.Windows.Forms.Button calc_5;
        private System.Windows.Forms.Button calc_6;
        private System.Windows.Forms.Button calc_1;
        private System.Windows.Forms.Button calc_2;
        private System.Windows.Forms.Button calc_3;
        private System.Windows.Forms.Button calc_0;
        private System.Windows.Forms.Button calc_dot;
    }
}