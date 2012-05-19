using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ru
{
    class Utilidades
    {
        public static string ControleDeTela,asterisco;

        
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
