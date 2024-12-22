namespace Score_System
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textGrade = new TextBox();
            textAverage = new TextBox();
            textTotal = new TextBox();
            textUnknown3 = new TextBox();
            textUnknown2 = new TextBox();
            textUnknown1 = new TextBox();
            textName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 50F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(367, 34);
            label1.Name = "label1";
            label1.Size = new Size(290, 102);
            label1.TabIndex = 0;
            label1.Text = "Scores";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.bg_image;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(textGrade);
            groupBox1.Controls.Add(textAverage);
            groupBox1.Controls.Add(textTotal);
            groupBox1.Controls.Add(textUnknown3);
            groupBox1.Controls.Add(textUnknown2);
            groupBox1.Controls.Add(textUnknown1);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(130, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(732, 519);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quizlet";
            // 
            // textGrade
            // 
            textGrade.BackColor = SystemColors.GradientActiveCaption;
            textGrade.Font = new Font("Bahnschrift SemiCondensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textGrade.Location = new Point(278, 376);
            textGrade.Name = "textGrade";
            textGrade.Size = new Size(343, 38);
            textGrade.TabIndex = 13;
            textGrade.TextAlign = HorizontalAlignment.Center;
            // 
            // textAverage
            // 
            textAverage.BackColor = SystemColors.GradientActiveCaption;
            textAverage.Font = new Font("Bahnschrift SemiCondensed", 15F);
            textAverage.Location = new Point(278, 333);
            textAverage.Name = "textAverage";
            textAverage.Size = new Size(343, 38);
            textAverage.TabIndex = 12;
            textAverage.TextAlign = HorizontalAlignment.Center;
            textAverage.TextChanged += textAverage_TextChanged;
            // 
            // textTotal
            // 
            textTotal.BackColor = SystemColors.GradientActiveCaption;
            textTotal.Font = new Font("Bahnschrift SemiCondensed", 15F);
            textTotal.Location = new Point(278, 291);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(343, 38);
            textTotal.TabIndex = 11;
            textTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // textUnknown3
            // 
            textUnknown3.BackColor = SystemColors.GradientActiveCaption;
            textUnknown3.Font = new Font("Bahnschrift SemiCondensed", 15F);
            textUnknown3.Location = new Point(278, 232);
            textUnknown3.Name = "textUnknown3";
            textUnknown3.Size = new Size(343, 38);
            textUnknown3.TabIndex = 10;
            textUnknown3.TextAlign = HorizontalAlignment.Center;
            // 
            // textUnknown2
            // 
            textUnknown2.BackColor = SystemColors.GradientActiveCaption;
            textUnknown2.Font = new Font("Bahnschrift SemiCondensed", 15F);
            textUnknown2.Location = new Point(278, 191);
            textUnknown2.Name = "textUnknown2";
            textUnknown2.Size = new Size(343, 38);
            textUnknown2.TabIndex = 9;
            textUnknown2.TextAlign = HorizontalAlignment.Center;
            // 
            // textUnknown1
            // 
            textUnknown1.BackColor = SystemColors.GradientActiveCaption;
            textUnknown1.Font = new Font("Bahnschrift SemiCondensed", 15F);
            textUnknown1.Location = new Point(278, 150);
            textUnknown1.Name = "textUnknown1";
            textUnknown1.Size = new Size(343, 38);
            textUnknown1.TabIndex = 8;
            textUnknown1.TextAlign = HorizontalAlignment.Center;
            // 
            // textName
            // 
            textName.BackColor = SystemColors.GradientActiveCaption;
            textName.Font = new Font("Bahnschrift SemiCondensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.Location = new Point(278, 96);
            textName.Name = "textName";
            textName.Size = new Size(343, 38);
            textName.TabIndex = 7;
            textName.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(65, 384);
            label8.Name = "label8";
            label8.Size = new Size(77, 30);
            label8.TabIndex = 6;
            label8.Text = "Grade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(65, 341);
            label7.Name = "label7";
            label7.Size = new Size(103, 30);
            label7.TabIndex = 5;
            label7.Text = "Average";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(65, 299);
            label6.Name = "label6";
            label6.Size = new Size(69, 30);
            label6.TabIndex = 4;
            label6.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(63, 199);
            label5.Name = "label5";
            label5.Size = new Size(148, 30);
            label5.TabIndex = 3;
            label5.Text = "(Unknown2)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(64, 240);
            label4.Name = "label4";
            label4.Size = new Size(148, 30);
            label4.TabIndex = 2;
            label4.Text = "(Unknown3)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(65, 158);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 1;
            label3.Text = "(Unknown1)";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(63, 104);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(408, 675);
            button1.Name = "button1";
            button1.Size = new Size(207, 45);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.outer_bg_image;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1041, 819);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Score System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox textName;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textGrade;
        private TextBox textAverage;
        private TextBox textTotal;
        private TextBox textUnknown3;
        private TextBox textUnknown2;
        private TextBox textUnknown1;
        private Button button1;
    }
}
