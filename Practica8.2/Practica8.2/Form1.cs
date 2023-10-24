using Practica8._2.Entities;

namespace Practica8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Matematico gus = new();
        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;
            string resultado = "";
            foreach (var item in gus.SumarStack(num1, num2))
            {
                resultado += item.ToString();
            }
            label2.Text = resultado;

            textBox1.Clear();
            textBox2.Clear();
            label2.Visible = true;

        }
    }
}