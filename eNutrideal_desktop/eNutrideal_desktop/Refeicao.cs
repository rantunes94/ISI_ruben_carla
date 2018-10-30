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
        public Refeicao()
        {
        }

        public Refeicao(string restaurante, string item, string quantidade, int calorias)
        {
            this.restaurante = restaurante;
            this.item = item;
            this.quantidade = quantidade;
            this.calorias = calorias;
        }

        public string restaurante { get; set; }
        public string item { get; set; }
        public string quantidade { get; set; }
        public int calorias { get; set; }

        public override string ToString()
        {
            return "Restaurante: " + restaurante + "\t" + "Item: "+item + "\t" +"Quantidade: " +quantidade + "\t" + "Calorias: "+calorias + "\t";
        }
    }
}
