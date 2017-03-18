using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsToken
    {
        #region Declarações
        private List<String> lstLetras     = new List<String>();
        private List<String> lstNumeros    = new List<String>();
        private List<String> lstEspeciais  = new List<String>();
        private List<String> lstCompostos  = new List<String>();
        private List<String> lstReservados = new List<String>();
        #endregion

        #region Construtor
        public clsToken()
        {
            carregaListaLetra(lstLetras);
            carregaListaNumero(lstNumeros);
            carregaListaEspecial(lstEspeciais);
            carregaListaCompostos(lstCompostos);
            carregaListaReservados(lstReservados);
        }
        #endregion

        #region Métodos
        public Boolean existeListaLetras(String s)
        {
            return (lstLetras.Contains(s));
        }

        public Boolean existeListaNumeros(String s)
        {
            return (lstNumeros.Contains(s));
        }

        public Boolean existeListaEspeciais(String s)
        {
            return (lstEspeciais.Contains(s));
        }

        public Boolean existeListaCompostos(String s)
        {
            return (lstCompostos.Contains(s));
        }

        public Boolean existeListaReservados(String s)
        {
            return (lstReservados.Contains(s));
        }

        private void carregaListaLetra(List<String> l)
        {
            l.Add("A");
            l.Add("B");
            l.Add("C");
            l.Add("D");
            l.Add("E");
            l.Add("F");
            l.Add("G");
            l.Add("H");
            l.Add("I");
            l.Add("J");
            l.Add("K");
            l.Add("L");
            l.Add("M");
            l.Add("N");
            l.Add("O");
            l.Add("P");
            l.Add("Q");
            l.Add("R");
            l.Add("S");
            l.Add("T");
            l.Add("U");
            l.Add("V");
            l.Add("W");
            l.Add("X");
            l.Add("Y");
            l.Add("Z");
        }

        private void carregaListaNumero(List<String> l)
        {
            l.Add("0");
            l.Add("1");
            l.Add("2");
            l.Add("3");
            l.Add("4");
            l.Add("5");
            l.Add("6");
            l.Add("7");
            l.Add("8");
            l.Add("9");
        }

        private void carregaListaEspecial(List<String> l)
        {
            l.Add(".");
            l.Add(",");
            l.Add(";");
            l.Add("(");
            l.Add(")");
            l.Add("[");
            l.Add("]");
            l.Add("{");
            l.Add("}");
            l.Add(":");
            l.Add("+");
            l.Add("<");
            l.Add(">");
            l.Add("-");
            l.Add("=");
            l.Add("*");
            l.Add("%");
            l.Add("\"");
            l.Add("'");
            l.Add("&");
            l.Add("|");
        }

        private void carregaListaCompostos(List<String> l)
        {
            l.Add("++");
            l.Add("--");
            l.Add(">=");
            l.Add("<=");
            l.Add("+=");
            l.Add("-=");
            l.Add("*=");
            l.Add("/=");
            l.Add("==");
            l.Add("%=");
            l.Add("&&");
            l.Add("||");
            l.Add(":=");
        }
        
        private void carregaListaReservados(List<String> l)
        {
            l.Add("auto");
            l.Add("break");
            l.Add("case");
            l.Add("char");
            l.Add("const");
            l.Add("continue");

            l.Add("default");
            l.Add("do");

            l.Add("double");
            l.Add("else");
            l.Add("enum");
            l.Add("extern");
            l.Add("float");
            l.Add("for");
            l.Add("goto");
            l.Add("if");
            l.Add("then");

            l.Add("int");
            l.Add("long");
            l.Add("register");

            l.Add("return");
            l.Add("short");
            l.Add("signed");
            l.Add("sizeof");
            l.Add("static");

            l.Add("struct");
            l.Add("switch");
            l.Add("typedef");
            l.Add("union");
            l.Add("unsigned");
            l.Add("void");
            l.Add("volatile");

            l.Add("PROGRAM");
            l.Add("VAR");
            l.Add("INTEGER");
            l.Add("READ");
            l.Add("WRITE");

            l.Add("WHILE");
            l.Add("DO");
            l.Add("IF");
            l.Add("THEN");
            l.Add("ELSE");
            l.Add("BEGIN");
            l.Add("END");
        }

        #endregion
    }
}
