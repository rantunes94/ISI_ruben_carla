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
                    List<string> fileLines = File.ReadAllLines(nome).ToList();

                    /*
                    List<Refeicao> refeicoes = new List<Refeicao>();
                    using (StreamReader sr = new StreamReader(nome))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string str;
                            string[] strArray;
                            str = sr.ReadLine();

                            strArray = str.Split(',');
                            Refeicao currentRefeicao = new Refeicao();
                            currentRefeicao.restaurante = strArray[0];
                            //currentBook.BookName = strArray[1];
                            //currentBook.bookPrice = double.parse(strArray[2]);
                            //currentBook.bookCode = int.parse(strArray[3]);

                            //Refeicao.add(currentBook);
                        }
                    }
                    */
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
