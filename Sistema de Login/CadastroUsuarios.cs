using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Sistema_de_Login
{
    static class CadastroUsuarios
    {
        private static Usuário[] usuarios =
        {
          new Usuário(){ Nome = "Jeniffer", Senha = "1879" },
          new Usuário(){ Nome = "João", Senha = "0205"},
          new Usuário(){ Nome = "Maria", Senha = "1508"},
            
        };

        private static Usuário _userLogado = null;

        public static Usuário UsuárioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuário usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuárioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
