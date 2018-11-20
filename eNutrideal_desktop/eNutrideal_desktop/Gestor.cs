using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
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

                    
                    string characterEspecial = @"\t";
                    string characterEspecial2 = @"\§";
                    Regex regex1 = new Regex(characterEspecial, RegexOptions.IgnoreCase);
                    Regex regex2 = new Regex(characterEspecial2, RegexOptions.IgnoreCase);

                    richTextBox1.Clear();
                   
                    using (StreamReader sr = new StreamReader(nome, Encoding.Default))
                    {

                        
                        while (sr.Peek() >= 0)
                        {
                            string str;
                            string[] strArray;
                            
                            str = sr.ReadLine();

                            Match match1 = regex1.Match(str);
                            string resultString = Convert.ToString(match1);

                            // este bloco de código só funciona para o calorias_restaurantes_1.txt  
                            if (resultString.Equals("\t")) {
                                strArray = str.Split('\t');
                                Refeicao currentRefeicao = new Refeicao();

                                currentRefeicao.restaurante = strArray[0];
                                currentRefeicao.item = strArray[1];
                                currentRefeicao.quantidade = strArray[2];
                                currentRefeicao.calorias = strArray[3];                      
                                richTextBox1.Text = richTextBox1.Text + "\n" + currentRefeicao.restaurante + "\t" + currentRefeicao.item + "\t" + currentRefeicao.quantidade + "\t" + currentRefeicao.calorias;
                            }
                            //FIM de "este bloco de código só funciona para o calorias_restaurantes_1.txt"


                            // Por completar 
                            else
                            {
                                Match match2 = regex2.Match(str);
                                string resultString2 = Convert.ToString(match2);
                                string strReplaced = str.Replace('§', '\n');
                                //string strReplaced2 = strReplaced.Replace("|", "\t");
                                //strArray = new[] { strReplaced2 };


                                //strArray = strReplaced2.Split('\t');
                                //strReplaced2.Split('\t');

                                //richTextBox1.Text = richTextBox1.Text + strReplaced2;


                            
                                System.IO.File.WriteAllText(@"C:\WINDOWS\TEMP\WriteText.txt", strReplaced);
                                string caminhoFicheiro = @"C:\WINDOWS\TEMP\WriteText.txt";

                               // string ficheiro =File.ReadAllText(caminhoFicheiro);

                                using (StreamReader sr2 = new StreamReader(caminhoFicheiro, Encoding.Default))
                                {
                                    while (sr2.Peek() >= 0)
                                    {
                                            string str2;
                                            string[] strArray2;
                                            str2 = sr2.ReadLine();
                            
                                      
                                            strArray2 = str2.Split('|');
                                            Refeicao currentRefeicao = new Refeicao();
                                           
                                        
                                            currentRefeicao.restaurante = strArray2[0];
                                            currentRefeicao.item = strArray2[1];
                                            currentRefeicao.quantidade = strArray2[2];
                                            currentRefeicao.calorias = strArray2[3];
                                            richTextBox1.Text = richTextBox1.Text + "\n" + currentRefeicao.restaurante + "\t" + currentRefeicao.item + "\t" + currentRefeicao.quantidade + "\t" + currentRefeicao.calorias;
                                    
    }
                                }           
                            }
                        }
                    }                
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new eNutrideal().Show();
        }

        private void Gestor_Load(object sender, EventArgs e)
        {

        }

        //para criar documento XML 
        private void createNode(string restaurante, string item, string quantidade, string calorias,
            XmlTextWriter writer)
        {
            writer.WriteStartElement("restaurante");
            writer.WriteStartElement("restaurante");
            writer.WriteString(restaurante);
            writer.WriteEndElement();
            writer.WriteStartElement("item");
            writer.WriteString(item);
            writer.WriteEndElement();
            writer.WriteStartElement("quantidade");
            writer.WriteString(quantidade);
            writer.WriteEndElement();
            writer.WriteStartElement("calorias");
            writer.WriteString(calorias);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
