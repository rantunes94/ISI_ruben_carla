using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNutrideal_desktop
{
    public partial class Gestor : Form
    {
        
        public Gestor()
        {
            InitializeComponent();
        }

        public object JsonConvert { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            string texto;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;

                string nome = openFileDialog1.FileName;

                texto = File.ReadAllText(nome);
            }


            /*


            //Deserialize the JSON text to an Employee list.
            var myobjList = JsonConvert.DeserializeObject<List<Refeicao>>(nome);

            //Print the resulting Employee list to the console
            Console.WriteLine("The content of the JSON file deserialized is: \n");
            foreach (var refeicao in myobjList)
            {
                Console.WriteLine(employee);
                
            }
            Console.ReadLine();
            */

        }
    }
}
