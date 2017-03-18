using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsLerArquivo
    {
        #region Declarações
        private String[] Linhas { get; set; }
        #endregion

        #region Métodos

        public void carregarArquivo(String Caminho)
        {
            Linhas = System.IO.File.ReadAllLines(Caminho);
        }

        public String getLinha(int i)
        {
            if(i > Linhas.Length)
            {
                i = Linhas.Length - 1;
            }

            return Linhas[i];
        }

        public String[] getTexto()
        {
            return Linhas;
        }

        #endregion
    }
}
