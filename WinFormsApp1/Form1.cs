using CoolFunctions;

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
            var calc = new SalaryCalculator();
            var s = calc.Calculate(52, 12);
            textBox1.Text = s.ToString();

        }
    }
}