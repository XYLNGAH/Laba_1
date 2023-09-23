namespace Laba_1
{
    partial class Form4
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
            panel1 = new Panel();
            button1 = new Button();
            TextBoxH = new TextBox();
            TextBoxXmax = new TextBox();
            TextBoxXmin = new TextBox();
            TextBoxA = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TextBoxH);
            panel1.Controls.Add(TextBoxXmax);
            panel1.Controls.Add(TextBoxXmin);
            panel1.Controls.Add(TextBoxA);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 787);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 272);
            button1.Name = "button1";
            button1.Size = new Size(341, 42);
            button1.TabIndex = 18;
            button1.Text = "Построить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TextBoxH
            // 
            TextBoxH.Location = new Point(94, 200);
            TextBoxH.Name = "TextBoxH";
            TextBoxH.Size = new Size(247, 33);
            TextBoxH.TabIndex = 17;
            TextBoxH.Text = "0,001";
            // 
            // TextBoxXmax
            // 
            TextBoxXmax.Location = new Point(94, 148);
            TextBoxXmax.Name = "TextBoxXmax";
            TextBoxXmax.Size = new Size(247, 33);
            TextBoxXmax.TabIndex = 16;
            TextBoxXmax.Text = "10";
            // 
            // TextBoxXmin
            // 
            TextBoxXmin.Location = new Point(94, 100);
            TextBoxXmin.Name = "TextBoxXmin";
            TextBoxXmin.Size = new Size(247, 33);
            TextBoxXmin.TabIndex = 15;
            TextBoxXmin.Text = "-10";
            // 
            // TextBoxA
            // 
            TextBoxA.Location = new Point(94, 53);
            TextBoxA.Name = "TextBoxA";
            TextBoxA.Size = new Size(247, 33);
            TextBoxA.TabIndex = 14;
            TextBoxA.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 200);
            label5.Name = "label5";
            label5.Size = new Size(29, 25);
            label5.TabIndex = 13;
            label5.Text = "H:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 148);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 12;
            label4.Text = "Xmax:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 100);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 11;
            label3.Text = "Xmin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(26, 25);
            label2.TabIndex = 10;
            label2.Text = "a:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 25);
            label1.TabIndex = 9;
            label1.Text = "f(x)=ae^-4+aln(x+50)+a✓(x+50)^5";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(347, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(789, 787);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(789, 787);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 787);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form4";
            Text = "Form4";
            ResizeEnd += Form4_ResizeEnd;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox TextBoxH;
        private TextBox TextBoxXmax;
        private TextBox TextBoxXmin;
        private TextBox TextBoxA;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}