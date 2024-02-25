using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
           new Usuario() { Nome = "Joao", Senha ="abc123" },
           new Usuario() { Nome = "Malia", Senha ="123abc" },
           new Usuario() { Nome = "Peter", Senha ="sexo123" },
           new Usuario() { Nome = "Thace", Senha ="pika123" },
           new Usuario() { Nome = "Antony", Senha ="trembolona123" },
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        { get { return _userLogado; }
        set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach(Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha==senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
