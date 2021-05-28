using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class Mensagem
    {
        public string EntradaTeclado(string numeros)
        {
            
            string nome = "";
            switch (numeros)
            {
                case "A":
                    nome = "2";
                    break;
                case "B":
                    nome = "22";
                    break;
                case "C":
                    nome = "222";
                    break;
                case "D":
                    nome = "3";
                    break;
                case "E":
                    nome = "33";
                    break;
                case "F":
                    nome = "333";
                    break;
                case "G":
                    nome = "4";
                    break;
                case "H":
                    nome = "44";
                    break;
                case "I":
                    nome = "444";
                    break;
                case "J":
                    nome = "5";
                    break;
                case "K":
                    nome = "55";
                    break;
                case "L":
                    nome = "555";
                    break;
                case "M":
                    nome = "6";
                    break;
                case "N":
                    nome = "66";
                    break;
                case "O":
                    nome = "666";
                    break;
                case "P":
                    nome = "7";
                    break;
                case "Q":
                    nome = "77";
                    break;
                case "R":
                    nome = "777";
                    break;
                case "S":
                    nome = "7777";
                    break;
                case "T":
                    nome = "8";
                    break;
                case "U":
                    nome = "88";
                    break;
                case "V":
                    nome = "888";
                    break;
                case "W":
                    nome = "9";
                    break;
                case "X":
                    nome = "99";
                    break;
                case "Y":
                    nome = "999";
                    break;
                case "Z":
                    nome = "9999";
                    break;
                case " ":
                    nome = "0";
                    break;
            }
            return nome;
        }
    }
}
