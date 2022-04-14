namespace ProjetoMédia {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, num3 = 0, media = 0;

            num1 = double.Parse(textN1.Text);
            num2 = double.Parse(textN2.Text);
            num3 = double.Parse(textN3.Text);

            media = (num1 + num2 + num3) / 3;
            textResult.Text = textNome.Text + ", a média é: " + media.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textNome.Clear();
            textN1.Clear();
            textN2.Clear();
            textN3.Clear();
            textResult.Text = "";
        }
    }
}