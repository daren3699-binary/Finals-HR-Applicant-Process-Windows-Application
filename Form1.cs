namespace FinalsHRApplicantProcessWindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            MessageBox.Show("You Entered: " + text);
        }
    }
}
