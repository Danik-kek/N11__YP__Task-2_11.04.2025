namespace task2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.main.Controls.Count; i++)
            {
                if ((Form1.main.Controls[i] is TextBox) &&
                    (Form1.main.Controls[i].Name == "textBox1"))
                {
                    Form1.main.Controls[i].Text = this.textBox1.Text;
                    break;
                }
            }
        }
    }
}