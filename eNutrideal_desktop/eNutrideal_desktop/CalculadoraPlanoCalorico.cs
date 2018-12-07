using System;
using eNutrideal_desktop.ServiceReference1;
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
    public partial class CalculadoraPlanoCalorico : Form
    {
        public CalculadoraPlanoCalorico()
        {
            InitializeComponent();

            comboBox_genero.Items.Add("Masculino");
            comboBox_genero.Items.Add("Feminino");

            comboBox_atividadeFisica.Items.Add("Sedentário");
            comboBox_atividadeFisica.Items.Add("Ligeiramente Ativo(a)");
            comboBox_atividadeFisica.Items.Add("Moderadamente Ativo(a)");
            comboBox_atividadeFisica.Items.Add("Muito Ativo(a)");
            comboBox_atividadeFisica.Items.Add("Extraordinariamente Ativo(a)");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_calcular_Click(object sender, EventArgs e)
        {

            int idade = Convert.ToInt32(numericUpDown_idade.Value);
            double peso = Convert.ToDouble(numericUpDown_peso.Value);
            int altura = Convert.ToInt32(numericUpDown_altura.Value);
            string genero = comboBox_genero.Text;

            string nivelAtividade = comboBox_atividadeFisica.Text;




            ServiceENutridealClient client = new ServiceENutridealClient();
            double caloriasdia = client.CalcularCaloriasDia(idade, genero, altura, peso, nivelAtividade);

            double pesoIdeal = client.CalcularPesoIdeal(idade, altura, genero);

            textBox_calorias.Text = Convert.ToString(caloriasdia);

            textBox_pesoIdeal.Text = Convert.ToString(pesoIdeal);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new eNutrideal().Show();
        }

        private void numericUpDown_idade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_atividadeFisica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_calorias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
