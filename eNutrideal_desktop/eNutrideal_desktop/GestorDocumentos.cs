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
using eNutrideal_desktop.ServiceReference1;
using Newtonsoft.Json;

namespace eNutrideal_desktop
{
    public partial class GestorDocumentos : Form
    {
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


            ServiceENutridealClient client = new ServiceENutridealClient();
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
                       
                        // Refeicao do server 
                        Refeicao novaRefeicao = new Refeicao();
                        novaRefeicao.Restaurante = refeicao.Restaurante;
                        novaRefeicao.Item = refeicao.Item;
                        novaRefeicao.Quantidade = refeicao.Quantidade;
                        novaRefeicao.Calorias = refeicao.Calorias;
                        client.recebeRefeicao(novaRefeicao);
                        //
                        richTextBox1.Text = richTextBox1.Text + "\n" + novaRefeicao.Restaurante + "\t" + novaRefeicao.Item + "\t" + novaRefeicao.Quantidade + "\t" + novaRefeicao.Calorias;

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
                            if (resultString.Equals("\t"))
                            {
                                strArray = str.Split('\t');

                                // Refeicao do server 
                                Refeicao novaRefeicao = new Refeicao();
                                novaRefeicao.Restaurante = strArray[0].Trim();
                                novaRefeicao.Item = strArray[1].Trim();
                                novaRefeicao.Quantidade = strArray[2].Trim();
                                novaRefeicao.Calorias = strArray[3].Trim();
                                client.recebeRefeicao(novaRefeicao);
                                //                                 
                                richTextBox1.Text = richTextBox1.Text + "\n" + novaRefeicao.Restaurante + "\t" + novaRefeicao.Item + "\t" + novaRefeicao.Quantidade + "\t" + novaRefeicao.Calorias;

                            }
                            //FIM de "este bloco de código só funciona para o calorias_restaurantes_1.txt"


                            // para o ficherio txt2
                            else
                            {
                                Match match2 = regex2.Match(str);
                                string resultString2 = Convert.ToString(match2);

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

                                        // Refeicao do server 
                                        Refeicao novaRefeicao = new Refeicao();
                                        novaRefeicao.Restaurante = strArray2[0].Trim();
                                        novaRefeicao.Item = strArray2[1].Trim();
                                        novaRefeicao.Quantidade = strArray2[2].Trim();
                                        novaRefeicao.Calorias = strArray2[3].Trim();
                                        client.recebeRefeicao(novaRefeicao);
                                        //
                                        richTextBox1.Text = richTextBox1.Text + "\n" + novaRefeicao.Restaurante + "\t" + novaRefeicao.Item + "\t" + novaRefeicao.Quantidade + "\t" + novaRefeicao.Calorias;
                                    }  
                                  sr2.Close();
                                }
                                
                                //apagar o ficheiro temporario que criei à pouco
                                File.Delete(caminhoFicheiro);
                                //FIM de  para o ficherio txt2
                            }

                        }
                        sr.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            richTextBox1.Clear();

            ///// Botão para o server adicional a informação ao refeicoes.xml
            ServiceENutridealClient client = new ServiceENutridealClient();
            if (extension.Equals(".txt") || extension.Equals(".json"))
            {
                
              
                client.addListRefeicoesToXML();
                MessageBox.Show("Operação efetuada com sucesso!");
            }
            else
            {
                MessageBox.Show("A extensão do documento não é suportada", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
