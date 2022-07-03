using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscreta
{
    public  class HexadecimalBinario
    {
        static string hexabinario(string hexa)
        {
            int i = 0;
            string binario = "";
            while (i < hexa.Length)
            {
                char c = hexa[i];
                switch (c)
                {
                    case '0':
                        binario += "0000";
                        break;
                    case '1':
                        binario += "0001";
                        break;
                    case '2':
                        binario += "0010";
                        break;
                    case '3':
                        binario += "0011";
                        break;
                    case '4':
                        binario += "0100";
                        break;
                    case '5':
                        binario += "0101";
                        break;
                    case '6':
                        binario += "0110";
                        break;
                    case '7':
                        binario += "0111";
                        break;
                    case '8':
                        binario += "1000";
                        break;
                    case '9':
                        binario += "1001";
                        break;
                    case 'A':
                        binario += "1010";
                        break;
                    case 'B':
                        binario += "1011";
                        break;
                    case 'C':
                        binario += "1100";
                        break;
                    case 'D':
                        binario += "1101";
                        break;
                    case 'E':
                        binario += "1110";
                        break;

                    case 'F':
                        binario += "1111";
                        break;

                    default:
                        break;
                }
                i++;
            }
            return binario;

        }
    }
}
