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


            Console.WriteLine(controlador.DividirMensagem(frase));

            Console.ReadLine();
        }
    }
}
