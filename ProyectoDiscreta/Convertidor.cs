using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiscreta
{
    public partial class FrmConvertidor : Form
    {
        public FrmConvertidor()
        {
            InitializeComponent();
        }

        //BOTÓN CALCULAR
        private void button1_Click(object sender, EventArgs e)
        {
            TxbDividendo.Focus();

            string dividendo = TxbDividendo.Text;
            string basedividendo = TxbBaseDividendo.Text;
            string divisor = TxbDivisor.Text;
            string basedivisor = TxbBaseDivisor.Text;

            if(basedividendo == "8" || basedivisor == "8")
            {
                string res = octalabinario(dividendo);
                string res2 = octalabinario(divisor);

                int convers = Conversiones(res);
                int convers2 = Conversiones(res2);

                int respuesta = DivisonBinarios(convers, convers2);

                MessageBox.Show("La división es: " + respuesta, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            } else if(basedividendo == "16" || basedivisor == "16")
            {
                string res3 = hexadecimalabinario(dividendo);
                string res4 = hexadecimalabinario(divisor);

                int convers3 = Conversiones(res3);
                int convers4 = Conversiones(res4);

                int respuesta2 = DivisonBinarios(convers3, convers4);

                MessageBox.Show("La división es: " + respuesta2, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(basedividendo == "10" || basedivisor == "10")
            {
                string res5 = decimalabinario(dividendo);
                string res6 = decimalabinario(divisor);

                int convers5 = Conversiones(res5);
                int convers4 = Conversiones(res6);

                int respuesta3 = DivisonBinarios(convers5, convers4);

                MessageBox.Show("La respuesta es: " + respuesta3, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            TxbDividendo.Clear();
            TxbBaseDividendo.Clear();
            TxbDivisor.Clear();
            TxbBaseDivisor.Clear();
            TxbDividendo.Focus();
        }

        //MÉTODO PARA REALIZAR LA CONVERSIÓN DE OCTAL A BINARIO
        static string octalabinario(string octal)
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
                        binario += "Inválido " + octal[i];
                        break;
                }
                i++;
            }

            return binario;

        }

        //MÉTODO PARA CONVERTIR DE HEXADECIAMAL A BINARIO
        static string hexadecimalabinario(string hexa)
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
                        binario += "Número inválido " + hexa[i];
                        break;
                }
                i++;
            }
            return binario;
        }

        //MÉTODO PARA CONVERTIR DECIMAL A BINARIO
        static string decimalabinario(string decimall)
        {
            int i = 0;
            string binario = "";
            while (i < decimall.Length)
            {
                char c = decimall[i];
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
                    case '8':
                        binario += "1000";
                        break;
                    case '9':
                        binario += "1001";
                        break;
                    default:
                        binario += "Inválido " + decimall[i];
                        break;
                }
                i++;
            }

            return binario;

        }


        //MÉTODO PARA CONVERTIR LOS STRING A INT
        static int Conversiones(string respuesta)
        {
            int conversion1 = Int16.Parse(respuesta);

            return conversion1;
        }


        //MÉTODO PARA DIVIDIR LOS NÚMEROS BINARIOS
        static int DivisonBinarios(int numero1, int numero2)
        {
            int result = numero1 / numero2;

            return result;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
