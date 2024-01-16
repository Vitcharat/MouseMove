using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X: " + e.X.ToString() + ", Y: " + e.Y.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // แสดงกล่องโต้ตอบเลือกสี
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();

            // เปลี่ยนสีของ label1.Text
            label1.ForeColor = colorDialog.Color;
            label2.ForeColor = colorDialog.Color;
            label2.Text = colorDialog.Color.Name;
        }

    }
}
