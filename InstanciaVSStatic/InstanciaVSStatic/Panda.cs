using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstanciaVSStatic
{
    class Panda
    {
        public string Name; //Campo de instância
        public static int Population; //Campo estático

        public Panda(string n) // construtor
        {
            Name = n; //Atribui o campo de instância
            Population = Population + 1; //Incrementa o campo estático Population
        }
    }
}
