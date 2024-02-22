namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Process1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 1 Çalýþtý");
        }

        private void btn_Process2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem  Çalýþtý");
        }
    }
}