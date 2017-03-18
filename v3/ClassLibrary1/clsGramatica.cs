using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsGramatica
    {
        public List<clsNTerminal> lstNTerminal = new List<clsNTerminal>();

        //Preencher toda a gramática default.
        public clsGramatica()
        {
            clsNTerminal NTerminal;

            //Regra para o não terminal E
            NTerminal  = new clsNTerminal("E");

            NTerminal.lstRegra.Add(new clsRegra("+", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            NTerminal.lstRegra.Add(new clsRegra("-", "@"));
            NTerminal.lstRegra.Add(new clsRegra("*", "@"));
            NTerminal.lstRegra.Add(new clsRegra("/", "@"));
            NTerminal.lstRegra.Add(new clsRegra("id", "TS"));
            NTerminal.lstRegra.Add(new clsRegra("num", "TS"));
            NTerminal.lstRegra.Add(new clsRegra("(", "TS"));
            NTerminal.lstRegra.Add(new clsRegra(")", "@"));
            NTerminal.lstRegra.Add(new clsRegra("$", "@"));

            lstNTerminal.Add(NTerminal);

            //Regra para o não terminal T
            NTerminal = new clsNTerminal("T");

            NTerminal.lstRegra.Add(new clsRegra("+", "@"));
            NTerminal.lstRegra.Add(new clsRegra("-", "@"));
            NTerminal.lstRegra.Add(new clsRegra("*", "@"));
            NTerminal.lstRegra.Add(new clsRegra("/", "@"));
            NTerminal.lstRegra.Add(new clsRegra("id", "FG"));
            NTerminal.lstRegra.Add(new clsRegra("num", "FG"));
            NTerminal.lstRegra.Add(new clsRegra("(", "FG"));
            NTerminal.lstRegra.Add(new clsRegra(")", "@"));
            NTerminal.lstRegra.Add(new clsRegra("$", "@"));

            lstNTerminal.Add(NTerminal);

            //Regra para o não terminal S
            NTerminal = new clsNTerminal("S");

            NTerminal.lstRegra.Add(new clsRegra("+", "+TS"));
            NTerminal.lstRegra.Add(new clsRegra("-", "-TS"));
            NTerminal.lstRegra.Add(new clsRegra("*", "@"));
            NTerminal.lstRegra.Add(new clsRegra("/", "@"));
            NTerminal.lstRegra.Add(new clsRegra("id", "@"));
            NTerminal.lstRegra.Add(new clsRegra("num", "@"));
            NTerminal.lstRegra.Add(new clsRegra("(", "@"));
            NTerminal.lstRegra.Add(new clsRegra(")", ""));
            NTerminal.lstRegra.Add(new clsRegra("$", ""));

            lstNTerminal.Add(NTerminal);

            //Regra para o não terminal G
            NTerminal = new clsNTerminal("G");

            NTerminal.lstRegra.Add(new clsRegra("+", ""));
            NTerminal.lstRegra.Add(new clsRegra("-", ""));
            NTerminal.lstRegra.Add(new clsRegra("*", "*FG"));
            NTerminal.lstRegra.Add(new clsRegra("/", "/FG"));
            NTerminal.lstRegra.Add(new clsRegra("id", "@"));
            NTerminal.lstRegra.Add(new clsRegra("num", "@"));
            NTerminal.lstRegra.Add(new clsRegra("(", "@"));
            NTerminal.lstRegra.Add(new clsRegra(")", ""));
            NTerminal.lstRegra.Add(new clsRegra("$", ""));

            lstNTerminal.Add(NTerminal);

            //Regra para o não terminal F
            NTerminal = new clsNTerminal("F");

            NTerminal.lstRegra.Add(new clsRegra("+", "@"));
            NTerminal.lstRegra.Add(new clsRegra("-", "@"));
            NTerminal.lstRegra.Add(new clsRegra("*", "@"));
            NTerminal.lstRegra.Add(new clsRegra("/", "@"));
            NTerminal.lstRegra.Add(new clsRegra("id", "id"));
            NTerminal.lstRegra.Add(new clsRegra("num", "num"));
            NTerminal.lstRegra.Add(new clsRegra("(", "(E)"));
            NTerminal.lstRegra.Add(new clsRegra(")", "(E)"));
            NTerminal.lstRegra.Add(new clsRegra("$", "@"));

            lstNTerminal.Add(NTerminal);

        }
    }
}
