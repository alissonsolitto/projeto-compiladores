using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsEstadoSRL : IEquatable<clsEstadoSRL>
    {
        public String estado;
        public List<clsAcaoSRL> lstAcao = new List<clsAcaoSRL>();

        public clsEstadoSRL(String estado)
        {
            this.estado = estado;
        }

        public bool Equals(clsEstadoSRL other)
        {
            if (other == null) return false;
            return (this.estado.Equals(other.estado));
        }


    }
}
