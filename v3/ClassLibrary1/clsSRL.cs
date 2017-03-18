using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Tabela sintática SRL
    public class clsSRL
    {
        public List<clsEstadoSRL> lstEstadoSRL = new List<clsEstadoSRL>();

        public clsSRL()
        {
            clsEstadoSRL EstadoSRL;

            // REGRA LINHA 0
            EstadoSRL = new clsEstadoSRL("0");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "e2")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "e3"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "1"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 1
            EstadoSRL = new clsEstadoSRL("1");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "OK"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 2
            EstadoSRL = new clsEstadoSRL("2");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "e5"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "e6"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "4"));

            lstEstadoSRL.Add(EstadoSRL);



            // REGRA LINHA 3
            EstadoSRL = new clsEstadoSRL("3");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "e7"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 4
            EstadoSRL = new clsEstadoSRL("4");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "e8"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "e9"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);



            // REGRA LINHA 5
            EstadoSRL = new clsEstadoSRL("5");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "r4"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "r4"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "r4"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "r4"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 6
            EstadoSRL = new clsEstadoSRL("6");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "e10"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 7
            EstadoSRL = new clsEstadoSRL("7");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "e5"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "e6"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "11"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 8
            EstadoSRL = new clsEstadoSRL("8");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "e2")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "e3"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "12"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 9
            EstadoSRL = new clsEstadoSRL("9");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "e13"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 10
            EstadoSRL = new clsEstadoSRL("10");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "e14"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 11
            EstadoSRL = new clsEstadoSRL("11");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "r2"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "e9"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "r2"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 12
            EstadoSRL = new clsEstadoSRL("12");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "e15"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 13
            EstadoSRL = new clsEstadoSRL("13");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "r3"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "r3"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "r3"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "r3"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 14
            EstadoSRL = new clsEstadoSRL("14");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "r5"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "r5"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "r5"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "r5"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 15
            EstadoSRL = new clsEstadoSRL("15");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "e2")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "e3"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "@"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "16"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


            // REGRA LINHA 16
            EstadoSRL = new clsEstadoSRL("16");

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("if", "@")); //simbolo @ indica erro, quer dizer que a regra não gera o simbolo.
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("then", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("else", "r1"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("=", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("||", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("id", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("(", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL(")", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("$", "r1"));

            EstadoSRL.lstAcao.Add(new clsAcaoSRL("S", "@"));
            EstadoSRL.lstAcao.Add(new clsAcaoSRL("E", "@"));

            lstEstadoSRL.Add(EstadoSRL);


        }



    }
}
