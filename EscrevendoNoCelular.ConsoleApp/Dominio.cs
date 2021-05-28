using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class Dominio
    {
        public string EntradaTeclado(string caractere)
        {
            
            string valor = "";
            switch (caractere.ToUpper())
            {
                case "A":
                    valor = "2";
                    break;
                case "B":
                    valor = "22";
                    break;
                case "C":
                    valor = "222";
                    break;
                case "D":
                    valor = "3";
                    break;
                case "E":
                    valor = "33";
                    break;
                case "F":
                    valor = "333";
                    break;
                case "G":
                    valor = "4";
                    break;
                case "H":
                    valor = "44";
                    break;
                case "I":
                    valor = "444";
                    break;
                case "J":
                    valor = "5";
                    break;
                case "K":
                    valor = "55";
                    break;
                case "L":
                    valor = "555";
                    break;
                case "M":
                    valor = "6";
                    break;
                case "N":
                    valor = "66";
                    break;
                case "O":
                    valor = "666";
                    break;
                case "P":
                    valor = "7";
                    break;
                case "Q":
                    valor = "77";
                    break;
                case "R":
                    valor = "777";
                    break;
                case "S":
                    valor = "7777";
                    break;
                case "T":
                    valor = "8";
                    break;
                case "U":
                    valor = "88";
                    break;
                case "V":
                    valor = "888";
                    break;
                case "W":
                    valor = "9";
                    break;
                case "X":
                    valor = "99";
                    break;
                case "Y":
                    valor = "999";
                    break;
                case "Z":
                    valor = "9999";
                    break;
                case " ":
                    valor = "0";
                    break;
            }
            return valor;
        }
    }
}
