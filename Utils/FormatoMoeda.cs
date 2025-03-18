using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Utils
{
    class FormatoMoeda
    {
        public static string Converter(double valor)
        {
            string formato = valor.ToString("R$ #,##0.00", new CultureInfo("pt-BR"));
            return formato;
        }
    }
}
