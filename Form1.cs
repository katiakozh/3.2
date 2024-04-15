namespace _10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte n = Convert.ToByte(textBox1.Text);
                if (n == 1 || n == 2)
                {
                    textBox2.Text = "Плюс";
                }
                if (n == 3 || n == 4)
                {
                    textBox2.Text = "Минус";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
