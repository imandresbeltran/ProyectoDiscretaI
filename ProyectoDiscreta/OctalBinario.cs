using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscreta
{
    public class OctalBinario
    {
       
        public static string octalabinario(string octal)
        {
            int i = 0;
            string binario = "";
            while (i < octal.Length)
            {
                char c = octal[i];
                switch (c)
                {
                    case '0':
                        binario += "000";
                        break;
                    case '1':
                        binario += "001";
                        break;
                    case '2':
                        binario += "010";
                        break;
                    case '3':
                        binario += "011";
                        break;
                    case '4':
                        binario += "100";
                        break;
                    case '5':
                        binario += "101";
                        break;
                    case '6':
                        binario += "110";
                        break;
                    case '7':
                        binario += "111";
                        break;
                    default:
                        binario += "Inválido";
                        break;
                }
                i++;
            }
            return binario;

        }
    }

 }
