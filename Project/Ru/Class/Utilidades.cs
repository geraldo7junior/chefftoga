using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuBiz;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Ru
{
    class Utilidades
    {
        public static string ControleDeTela, asterisco, NomeLogin, Cpf, CpfNovo, nome, identidade, DataNasc, rua, numero, bairro, cidade, uf, cep, fone, ControleDeValidaCampos="", ErrDataNasc = "" , ErrCep = "", ErrFone = "", ControleRefeicao = "";

        public static int id,IdCard, IDCurso, IDPeriodo, TipoUser;

        public static float credito,ValorASerCobrado, saldo;

        public static DateTime DataNascFormato;

        public static bool retorno, bolsista;


        public static Boolean Debitar()
        {
            if (Bolsista() == false)
            {
                using (CheffTogaEntities context = new CheffTogaEntities())
                {

                    var SaldoAtual = (from i in context.Usuario
                                      where i.CPF == Cpf
                                      select i.Saldo).ToList();

                    saldo = float.Parse(SaldoAtual[0].ToString());

                    string StrResultado = Math.Round((saldo - ValorASerCobrado), 2).ToString();

                    float resultado = float.Parse(StrResultado);

                    if (ValorASerCobrado <= saldo)
                    {
                        string desconto = resultado.ToString().Replace(",", ".");

                        string strSQL = "UPDATE Usuario SET Saldo =" + desconto + " WHERE CPF='" + Cpf + "'";

                        context.ExecuteStoreCommand(strSQL);

                        var NovoSaldo = (from j in context.Usuario
                                         where j.CPF == Cpf
                                         select j.Saldo).ToList();

                        saldo = float.Parse(NovoSaldo[0].ToString());

                        return true;
                    }

                    else return false;
                }
            }
            else
            {
                MessageBox.Show("Entrada sem desconto! Aluno BOLSISTA!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }

        }

        public static void Creditar()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var linq = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Usuario).ToList();

                id = linq[0];

                var SaldoAtual = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Saldo).ToList();

                saldo = float.Parse(SaldoAtual[0].ToString());

                string StrResultado = Math.Round((saldo + credito), 2).ToString();

                float resultado = float.Parse(StrResultado);

                string strCredito = resultado.ToString().Replace(",", ".");

                string strSQL = "UPDATE Usuario SET Saldo =" + strCredito + " WHERE Id_Usuario=" + id;
                
                context.ExecuteStoreCommand(strSQL);

                var NovoSaldo = (from j in context.Usuario
                                 where j.CPF == Cpf
                                 select j.Saldo).ToList();

                saldo = float.Parse(NovoSaldo[0].ToString());

            }

        }

        public static Boolean VerRefeicao()
        {
            Usuario user = new Usuario();

            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var DataRef = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Data_Refeicao).ToList();
                DateTime data_refeicao = DateTime.Parse(DataRef[0].ToString());

                var VerAlmoco = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Almoco).ToList();
                bool ver_almoco = bool.Parse(VerAlmoco[0].ToString());

                var VerJantar = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Jantar).ToList();
                bool ver_jantar = bool.Parse(VerJantar[0].ToString());

                if (ControleRefeicao == "almoco")
                {
                    if ((data_refeicao.Date < DateTime.Now.Date) || (ver_almoco == false) || (data_refeicao == null))
                    {
                        retorno = false;
                    }
                    else
                    {
                        MessageBox.Show("Cartão já utilizado para Almoço!", "Não Autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        retorno = true;
                    }
                }
                
                else if (ControleRefeicao == "jantar")
                {
                    if ((data_refeicao.Date < DateTime.Now.Date) || (ver_jantar == false) || (data_refeicao == null))
                    {
                        retorno = false;
                    }
                    else
                    {
                        MessageBox.Show("Cartão já utilizado para o Jantar!", "Não Autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        retorno = true;
                    }
                }
            }

            return retorno;
        }
        
        public static void AlterarDados()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var linq = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Usuario).ToList();

                id = linq[0];

                string strSQL = "UPDATE Usuario SET Nome ='" + nome.Replace("'", "''") + "', Id_TipoUsuario= '" + TipoUser + "', RG='" + identidade +
                                "', Logradouro='" + rua + "', Numero='" + numero + "', Bairro='" + bairro +
                                "', Cidade='" + cidade + "',CPF='" + CpfNovo + "', UF='" + uf + "', CEP='" + cep +
                                "', Fone='" + fone + "', Bolsista='" + bolsista + "', Id_Curso=" + IDCurso + " WHERE Id_Usuario=" + id;

                context.ExecuteStoreCommand(strSQL);

                Cpf = CpfNovo;

                MessageBox.Show("Cadastro alterado com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public static void ExcluirCadastro()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var linq = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Usuario).ToList();

                id = linq[0];

                string strSQLCartao = "DELETE FROM Usuario WHERE Id_Usuario=" + id + "";                
                context.ExecuteStoreCommand(strSQLCartao);

                string strSQLUsuario = "DELETE FROM Usuario WHERE Id_Usuario=" + id + "";
                context.ExecuteStoreCommand(strSQLUsuario);
            }
        }

        public static Int32 GerarIdCard(int verificador)
        {
            string StrVerificador = verificador.ToString();
            string ano = DateTime.Now.Year.ToString();
            string cpf3 = Cpf.Substring(0, 3);

            IdCard = int.Parse(ano + cpf3 + StrVerificador);

            return IdCard;

        }

        public static Int32 SelecionaUsuario(bool gerente, bool cadastro, bool credito, bool entrada)
        {
            if (gerente == true) return 5;
            else if (cadastro == true) return 2;
            else if (credito == true) return 3;
            else return 4;
        }

        public static String PreencherCamposVF(bool gerente, bool cadastro, bool credito, bool entrada)
        {
            if ((gerente == false) && (cadastro == false) && (credito == false) && (entrada == false))
            {
                asterisco = "*";
            }
            else
            {
                asterisco = "";
            }

            return (asterisco);

        }

        public static String PreencherCampos(String campo)
        {
            if (campo == "")
            {
                asterisco = "*";
            }
            else
            {
                asterisco = "";
            }

            return (asterisco);

        }

        public static String Id_Card()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Card).ToList();
                return item[0].ToString();
            }
        }

        public static Int32 TipoOperador()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_TipoUsuario).ToList();
                Int32 tipo = int.Parse(item[0].ToString());

                return tipo;
            }
        }

        public static Boolean Bolsista()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Bolsista).ToList();
                return bool.Parse(item[0].ToString());
            }
        }

        public static String Nome()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Nome).ToList();
                return item[0];
            }
        }

        public static String Identidade()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.RG).ToList();
                return item[0];
            }
        }

        public static String CpF()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.CPF).ToList();
                return item[0];
            }
        }

        public static String FuncDataNasc()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.DataNascimento).ToList();
                string DataNascSpace = item[0].Replace(" ","");
                DataNasc = DataNascSpace.Replace("/", "");
                return DataNasc;
            }
        }

        public static String Curso()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var IdCurso = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Curso).ToList();
                IDCurso = int.Parse(IdCurso[0].ToString());

                var Curso = (from i in context.Curso
                             where i.IdCurso == IDCurso
                             select i.DescricaoCurso).ToList();
                string curso = Curso[0];

                return curso;
            }
        }

        public static String Periodo()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var IdPeriodo = (from i in context.Usuario
                               where i.CPF == Cpf
                               select i.Periodo).ToList();
                IDPeriodo = int.Parse(IdPeriodo[0].ToString());

                var Periodo = (from i in context.Curso
                             where i.IdCurso == IDCurso
                             select i.DescricaoCurso).ToList();
                string periodo = Periodo[0];

                return periodo;
            }
        }          

        public static String Saldo()
        {            
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                Usuario card = new Usuario();

                var meusaldo = (from i in context.Usuario
                            where i.CPF == Utilidades.Cpf
                            select i.Saldo).ToList();
                
                var SALDO = meusaldo[0];

                return SALDO.ToString();
            }
        }

        public static String Rua()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Logradouro).ToList();
                return item[0];
            }
        }

        public static String Numero()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Numero).ToList();
                return item[0];
            }
        }

        public static String Bairro()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Bairro).ToList();
                return item[0];
            }
        }

        public static String Cidade()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Cidade).ToList();
                return item[0];
            }
        }

        public static String Uf()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.UF).ToList();
                return item[0];
            }
        }

        public static String Cep()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.CEP).ToList();
                string CepPonto = item[0].Replace(".", "");
                string CepDigito = CepPonto.Replace("-", "");
                cep = CepDigito.Replace(" ", "");

                return cep;
            }
        }

        public static String FuncFone()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Fone).ToList();
                string foneParAberto = item[0].Replace("(","");
                string foneParFechado = foneParAberto.Replace(")", "");
                string foneDigito = foneParFechado.Replace("-", "");
                fone = foneDigito.Replace(" ", "");
                
                return fone;
            }
        }

        public static void ValidaCampos()
        {
            //Controle de data de nascimento
            if (Utilidades.validaData(DataNasc) == false)
            {
                ErrDataNasc = "Data de Nascimento; ";
            }
            else
            {
                ErrDataNasc = "";
                Utilidades.DataNascFormato = DateTime.Parse(DataNasc);
            }

            if (DataNascFormato > DateTime.Now)
            {
                ErrDataNasc = "Data de Nascimento; ";
            }

            //Controle de Cep
            if (validaCEP(cep) == false)
            {
                ErrCep = "CEP ;";
            }

            //Controle de fone
            if (validaFone(fone) == false)
            {
                ErrFone = "Fone";
            }

            if ((ErrDataNasc != "") || (ErrFone != "") || (ErrCep != ""))
            {
                MessageBox.Show("O(s) Campo(s): " + ErrDataNasc + ErrCep + ErrFone + " está(ão) incorreto(s)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ControleDeValidaCampos = "N";
            }
            
            //CADASTRO NOVO
            if (Utilidades.ControleDeTela == "novo")
            {
                //controle de cpf válido
                if (Utilidades.validaCPF(Utilidades.Cpf) == false)
                {
                    MessageBox.Show("CPF Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControleDeValidaCampos = "N";
                }

                //controle de cpf duplicado
                else if (Utilidades.DuploCPF(Utilidades.Cpf) == true)
                {
                    MessageBox.Show("CPF já existente na Base de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControleDeValidaCampos = "N";
                }
            }

            //ALTERAR CADASTRO
            if (Utilidades.ControleDeTela == "alterar")
            {
                //controle de cpf válido
                if (Utilidades.validaCPF(Utilidades.CpfNovo) == false)
                {
                    MessageBox.Show("CPF Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControleDeValidaCampos = "N";
                }

                //controle de cpf duplicado
                else if (Utilidades.DuploCPF(Utilidades.CpfNovo) == true)
                {
                    MessageBox.Show("CPF já existente na Base de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControleDeValidaCampos = "N";
                }

            }

        }

        public static Boolean validaData(String data)
        {
            DateTime result;
            if (DateTime.TryParse(data, out result))
                return true;
            else  return false;
        }

        public static Boolean validaCPF(String cpf)
        {
            int result;
            result = cpf.Length;
            if (result == 11)
                return true;
            else return false;
        }

        public static Boolean validaFone(String foneParaTeste)
        {
            fone = foneParaTeste.Replace(" ", "");
            int result;
            result = fone.Length;
            if (result == 13)
                return true;
            else return false;
        }

        public static Boolean validaCEP(String cepParaTeste)
        {
            cep = cepParaTeste.Replace(" ", "");
            int result;
            result = cep.Length;
            if (result == 10)
                return true;
            else return false;
        }

        public static Boolean DuploCPF(String cpfEnviado)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var list = (from i in context.Usuario
                            where i.CPF == cpfEnviado
                            select cpfEnviado).ToList();

                if ((list.ToList().Count() > 0) && (Cpf != CpfNovo))
                {
                    return true;
                }

                else return false;
            }
        }

        public static Boolean ErrAluno(string cpf)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var linq = (from i in context.Usuario
                            where i.CPF == cpf
                            select i.Id_TipoUsuario).ToList();

                if ((linq.ToList().Count() == 1) && (linq[0] != 1))
                {
                    return true;
                }
                else return false;

            }
        }

        public static Boolean ErrOperador(string cpf)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var linq = (from i in context.Usuario
                            where i.CPF == cpf
                            select i.Id_TipoUsuario).ToList();

                if ((linq.ToList().Count() == 1) && (linq[0] == 1))
                {
                    return true;
                }
                else return false;

            }
        }
    }
}
