using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuBiz;

namespace Ru
{
    class Utilidades
    {
        public static string ControleDeTela, asterisco, NomeLogin, Cpf;
    
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

        /*
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
        
        public static String Saldo()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select ).ToList();
                return item[0];
            }
        }
        
        */

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
