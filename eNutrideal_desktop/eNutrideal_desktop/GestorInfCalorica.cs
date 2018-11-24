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
    public partial class GestorInfCalorica : Form
    {
        public GestorInfCalorica()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new eNutrideal().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdicionarRefeicao().Show();
        }
    }
}
