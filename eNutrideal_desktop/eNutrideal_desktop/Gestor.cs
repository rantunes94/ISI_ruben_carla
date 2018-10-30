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
using Newtonsoft.Json;

namespace eNutrideal_desktop
{
    public partial class Gestor : Form
    {

        private static JsonReader file;

        public Gestor()
        {
            InitializeComponent();
            
        }
        private string extension = null;

        public static T Deserialize<T>(string json)
        {
           return JsonConvert.DeserializeObject<T>(json);
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt and json files (*.txt / *.json)|*.txt;*.json";
            // "json files (*.json)|*.json";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            string texto;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                string nome = openFileDialog1.FileName;


                //Neste caso esta vai ser a minha String Json
                texto = File.ReadAllText(nome);
                extension = Path.GetExtension(nome);

                if (extension.Equals(".json"))
                {
                    richTextBox1.Clear();
                    //Deserialize the JSON text to an Refeicao list.
                    var myobjList = Deserialize<List<Refeicao>>(texto);

                    foreach (var refeicao in myobjList)
                    {
                        richTextBox1.Text = richTextBox1.Text + "\n" + Convert.ToString(refeicao);
                    }
                }

                if (extension.Equals(".txt"))
                {
                    richTextBox1.Clear();
                    // este bloco de código só funciona para o calorias_restaurantes_1.txt
                    //List<Refeicao> refeicoes = new List<Refeicao>();
                    using (StreamReader sr = new StreamReader(nome))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string str;
                            string[] strArray;
                            str = sr.ReadLine();

                            strArray = str.Split('\t');
                            Refeicao currentRefeicao = new Refeicao();
                            currentRefeicao.restaurante = strArray[0];
                            currentRefeicao.item = strArray[1];
                            currentRefeicao.quantidade = strArray[2];
                            currentRefeicao.calorias = strArray[3];


                            richTextBox1.Text = richTextBox1.Text +"\n"+ currentRefeicao.restaurante + "\t" +  currentRefeicao.item + "\t" + currentRefeicao.quantidade + "\t" + currentRefeicao.calorias;
                        }
                    }
                    //FIM de "este bloco de código só funciona para o calorias_restaurantes_1.txt"


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new eNutrideal().Show();
        }
    }
}
