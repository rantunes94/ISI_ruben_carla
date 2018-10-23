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

        private void button_calcular_Click(object sender, EventArgs e)
        {

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
    }
}
