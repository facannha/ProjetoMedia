using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMédia {
    public partial class Form2 : Form {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lApresent_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "Professor Jorge" & textSenha.Text == "ADMdiretor")
            {
                MessageBox.Show("Bem vindo Professor Jorge!");
                Form1 formmedia = new Form1();
                formmedia.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
            }
        }
    }
}
