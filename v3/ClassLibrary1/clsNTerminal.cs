using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsNTerminal : IEquatable<clsNTerminal>
    {
        public String nome;
        public List<clsRegra> lstRegra = new List<clsRegra>();

        public clsNTerminal(String nome)
        {
            this.nome = nome;
        }

        public bool Equals(clsNTerminal other)
        {
            if (other == null) return false;
            return (this.nome.Equals(other.nome));
        }


    }


}
