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
    public partial class ApagarRefeicao : Form
    {
        public ApagarRefeicao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GestorInfCalorica().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            ServiceENutridealClient client = new ServiceENutridealClient();
            string refeicao = textBox1.Text;
            if (textBox1.Text != null && !string.IsNullOrWhiteSpace(textBox1.Text))      
            {

                    DialogResult dialogResult = MessageBox.Show("Ao concordar a refeição irá ser apagada permanentemente", "Tem a certeza que quer apagar esta refeição?", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        client.ApagarRefeicaoPorItem(refeicao);
                        MessageBox.Show("Operação efetuada com sucesso!");
                        textBox1.Clear();
                    }
                    textBox1.Clear();
            }
            else
            {
                
                MessageBox.Show("A operação não pode ser efetuada sem que introduza uma refeição primeiro");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //deveria de ser uma combo box com os item da BD ou nem por isso?
        }
    }
}
