namespace task2
{
    public partial class Form1 : Form
    {
        public static Control main;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            main = this;
            f2.Show();
            f2.textBox1.Text = this.textBox1.Text;
        }
    }
}
