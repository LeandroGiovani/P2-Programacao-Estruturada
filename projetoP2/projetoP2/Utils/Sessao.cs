using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoP2.Utils
{
    public static class Sessao
    {
        public static string UsuarioLogado { get; set; }

        public static string SenhaUsuario { get; set; }

        public static string TipoUsuario => UsuarioLogado == "ADMIN" ? "ADMIN" : "COMUM";

        public static bool EhAdmin()
        {
            return UsuarioLogado == "ADMIN";
        }
    }
}
