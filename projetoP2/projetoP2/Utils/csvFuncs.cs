using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoP2.Utils
{
    public static class csvFuncs
    {
        public static void InicializarCsv(string caminhoCsv, string cabecalho)
        {
            if (!File.Exists(caminhoCsv))
            {
                using (StreamWriter sw = File.CreateText(caminhoCsv))
                {
                    sw.WriteLine(string.Join(",", cabecalho));
                }
            }
        }
    }
}
