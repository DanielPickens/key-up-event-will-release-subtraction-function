namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            int sub;
            sub = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            textBox3.Text = Convert.ToString(sub);
            MessageBox.Show("Subtraction is performed with KeyUp Event");
 
        }
    }
}
