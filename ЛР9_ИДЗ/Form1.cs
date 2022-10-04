namespace ЛР9_ИДЗ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox2.Text);
            double y = double.Parse(textBox3.Text);
            int n = int.Parse((string)listBox1.SelectedItem);
            int k = int.Parse((string)listBox2.SelectedItem);
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    result += (Math.Sin(y * x) + i * y) / ((i + 1) * (j + 2));
                }
            }
            textBox1.Text = result.ToString();
        }
    }
}