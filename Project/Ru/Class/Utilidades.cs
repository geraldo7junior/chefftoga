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
        public static string ControleDeTela, asterisco, NomeLogin, Cpf, CpfNovo, nome, identidade, rua, numero, bairro, cidade, uf, cep, fone;

        public static int id;

        public static decimal saldo, ValorASerCobrado, credito;

        public static void Debitar()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var linq = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Usuario).ToList();

                id = linq[0];

                var SaldoAtual = (from j in context.Cartao
                                 where j.Id_Usuario == id
                                 select j.Saldo).ToList();

                saldo = SaldoAtual[0];

                if (ValorASerCobrado <= saldo)
                {

                    string strSQL = "UPDATE Cartao SET Saldo -='" + ValorASerCobrado + "' WHERE Id_Usuario=" + id + "";

                    context.ExecuteStoreCommand(strSQL);

                    var NovoSaldo = (from j in context.Cartao
                                     where j.Id_Usuario == id
                                     select j.Saldo).ToList();

                    saldo = NovoSaldo[0];

                    MessageBox.Show("Autorizado!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    MessageBox.Show("Não Autorizado! Crédito Insuficiente!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

                string strSQL = "UPDATE Cartao SET Saldo +='" + credito + "' WHERE Id_Usuario=" + id + "";
                
                context.ExecuteStoreCommand(strSQL);

                var NovoSaldo = (from j in context.Cartao
                                 where j.Id_Usuario == id
                                 select j.Saldo).ToList();

                saldo = NovoSaldo[0];

            }

        }
        
        public static void AlterarDados()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var linq = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Usuario).ToList();

                id = linq[0];

                string strSQL = "UPDATE Usuario SET Nome +='" + nome.Replace("'", "''") + "', RG='" + identidade +
                                "', Logradouro='" + rua + "', Numero='" + numero + "', Bairro='" + bairro +
                                "', Cidade='" + cidade + "',CPF='" + CpfNovo + "', UF='" + uf + "', CEP='" + cep +
                                "', Fone='" + fone + "' WHERE Id_Usuario=" + id + "";

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

                string strSQLCartao = "DELETE FROM Cartao WHERE Id_Usuario=" + id + "";                
                context.ExecuteStoreCommand(strSQLCartao);

                string strSQLUsuario = "DELETE FROM Usuario WHERE Id_Usuario=" + id + "";
                context.ExecuteStoreCommand(strSQLUsuario);
            }
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

        /*DataNasc(),Curso(),Periodo(),Bolsista()
        public static String DataNasc()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.DataNascimento).ToList();
                return item[0].ToString();
            }
        }
        
        public static String Curso()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Curso).ToList();
                return item[0];
            }
        }

        
        public static String Periodo()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Periodo).ToList();
                return item[0];
            }
        }
          
        public static String Bolsista()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Bolsista).ToList();
                return item[0];
            }
        }
        */

        public static String Saldo()
        {            
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                Cartao card = new Cartao();

                var id = (from i in context.Usuario
                            where i.CPF == Utilidades.Cpf
                            select i.Id_Usuario).ToList();
                int ID = id[0];
                
                var saldo = (from j in context.Cartao
                             where j.Id_Usuario == ID
                             select j.Saldo).ToList();
                decimal SALDO = saldo[0];

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
                return item[0];
            }
        }

        public static String Fone()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Fone).ToList();
                return item[0];
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
            if (result == 14)
                return true;
            else return false;
        }

        public static Boolean validaFone(String fone)
        {
            int result;
            result = fone.Length;
            if (result == 13)
                return true;
            else return false;
        }

        public static Boolean validaCEP(String cep)
        {
            int result;
            result = cep.Length;
            if (result == 10)
                return true;
            else return false;
        }
    }
}
