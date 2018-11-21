using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eNutrideal_desktop
{
    public class Refeicao
    {

        public string restaurante { get; set; }
        public string item { get; set; }
        public string quantidade { get; set; }
        public string calorias { get; set; }

        public static List<string> listRestaurantes = new List<string>();
        public static List<string> listItems = new List<string>();
        public static List<string> listQuantidades = new List<string>();
        public static List<string> listCalorias = new List<string>();

        public Refeicao()
        {
        }

        public Refeicao(string restaurante, string item, string quantidade, string calorias)
        {
            this.restaurante = restaurante;
            this.item = item;
            this.quantidade = quantidade;
            this.calorias = calorias;
        }

        

        public override string ToString()
        {
            return "Restaurante: " + restaurante + "\t" + "Item: "+item + "\t" +"Quantidade: " +quantidade + "\t" + "Calorias: "+calorias + "\t";
        }
    }
}
