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
    public partial class GestorDocumentos : Form
    {

        //private static JsonReader file;
        //private string path = null;
        //apagar

        public GestorDocumentos()
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


                        
                        Refeicao.listRestaurantes.Add(refeicao.restaurante);
                        Refeicao.listItems.Add(refeicao.item);
                        Refeicao.listQuantidades.Add(refeicao.quantidade);
                        Refeicao.listCalorias.Add(refeicao.calorias);
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

                        
                        while (!sr.EndOfStream)
                        {
                            string str;
                            string[] strArray;
                            
                            str = sr.ReadLine();

                            Match match1 = regex1.Match(str);
                            string resultString = Convert.ToString(match1);

                            // este bloco de código só funciona para o calorias_restaurantes_1.txt  
                            if (resultString.Equals("\t")) {
                                strArray = str.Split('\t');


                                Refeicao.listRestaurantes.Add(strArray[0].Trim());
                                Refeicao.listItems.Add(strArray[1].Trim());
                                Refeicao.listQuantidades.Add(strArray[2].Trim());
                                Refeicao.listCalorias.Add(strArray[3].Trim());


                                Refeicao currentRefeicao = new Refeicao();
                                currentRefeicao.restaurante = strArray[0].Trim();
                                currentRefeicao.item = strArray[1].Trim();
                                currentRefeicao.quantidade = strArray[2].Trim();
                                currentRefeicao.calorias = strArray[3].Trim();                      
                                richTextBox1.Text = richTextBox1.Text + "\n" + currentRefeicao.restaurante + "\t" + currentRefeicao.item + "\t" + currentRefeicao.quantidade + "\t" + currentRefeicao.calorias;
            

                            }
                            //FIM de "este bloco de código só funciona para o calorias_restaurantes_1.txt"


                            // para o ficherio txt2
                            else
                            {
                               
                                Match match2 = regex2.Match(str);
                                string resultString2 = Convert.ToString(match2);

                                strArray = str.Split('§');
                               
                          
                                Refeicao currentRefeicao = new Refeicao();
                                currentRefeicao.restaurante = strArray[0].Trim();
                                currentRefeicao.item = strArray[1].Trim();
                                currentRefeicao.quantidade = strArray[2].Trim();
                                currentRefeicao.calorias = strArray[3].Trim();
                                richTextBox1.Text = richTextBox1.Text + "\n" + currentRefeicao.restaurante + "\t" + currentRefeicao.item + "\t" + currentRefeicao.quantidade + "\t" + currentRefeicao.calorias;


                                strArray = str.Split('|');

                            
                                currentRefeicao.restaurante = strArray[0].Trim();
                                currentRefeicao.item = strArray[1].Trim();
                                currentRefeicao.quantidade = strArray[2].Trim();
                                currentRefeicao.calorias = strArray[3].Trim();
                                richTextBox1.Text = richTextBox1.Text + "\n" + currentRefeicao.restaurante + "\t" + currentRefeicao.item + "\t" + currentRefeicao.quantidade + "\t" + currentRefeicao.calorias;



                                /*
                                string strReplaced = str.Replace('§', '\n');
                               
                                //Gravo um novo txt já com a string limpa
                                File.WriteAllText(@"C:\WINDOWS\TEMP\WriteText.txt", strReplaced);
                                string caminhoFicheiro = @"C:\WINDOWS\TEMP\WriteText.txt";

                                //Limpo esse txt de forma a que o stream reader não me esteja a ler espaços vazios causando problemas de matriz vazia
                                var lines = File.ReadAllLines(caminhoFicheiro).Where(arg => !string.IsNullOrWhiteSpace(arg));
                                File.WriteAllLines(caminhoFicheiro, lines);
                              

                                //abro um novo stream reader e agora apenas tenho de lidar com o ficheiro tal como lidei com ele no ficheiro 1
                                using (StreamReader sr2 = new StreamReader(caminhoFicheiro, Encoding.Default))
                                {
                                    

                                    while (sr2.Peek() != -1)
                                    {
                                            string str2;
                                            string[] strArray2;
                                            str2 = sr2.ReadLine();
                                            strArray2 = str2.Split('|');




                                        Refeicao.listRestaurantes.Add(strArray2[0].Trim());
                                        Refeicao.listItems.Add(strArray2[1].Trim());
                                        Refeicao.listQuantidades.Add(strArray2[2].Trim());
                                        Refeicao.listCalorias.Add(strArray2[3].Trim());



                                        Refeicao currentRefeicao = new Refeicao();
                                        currentRefeicao.restaurante = strArray2[0].Trim();
                                        currentRefeicao.item = strArray2[1].Trim();
                                        currentRefeicao.quantidade = strArray2[2].Trim();
                                        currentRefeicao.calorias = strArray2[3].Trim();
                                        richTextBox1.Text = richTextBox1.Text + "\n" + currentRefeicao.restaurante + "\t" + currentRefeicao.item + "\t" + currentRefeicao.quantidade + "\t" + currentRefeicao.calorias;


                                    }                               
                                }
                                //apagar o ficheiro temporario que criei à pouco
                                File.Delete(caminhoFicheiro);
                                //FIM de  para o ficherio txt2

                                */


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
            writer.WriteStartElement("refeicao");
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (extension.Equals(".txt") || extension.Equals(".json"))
            { 
            XmlTextWriter writer = new XmlTextWriter(@"C:\WINDOWS\TEMP\WriteText.xml", Encoding.UTF8);

            //string pathRestaurantes = @"C:\WINDOWS\TEMP\WriteText.xml";


            writer.WriteStartDocument(true);
            writer.Formatting = System.Xml.Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("refeicoes");

            for (int i = 0; i <= Refeicao.listRestaurantes.Count - 1; i++)
            {
                createNode(Refeicao.listRestaurantes[i], Refeicao.listItems[i], Refeicao.listQuantidades[i], Refeicao.listCalorias[i],
                    writer);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("Operação efetuada com sucesso ! ");
            }

            else
            {
                MessageBox.Show("Essa extensão não é suportada", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

         }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
