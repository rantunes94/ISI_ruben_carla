using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eNutrideal_desktop.ServiceReference1;

namespace eNutrideal_desktop
{
    public partial class CalculadoraCalorias : Form
    {

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


        public CalculadoraCalorias()
        {
            InitializeComponent();
            comboBox_genero.Items.Add(new Item("Masculino"));
            comboBox_genero.Items.Add(new Item("Feminino"));

            comboBox_atividadeFisica.Items.Add(new Item("Sedentário"));
            comboBox_atividadeFisica.Items.Add(new Item("Ligeiramente Ativo(a)"));
            comboBox_atividadeFisica.Items.Add(new Item("Moderadamente Ativo(a)"));
            comboBox_atividadeFisica.Items.Add(new Item("Muito Ativo(a)"));
            comboBox_atividadeFisica.Items.Add(new Item("Extraordinariamente Ativo(a)"));
        }

            private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new eNutrideal().Show();
        }



        //private void textbox_idade_Validating(object sender, CancelEventArgs e)
        //{
        //    if (Convert.ToInt32(textBox_idade.Text) > 78 && Convert.ToInt32(textBox_idade.Text)<19)
        //        e.Cancel = true;
        //}

        private void button_calcular_Click(object sender, EventArgs e)
        {
            // Men 10 x weight(kg) +6.25 x height(cm) – 5 x age(y) +5
            //Women 10 x weight (kg) + 6.25 x height (cm) – 5 x age (y) – 161.
            int idade = Convert.ToInt32(numericUpDown_idade.Value);
            double peso = Convert.ToDouble(numericUpDown_peso.Value);
            int altura = Convert.ToInt32(numericUpDown_altura.Value);
            string genero = comboBox_genero.Text;
            double resultado_incompleto = 0;
           
            string nivelAtividade = comboBox_atividadeFisica.Text;

            ServiceENutridealClient client = new ServiceENutridealClient();
            double resultado_final = client.CalcularCaloriasDia(idade, genero, altura, peso, nivelAtividade);
            textBox_resultado.Text = Convert.ToString(resultado_final);

            //OPERADOR && NÃO FUNCIONA - PERGUNTAR AO PROF
            /*    if ( idade > 78 && idade < 19)
                {
                    MessageBox.Show("A idade tem de estar compreendida entre os 19 e os 78 anos" + );
                    cenass
                }
            */



            /*
            if (genero.Equals("Masculino"))
            {
                
                resultado_incompleto = 10 * peso + 6.25 * altura - 5 * idade + 5;

                //10xpeso +6.25 x altura – 5 x idade + 5;
            }
            else
            {
                resultado_incompleto = 10 * peso +6.25 * altura - 5 * idade - 161;
            }


            if (nivelAtividade.Equals("Sedentário"))
            {
                resultado_final = resultado_incompleto * 1.2;
            }

            if (nivelAtividade.Equals("Ligeiramente Ativo(a)"))
            {
                resultado_final = resultado_incompleto * 1.375;
            }

            if (nivelAtividade.Equals("Moderadamente Ativo(a)"))
            {
                resultado_final = resultado_incompleto * 1.550;
            }

            if (nivelAtividade.Equals("Muito Ativo(a)"))
            {
                resultado_final = resultado_incompleto * 1.725;
            }

            if (nivelAtividade.Equals("Extraordinariamente Ativo(a)"))
            {
                resultado_final = resultado_incompleto * 1.9;
            }

            textBox_resultado.Text = Convert.ToString(resultado_final);
            */
        }

        private void comboBox_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the Value property
            Item itm = (Item)comboBox_genero.SelectedItem;
            Console.WriteLine("{0}", itm.Name);

        }

        private void CalculadoraCalorias_Load(object sender, EventArgs e)
        {
        
        }

        private void comboBox_atividadeFisica_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the Value property
            Item itm = (Item)comboBox_genero.SelectedItem;
            Console.WriteLine("{0}", itm.Name);
        }

        private void textBox_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_idade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
