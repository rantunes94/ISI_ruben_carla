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
    public partial class eNutrideal : Form
    {
        public eNutrideal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CalculadoraCalorias().Show();
            
        }

        private void button_peso_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CalculadoraPesoIdeal().Show();
        }

        private void button_gestor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Gestor().Show();
        }
    }
}
