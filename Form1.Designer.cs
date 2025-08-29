namespace hypotenuseFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            miniApp = new Button();
            closeApp = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            forA = new Label();
            textBox1 = new TextBox();
            forB = new Label();
            textBox2 = new TextBox();
            forC = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(miniApp);
            panel1.Controls.Add(closeApp);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-14, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 40);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // miniApp
            // 
            miniApp.ForeColor = Color.Black;
            miniApp.Image = (Image)resources.GetObject("miniApp.Image");
            miniApp.Location = new Point(334, 5);
            miniApp.Name = "miniApp";
            miniApp.Size = new Size(26, 28);
            miniApp.TabIndex = 2;
            miniApp.UseVisualStyleBackColor = true;
            miniApp.Click += miniApp_Click;
            // 
            // closeApp
            // 
            closeApp.ForeColor = Color.Black;
            closeApp.Image = (Image)resources.GetObject("closeApp.Image");
            closeApp.Location = new Point(366, 5);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(26, 28);
            closeApp.TabIndex = 1;
            closeApp.UseVisualStyleBackColor = true;
            closeApp.Click += closeApp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 10);
            label1.Name = "label1";
            label1.Size = new Size(155, 19);
            label1.TabIndex = 0;
            label1.Text = "Hypotenuse Finder ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // forA
            // 
            forA.AutoSize = true;
            forA.Location = new Point(78, 332);
            forA.Name = "forA";
            forA.Size = new Size(17, 17);
            forA.TabIndex = 2;
            forA.Text = "a";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 325);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 24);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // forB
            // 
            forB.AutoSize = true;
            forB.Location = new Point(78, 381);
            forB.Name = "forB";
            forB.Size = new Size(16, 17);
            forB.TabIndex = 4;
            forB.Text = "b";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 374);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 24);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // forC
            // 
            forC.AutoSize = true;
            forC.Location = new Point(78, 433);
            forC.Name = "forC";
            forC.Size = new Size(17, 17);
            forC.TabIndex = 6;
            forC.Text = "c";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(219, 426);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 24);
            textBox3.TabIndex = 7;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(150, 465);
            button1.Name = "button1";
            button1.Size = new Size(87, 39);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("LEMON MILK", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(155, 507);
            label3.Name = "label3";
            label3.Size = new Size(76, 11);
            label3.TabIndex = 10;
            label3.Text = "Made By : Inshaf";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("LEMON MILK", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 292);
            label2.Name = "label2";
            label2.Size = new Size(247, 17);
            label2.TabIndex = 11;
            label2.Text = "for now you can only find the \"C\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(397, 526);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(forC);
            Controls.Add(textBox2);
            Controls.Add(forB);
            Controls.Add(textBox1);
            Controls.Add(forA);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("LEMON MILK", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.InactiveBorder;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "hypotenuse Finder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button miniApp;
        private Button closeApp;
        private PictureBox pictureBox1;
        private Label forA;
        private TextBox textBox1;
        private Label forB;
        private TextBox textBox2;
        private Label forC;
        private TextBox textBox3;
        private Button button1;
        private Label label3;
        private Label label2;
    }
}
