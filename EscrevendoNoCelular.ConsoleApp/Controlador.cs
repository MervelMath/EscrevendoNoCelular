using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class Controlador
    {
        Dominio mensagemUsuario = new Dominio();
        public string DividirMensagem(string mensagem)
        {
            string result = "";

            for (int i = 0; i < mensagem.Length; i++)
            {
                result = result + mensagemUsuario.EntradaTeclado(mensagem.Substring(i, 1));

                if (i + 1 != mensagem.Length)
                {
                    string saidaAtual = mensagemUsuario.EntradaTeclado(mensagem.Substring(i, 1)).Substring(0, 1);
                    string proximaSaida = mensagemUsuario.EntradaTeclado(mensagem.Substring(i + 1, 1)).Substring(0, 1);
                    if (saidaAtual == proximaSaida)
                        result = result + "_";
                }
            }

            return result;
        }
    }
}
