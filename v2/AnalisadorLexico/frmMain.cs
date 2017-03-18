using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisadorLexico
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region _clsToken
        private clsToken _clsToken;
        public clsToken clsToken
        {
            get
            {
                _clsToken = _clsToken ?? new clsToken();
                return _clsToken;
            }
        }
        #endregion

        #region _clsLerArquivo
        private clsLerArquivo _clsLerArquivo;
        public clsLerArquivo clsLerArquivo
        {
            get
            {
                _clsLerArquivo = _clsLerArquivo ?? new clsLerArquivo();
                return _clsLerArquivo;
            }
        }
        #endregion

        #region _lstToken
        private List<String> _lstToken;
        public List<String> lstToken
        {
            get
            {
                _lstToken = _lstToken ?? new List<String>();
                return _lstToken;
            }
        }
        #endregion

        #region _lstCadeia
        private List<String> _lstCadeia;
        public List<String> lstCadeia
        {
            get
            {
                _lstCadeia = _lstCadeia ?? new List<String>();
                return _lstCadeia;
            }
        }
        #endregion

        #region _lstCadeiaSRL
        private List<String> _lstCadeiaSRL;
        public List<String> lstCadeiaSRL
        {
            get
            {
                _lstCadeiaSRL = _lstCadeiaSRL ?? new List<String>();
                return _lstCadeiaSRL;
            }
        }
        #endregion

        #region _lstErro
        private List<String> _lstErro;
        public List<String> lstErro
        {
            get
            {
                _lstErro = _lstErro ?? new List<String>();
                return _lstErro;
            }
        }
        #endregion

        #region _clsGramatica
        private clsGramatica _clsGramatica;
        public clsGramatica clsGramatica
        {
            get
            {
                _clsGramatica = _clsGramatica ?? new clsGramatica();
                return _clsGramatica;
            }
        }
        #endregion


        #region _clsSRL
        private clsSRL _clsSRL;
        public clsSRL clsSRL
        {
            get
            {
                _clsSRL = _clsSRL ?? new clsSRL();
                return _clsSRL;
            }
        }
        #endregion

        private string reverseString(string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;
        }

        private List<String> voltarPilha(List<String> lst, int r)
        {
            for (int i = r; i > 0; i--)
            {
                lst.RemoveAt(lst.Count - 1);
            }
            return lst;
        }

        private void analisadorSintaticoSLR()
        {
            lstErro.Add("======================= Analisador Sintatico SLR =======================");
            lstErro.Add("======== PILHA ======== \t\t\t\t ======== CADEIA ========");

            List <String> lstPilha = new List<String>();
            lstCadeiaSRL.Add("$");

            int indiceEstado = 0, indiceAcao = 0;
            string topoPilha, novoItem = String.Empty;
            string topoCadeia = String.Empty, acao = String.Empty;

            //Iniciando a pilha
            lstPilha.Add("0");

            while ((lstPilha.Count > 0) && (lstCadeiaSRL.Count > 0))
            {
                
                topoPilha = lstPilha[lstPilha.Count - 1].ToString();
                topoCadeia = lstCadeiaSRL[0].ToString();

                indiceEstado = clsSRL.lstEstadoSRL.IndexOf(new clsEstadoSRL(topoPilha));
                indiceAcao = clsSRL.lstEstadoSRL[indiceEstado].lstAcao.IndexOf(new clsAcaoSRL(topoCadeia, ""));

                acao = clsSRL.lstEstadoSRL[indiceEstado].lstAcao[indiceAcao].gera;

                #region LOG 
                String log = String.Empty;

                foreach (var item in lstPilha)
                {
                    log += item;
                }

                log = log.PadRight(100, ' ');

                foreach (var item in lstCadeiaSRL)
                {
                    log += item;
                }

                log = log.PadRight(150, ' ');
                log += acao;

                lstErro.Add(log);
                #endregion

                if (acao.Equals("OK"))
                {
                    lstErro.Add("Cadeia reconhecida com sucesso!");
                    break; //Acabou
                }
                else if (acao.Equals("@"))
                {
                    lstErro.Add("Não foi possível reconhecer a cadeia!");
                    break; // Erro
                }

                if (acao.Substring(0, 1).Equals("e")) // Empilha
                {
                    lstPilha.Add(topoCadeia);
                    lstPilha.Add(acao.Substring(1, acao.Length - 1));

                    lstCadeiaSRL.RemoveAt(0);
                }
                else // Reduz
                {
                    int reduz = 0;
                    String empilha = String.Empty;

                    if (acao.Substring(1, 1).Equals("1"))
                    {
                        reduz = 6 * 2;
                        empilha = "S";
                    }
                    else if (acao.Substring(1, 1).Equals("2"))
                    {
                        reduz = 3 * 2;
                        empilha = "S";
                    }
                    else if (acao.Substring(1, 1).Equals("3"))
                    {
                        reduz = 3 * 2;
                        empilha = "E";
                    }
                    else if (acao.Substring(1, 1).Equals("4"))
                    {
                        reduz = 1 * 2;
                        empilha = "E";
                    }
                    else if (acao.Substring(1, 1).Equals("5"))
                    {
                        reduz = 3 * 2;
                        empilha = "E";
                    }

                    for (int i = 0; i < reduz; i++)
                    {
                        lstPilha.RemoveAt(lstPilha.Count - 1);
                    }

                    topoPilha = lstPilha[lstPilha.Count - 1].ToString();
                    lstPilha.Add(empilha);

                    indiceEstado = clsSRL.lstEstadoSRL.IndexOf(new clsEstadoSRL(topoPilha));
                    indiceAcao = clsSRL.lstEstadoSRL[indiceEstado].lstAcao.IndexOf(new clsAcaoSRL(empilha, ""));

                    acao = clsSRL.lstEstadoSRL[indiceEstado].lstAcao[indiceAcao].gera;

                    lstPilha.Add(acao);
                }
            }
        }

        private void analisadorSintatico(int linha)
        {
            List<String> lstPilha = new List<String>();
            List<String> lstPilhaAnt = new List<String>();

            char[] charArr;

            int indiceNTerminal = 0, indiceRegra = 0;

            string topoPilha, novoItem = String.Empty;

            string topoCadeia = String.Empty, topoCadeiaAnt = String.Empty;


            //Iniciando a pilha
            lstPilha.Add("$");
            lstPilha.Add("E"); //Terminal que inicia a gramática

            while ((lstPilha.Count > 0) && (lstCadeia.Count > 0))
            {
                topoPilha = lstPilha[lstPilha.Count - 1].ToString();
                topoCadeia = lstCadeia[0].ToString();

                if (Regex.IsMatch(topoPilha, @"[E,T,S,G,F]")) //Verifica se é um terminal
                {
                    lstPilha.RemoveAt(lstPilha.Count - 1); //Remove o terminal

                    indiceNTerminal = clsGramatica.lstNTerminal.IndexOf(new clsNTerminal(topoPilha));
                    indiceRegra = clsGramatica.lstNTerminal[indiceNTerminal].lstRegra.IndexOf(new clsRegra(topoCadeia, ""));

                    if (indiceRegra < 0)
                    {
                        //não existe regra para esse caracter, tirar o comentario e colocar na mensagem de erro para apresentar no log
                        if (!topoCadeia.Equals(""))
                            lstErro.Add("Linha " + linha + ". Símbolo inválido: " + topoCadeia);

                        break;
                    }
                    else
                    {
                        novoItem = clsGramatica.lstNTerminal[indiceNTerminal].lstRegra[indiceRegra].gera;

                        if (Regex.IsMatch(novoItem, @"[E,T,S,G,F]")) //Verifica se é um terminal
                        {
                            novoItem = reverseString(novoItem);
                            charArr = novoItem.ToCharArray();
                            foreach (char ch in charArr)
                            {
                                lstPilha.Add(ch.ToString());
                            }
                        }
                        else
                        {
                            lstPilha.Add(novoItem);
                        }
                    }
                }
                else if (topoPilha == topoCadeia)
                {
                    topoCadeiaAnt = topoCadeia;
                    lstCadeia.RemoveAt(0);

                    lstPilhaAnt.Clear();
                    lstPilhaAnt.AddRange(lstPilha);

                    lstPilha.RemoveAt(lstPilha.Count - 1);
                }
                else if (topoPilha == "")
                {
                    lstPilhaAnt.Clear();
                    lstPilhaAnt.AddRange(lstPilha);

                    lstPilha.RemoveAt(lstPilha.Count - 1);
                }
                //else if (topoPilha == "@") //não consegue gerar a regra
                //{
                //    lstErro.Add("Linha " + linha + ". Erro sintático: " + topoCadeia);
                //    lstPilha = voltarPilha(lstPilha, novoItem.Length);
                //}
                else if (topoCadeia == "$")
                {
                    lstErro.Add("Linha " + linha + ". Erro sintático: Esperado " + topoPilha);
                    break;
                }
                else if (topoPilha == "$")
                {
                    lstErro.Add("Linha " + linha + ". Erro sintático: Símbolo " + topoCadeia + " não esperado");
                    break;
                }
                else if ((topoPilha != topoCadeia) || (topoPilha == "@"))
                {
                    lstErro.Add("Linha " + linha + ". Erro sintático: Não foi possível gerar o símbolo " + topoCadeia + " após o " + topoCadeiaAnt);
                    lstPilha = voltarPilha(lstPilha, novoItem.Length);
                }
            }
        }

        public void ExtracaoToken(String caminho)
        {
            String caracter = String.Empty;
            String token = String.Empty;
            String tokenNum = String.Empty;
            String composto = String.Empty;

            lstToken.Clear();
            lstErro.Clear();
            clsLerArquivo.carregarArquivo(caminho);
            pBar.Maximum = clsLerArquivo.getTexto().Length;
            pBar.Value = 0;

            foreach (string txt in clsLerArquivo.getTexto())
            {
                lstCadeia.Clear();
                lstCadeiaSRL.Clear();
                pBar.Value++;

                for (int i = 0; i < txt.Length; i++)
                {
                    caracter = txt[i].ToString().Trim();
                    composto = String.Empty;

                    if (caracter.Equals("#"))
                    {
                        lstToken.Add("Linha " + pBar.Value.ToString() + " \"" + txt.Substring(i, txt.Length - i).ToString().Trim() + "\" - Diretiva\n");
                        i = txt.Length;
                    }
                    else if (caracter.Equals("/"))
                    {
                        composto = caracter + txt[i + 1].ToString();

                        if (composto.Equals("//"))
                        {
                            lstToken.Add("Linha " + pBar.Value.ToString() + " \"" + txt.Substring(i, txt.Length - i).ToString().Trim() + "\" - Comentário\n");
                            i = txt.Length;
                        }
                        else
                        {
                            lstToken.Add("Linha " + pBar.Value.ToString() + " \"" + caracter + "\" - Símbolo especial\n");
                            lstCadeia.Add(caracter);
                            lstCadeiaSRL.Add(caracter);
                        }
                    }
                    else
                    {
                        if (!caracter.Equals(""))
                        {
                            if ((clsToken.existeListaEspeciais(caracter)) && (token == String.Empty))
                            {
                                if (i < txt.Length - 1)
                                    composto = caracter + txt[i + 1].ToString();

                                if (clsToken.existeListaCompostos(composto))
                                {
                                    lstToken.Add("Linha " + pBar.Value.ToString() + " \"" + composto + "\" - Símbolo especial composto\n");
                                    i++;
                                    lstCadeia.Add(composto);
                                    lstCadeiaSRL.Add(composto);
                                }
                                else
                                {
                                    lstToken.Add("Linha " + pBar.Value.ToString() + " \"" + caracter + "\" - Símbolo especial\n");
                                    lstCadeia.Add(caracter);
                                    lstCadeiaSRL.Add(caracter);
                                }
                            }
                            else if ((clsToken.existeListaNumeros(caracter)) && (token == String.Empty))
                            {
                                tokenNum += caracter;
                                if (i < txt.Length - 1)
                                    composto = txt[i + 1].ToString();

                                if (!clsToken.existeListaNumeros(composto))
                                {
                                    lstToken.Add("Linha " + pBar.Value.ToString() + " \"" + tokenNum + "\" - Constante inteira\n");
                                    tokenNum = String.Empty;
                                    lstCadeia.Add("num");
                                    lstCadeiaSRL.Add("num");
                                }
                            }
                            else
                            {
                                token += caracter;

                                if (clsToken.existeListaReservados(token))
                                {
                                    lstToken.Add("Linha " + pBar.Value.ToString() + " \"" + token + "\" - Palavra reservada\n");
                                    lstCadeiaSRL.Add(token);
                                    token = String.Empty;
                                    lstCadeia.Add(token);
                                }
                                else
                                {
                                    if (i < txt.Length - 1)
                                        composto = txt[i + 1].ToString();

                                    if ((clsToken.existeListaEspeciais(composto)) || (composto.Equals(" ")) || (composto.Equals("")))
                                    {
                                        lstToken.Add("Linha " + pBar.Value.ToString() + " \"" + token + "\" - Identificador\n");
                                        token = String.Empty;
                                        lstCadeia.Add("id");
                                        lstCadeiaSRL.Add("id");
                                    }
                                }
                            }
                        }
                    }
                }

                lstToken.Add("\n");
                lstCadeia.Add("$");

                if (lstCadeia.Count > 1) //não existe apenas o $ na lista
                {
                    analisadorSintatico(pBar.Value);
                    analisadorSintaticoSLR();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                rchArquivo.Clear();
                richTextBox1.Clear();
                richTextBox2.Clear();

                lblCaminho.Text = fd.FileName;

                clsLerArquivo.carregarArquivo(lblCaminho.Text);

                int linha = 0;

                foreach (string txt in clsLerArquivo.getTexto())
                {
                    linha++;
                    rchArquivo.AppendText("|" + linha + "| " + txt + "\n");
                }

                richTextBox1.Clear();//analisador léxico
                ExtracaoToken(lblCaminho.Text.ToString());

                for (int i = 0; i < lstToken.Count; i++)
                {
                    richTextBox1.AppendText(lstToken[i]);
                }

                for (int i = 0; i < lstErro.Count; i++)
                {
                    richTextBox2.AppendText(lstErro[i]);
                    richTextBox2.AppendText("\n");
                }
            }


        }
    }
}
