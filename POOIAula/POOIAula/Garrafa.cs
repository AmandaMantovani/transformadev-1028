using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIAula
{
    //classe
    internal class Garrafa
    {
        //caracteristica -> atributo ou field ou campo
        private string cor;
        protected int capacidade;
        public string material;
        public bool termica;

        //comportamentos

        public void DeterminarTermica()
        {
            termica = true;
        }
        public void DeterminarNaoTermica()
        {
            termica = false;
        }
    }
}
