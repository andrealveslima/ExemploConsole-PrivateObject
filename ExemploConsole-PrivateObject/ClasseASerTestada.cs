using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConsole_PrivateObject
{
    public class ClasseASerTestada
    {
        private bool MetodoPrivado()
        {
            return true;
        }
        private bool MetodoPrivado(bool parametro)
        {
            return parametro;
        }
        private string _atributoPrivado = "Teste";
        public int PropriedadeComSetterPrivado { get; private set; }
        private static string _atributoEstaticoPrivado = "Teste estático";
        private static bool MetodoEstaticoPrivado()
        {
            return false;
        }
    }
}
