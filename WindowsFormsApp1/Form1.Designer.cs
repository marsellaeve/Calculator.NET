namespace WindowsFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd0 = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmdsqrt = new System.Windows.Forms.Button();
            this.cmdequal = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdadd = new System.Windows.Forms.Button();
            this.cmdmultiply = new System.Windows.Forms.Button();
            this.cmdsquare = new System.Windows.Forms.Button();
            this.cmdcos = new System.Windows.Forms.Button();
            this.cmdsin = new System.Windows.Forms.Button();
            this.cmdtan = new System.Windows.Forms.Button();
            this.cmdsubtract = new System.Windows.Forms.Button();
            this.cmddivide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(31, 50);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(52, 45);
            this.cmd0.TabIndex = 0;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(31, 11);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(400, 33);
            this.txtbox.TabIndex = 1;
            this.txtbox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(89, 50);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(52, 45);
            this.cmd1.TabIndex = 2;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(147, 50);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(52, 45);
            this.cmd2.TabIndex = 3;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(205, 50);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(52, 45);
            this.cmd3.TabIndex = 4;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(263, 50);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(52, 45);
            this.cmd4.TabIndex = 5;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(31, 101);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(52, 45);
            this.cmd5.TabIndex = 6;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(89, 101);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(52, 45);
            this.cmd6.TabIndex = 7;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(147, 101);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(52, 45);
            this.cmd7.TabIndex = 8;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(205, 101);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(52, 45);
            this.cmd8.TabIndex = 9;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(263, 101);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(52, 45);
            this.cmd9.TabIndex = 10;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmdsqrt
            // 
            this.cmdsqrt.Location = new System.Drawing.Point(89, 152);
            this.cmdsqrt.Name = "cmdsqrt";
            this.cmdsqrt.Size = new System.Drawing.Size(52, 45);
            this.cmdsqrt.TabIndex = 11;
            this.cmdsqrt.Text = "sqrt";
            this.cmdsqrt.UseVisualStyleBackColor = true;
            this.cmdsqrt.Click += new System.EventHandler(this.cmdsqrt_Click);
            // 
            // cmdequal
            // 
            this.cmdequal.Location = new System.Drawing.Point(321, 50);
            this.cmdequal.Name = "cmdequal";
            this.cmdequal.Size = new System.Drawing.Size(52, 45);
            this.cmdequal.TabIndex = 12;
            this.cmdequal.Text = "=";
            this.cmdequal.UseVisualStyleBackColor = true;
            this.cmdequal.Click += new System.EventHandler(this.cmdequal_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.Location = new System.Drawing.Point(379, 50);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(52, 45);
            this.cmdclear.TabIndex = 13;
            this.cmdclear.Text = "C";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdadd
            // 
            this.cmdadd.Location = new System.Drawing.Point(321, 101);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(52, 45);
            this.cmdadd.TabIndex = 14;
            this.cmdadd.Text = "+";
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // cmdmultiply
            // 
            this.cmdmultiply.Location = new System.Drawing.Point(379, 101);
            this.cmdmultiply.Name = "cmdmultiply";
            this.cmdmultiply.Size = new System.Drawing.Size(52, 45);
            this.cmdmultiply.TabIndex = 15;
            this.cmdmultiply.Text = "*";
            this.cmdmultiply.UseVisualStyleBackColor = true;
            this.cmdmultiply.Click += new System.EventHandler(this.cmdmultiply_Click);
            // 
            // cmdsquare
            // 
            this.cmdsquare.Location = new System.Drawing.Point(31, 152);
            this.cmdsquare.Name = "cmdsquare";
            this.cmdsquare.Size = new System.Drawing.Size(52, 45);
            this.cmdsquare.TabIndex = 16;
            this.cmdsquare.Text = "X2";
            this.cmdsquare.UseVisualStyleBackColor = true;
            this.cmdsquare.Click += new System.EventHandler(this.cmdsquare_Click);
            // 
            // cmdcos
            // 
            this.cmdcos.Location = new System.Drawing.Point(147, 152);
            this.cmdcos.Name = "cmdcos";
            this.cmdcos.Size = new System.Drawing.Size(52, 45);
            this.cmdcos.TabIndex = 17;
            this.cmdcos.Text = "cos";
            this.cmdcos.UseVisualStyleBackColor = true;
            this.cmdcos.Click += new System.EventHandler(this.cmdcos_Click);
            // 
            // cmdsin
            // 
            this.cmdsin.Location = new System.Drawing.Point(205, 152);
            this.cmdsin.Name = "cmdsin";
            this.cmdsin.Size = new System.Drawing.Size(52, 45);
            this.cmdsin.TabIndex = 18;
            this.cmdsin.Text = "sin";
            this.cmdsin.UseVisualStyleBackColor = true;
            this.cmdsin.Click += new System.EventHandler(this.cmdsin_Click);
            // 
            // cmdtan
            // 
            this.cmdtan.Location = new System.Drawing.Point(263, 152);
            this.cmdtan.Name = "cmdtan";
            this.cmdtan.Size = new System.Drawing.Size(52, 45);
            this.cmdtan.TabIndex = 19;
            this.cmdtan.Text = "tan";
            this.cmdtan.UseVisualStyleBackColor = true;
            this.cmdtan.Click += new System.EventHandler(this.cmdtan_Click);
            // 
            // cmdsubtract
            // 
            this.cmdsubtract.Location = new System.Drawing.Point(321, 152);
            this.cmdsubtract.Name = "cmdsubtract";
            this.cmdsubtract.Size = new System.Drawing.Size(52, 45);
            this.cmdsubtract.TabIndex = 20;
            this.cmdsubtract.Text = "-";
            this.cmdsubtract.UseVisualStyleBackColor = true;
            this.cmdsubtract.Click += new System.EventHandler(this.cmdsubtract_Click);
            // 
            // cmddivide
            // 
            this.cmddivide.Location = new System.Drawing.Point(379, 152);
            this.cmddivide.Name = "cmddivide";
            this.cmddivide.Size = new System.Drawing.Size(52, 45);
            this.cmddivide.TabIndex = 21;
            this.cmddivide.Text = "/";
            this.cmddivide.UseVisualStyleBackColor = true;
            this.cmddivide.Click += new System.EventHandler(this.cmddivide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Made by Evelyn Tjitrodjojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "05111840000099";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmddivide);
            this.Controls.Add(this.cmdsubtract);
            this.Controls.Add(this.cmdtan);
            this.Controls.Add(this.cmdsin);
            this.Controls.Add(this.cmdcos);
            this.Controls.Add(this.cmdsquare);
            this.Controls.Add(this.cmdmultiply);
            this.Controls.Add(this.cmdadd);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.cmdequal);
            this.Controls.Add(this.cmdsqrt);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.cmd0);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmdsqrt;
        private System.Windows.Forms.Button cmdequal;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdadd;
        private System.Windows.Forms.Button cmdmultiply;
        private System.Windows.Forms.Button cmdsquare;
        private System.Windows.Forms.Button cmdcos;
        private System.Windows.Forms.Button cmdsin;
        private System.Windows.Forms.Button cmdtan;
        private System.Windows.Forms.Button cmdsubtract;
        private System.Windows.Forms.Button cmddivide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

