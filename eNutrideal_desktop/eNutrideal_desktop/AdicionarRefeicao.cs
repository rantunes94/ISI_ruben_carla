using eNutrideal_desktop.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNutrideal_desktop
{
    public partial class AdicionarRefeicao : Form
    {
        public AdicionarRefeicao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GestorRefeicoes().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceENutridealClient client = new ServiceENutridealClient();

            string restaurante = textBox1.Text;
            string item = textBox2.Text;
            string quantidade = textBox3.Text;
            string calorias = textBox4.Text;

            client.CriaXML(restaurante, item, quantidade, calorias);

            MessageBox.Show("Operação efetuada com sucesso!");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
