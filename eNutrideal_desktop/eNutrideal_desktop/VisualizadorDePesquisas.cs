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
    public partial class VisualizadorDePesquisas : Form
    {
        public VisualizadorDePesquisas()
        {
            InitializeComponent();
            comboBox_tipoPesquisa.Items.Add(new Item("Restaurante"));
            comboBox_tipoPesquisa.Items.Add(new Item("Refeição"));
        }


        private class Item
        {
            public string Name;

            public Item(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GestorInfCalorica().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceENutridealClient client = new ServiceENutridealClient();
            string tipoPesquisa = comboBox_tipoPesquisa.Text;
            string pesquisa = textBox1.Text;

            if (tipoPesquisa.Equals("Restaurante"))
            {
                ServiceReference1.Refeicao[] refeicoesRestaurante = client.GetRefeicaoPorRestaurante(pesquisa);
                string res = "";
                foreach (ServiceReference1.Refeicao r in refeicoesRestaurante)
                {
                    res += r.Restaurante + ", " + r.Item + ", " + r.Quantidade + ", " + r.Calorias + Environment.NewLine;
                }
                richTextBox1.Text = res;
            }
            else
            {
                ServiceReference1.Refeicao[] refeicoesItem = client.GetRefeicaoPorItem(pesquisa);
                string res = "";
                foreach (ServiceReference1.Refeicao r in refeicoesItem)
                {
                    res += r.Restaurante + ", " + r.Item + ", " + r.Quantidade + ", " + r.Calorias + Environment.NewLine;
                }
                richTextBox1.Text = res;
            }
           
        }

        private void VisualizadorDePesquisas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceENutridealClient client = new ServiceENutridealClient();

            ServiceReference1.Refeicao[] refeicoes = client.GetRefeicao();

            string res = "";
            foreach (ServiceReference1.Refeicao r in refeicoes)
            {
                res += r.Restaurante + ", " + r.Item + ", " + r.Quantidade + ", " + r.Calorias + Environment.NewLine;
            }
            richTextBox1.Text = res;


        }
    }
}
