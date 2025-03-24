namespace CalculatorApp
{
    public partial class calculatorForm : Form
    {
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            String text = textDisplay.Text;
            MessageBox.Show("You entered: " + text);
        }

        private void closePButton_Click(object sender, EventArgs e)
        {

        }

        private void textDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
