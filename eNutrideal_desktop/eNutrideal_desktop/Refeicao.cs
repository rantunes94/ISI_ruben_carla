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
        public Refeicao(string restaurante, string item, string quantidade, string calorias)
        {
            this.restaurante = restaurante;
            this.item = item;
            this.quantidade = quantidade;
            this.calorias = calorias;
        }

        public string restaurante { get; }
        public string item { get; }
        public string quantidade { get; }
        public string calorias { get; }

        public override string ToString()
        {
            return "Restaurante: " + restaurante + "\t" + "Item: "+item + "\t" +"Quantidade: " +quantidade + "\t" + "Calorias: "+calorias + "\t";
        }
    }
}
