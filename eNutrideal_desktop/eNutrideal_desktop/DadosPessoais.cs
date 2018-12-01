using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNutrideal_desktop
{
    class DadosPessoais
    {
        //NAO SEI SE É NECESSÁRIO 

        public int idade { get; set; }
        

        public DadosPessoais()
        {
        }

        public DadosPessoais(int idade)
        {
            this.idade = idade;
            
        }



        public override string ToString()
        {
            return "Idade: " + idade + "\t";
                //+ "Item: " + item + "\t"
                //+ "Quantidade: " + quantidade + "\t"
                //+ "Calorias: " + calorias + "\t";
        }
    }
}
