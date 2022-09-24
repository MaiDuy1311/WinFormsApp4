namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        int a, b, c, d, e1, f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 232, 232);
            a = 100000;
            GiatUi.Text = ("100.000");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(255, 232, 232);
            b = 150000;
            VSMayLanh.Text = ("150.000");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(255, 232, 232);
            c = 200000;
            DonDep.Text = ("200.000");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(255, 232, 232);
            d = 400000;
            TongVS.Text = ("400.000");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(255, 232, 232);
            e1 = 500000;
            Khac.Text = ("500.000");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(255, 232, 232);
            f = 300000;
            NauAn.Text = ("300.000");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.BringToFront();
            panel1.SendToBack();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            groupBox1.SendToBack();
            int tt = a + b + c + d + e1 + f;
            string vnd = tt.ToString();
            ThanhToan.Text = vnd;
        }
    }
}