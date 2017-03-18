using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsAcaoSRL : IEquatable<clsAcaoSRL>
    {
        public String simbolo;
        public String gera;


        public clsAcaoSRL(String s, String g)
        {
            this.simbolo = s;
            this.gera = g;
        }

        public bool Equals(clsAcaoSRL other)
        {
            if (other == null) return false;
            return (this.simbolo.Equals(other.simbolo));
        }
    }
}
