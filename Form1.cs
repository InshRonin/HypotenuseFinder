using System;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace hypotenuseFinder
{
    public partial class Form1 : Form
    {
        // DLL imports for dragging the window
        [DllImport("user32.dll")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        // Constants for dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
            SetFormBorderRadius(30);
            SetPictureBoxRadius(pictureBox1, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String forAValue = textBox1.Text;
            String forBValue = textBox2.Text;

            if (forAValue == "" || forBValue == "")
            {
                MessageBox.Show("Please enter values for both A and B.");
                return;
            }

            try
            {
                double a = Convert.ToDouble(forAValue);
                double b = Convert.ToDouble(forBValue);
                double c = Math.Sqrt(a * a + b * b);
                textBox3.Text = c.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for A and B.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The entered values are too large.");
            }

        }

        private void SetPictureBoxRadius(PictureBox picBox, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(picBox.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(picBox.Width - radius, picBox.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, picBox.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            picBox.Region = new Region(path);
        }



        private void SetFormBorderRadius(int radius)
        {
            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        // Close button
        private void closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Minimize button
        private void miniApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Panel drag handler
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

    }
}
