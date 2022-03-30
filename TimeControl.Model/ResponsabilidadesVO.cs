using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl.Model
{
    public class ResponsabilidadesVO
    {
        /*
         * Três coisas que a classe tem:
         *   1- Atributos
         *   2- Contrutor
         *   3- Métodos
         */ 
        //Atributos ou Propriedades Automáticas
        public int Id { get; set; }
        public string Descricao { get; set; }

        private static  int contador;

        public ResponsabilidadesVO()
        {
            contador++;
        }
        public static  int RetornaContador()
        {
            return contador;
        }


    }
}
