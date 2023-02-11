namespace EJERCICIO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal nota1;
            Decimal nota2;
            Decimal nota3;
            Decimal nota4;
            Decimal suma;

            nota1 = Convert.ToDecimal(txtbox1.Text);
            nota2 = Convert.ToDecimal(txtbox2.Text);
            nota3 = Convert.ToDecimal(txtbox3.Text);
            nota4 = Convert.ToDecimal(txtbox4.Text);

            txtbox1.Clear();
            txtbox2.Clear();
            txtbox3.Clear();
            txtbox4.Clear();

            suma = (nota1 + nota2 + nota3 + nota4) / 4;

            txtbox5.Text = suma.ToString();


        }
    }
}