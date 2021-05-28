using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class Tela
    {
        Controlador controlador = new Controlador();
        public void ReceberMensagem()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            if (frase.Length > 255)
            {
                throw new ArgumentOutOfRangeException("Erro!\nA mensagem não pode conter mais que 255 caracteres. Tente novamente...");
                Console.WriteLine();
                ReceberMensagem();
            }
            else
            {
                Console.WriteLine(controlador.DividirMensagem(frase));

                Console.ReadLine();
            }
        }
    }
}
