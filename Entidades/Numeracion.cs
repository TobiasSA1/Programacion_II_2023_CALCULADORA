using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public enum ESistema
    {
        SistemaDecimal,
        SistemaBinario
    }

    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        public Numeracion(ESistema sistema, double valorNumerico)
        {
            this.sistema = sistema;
            InicializarValores(valorNumerico.ToString(), sistema);

        }
        private void InicializarValores(string valor, ESistema sistema) 
        {

                if (sistema == ESistema.SistemaDecimal)
                {
                    if (!double.TryParse(valor, out valorNumerico))
                    {
                        throw new ArgumentException("No es un número decimal válido.");
                    }
                }
                else if (sistema == ESistema.SistemaBinario)
                {
                    valorNumerico = BinarioADecimal(valor);
                }

                else
                {
                    valorNumerico = double.MinValue;
                }

        }

        public string ConvertirA(ESistema sistemaDestino)
        {
            if (sistema == sistemaDestino)
            {
                return valorNumerico.ToString();
            }
            else if (sistema == ESistema.SistemaDecimal)
            {
                if (sistemaDestino == ESistema.SistemaBinario)
                {
                    if (int.TryParse(valorNumerico.ToString(), out int valorDecimal))
                    {
                        return DecimalABinario(valorDecimal);
                    }
                    else
                    {
                        return "Conversión no válida a binario";
                    }
                }
            }
            else if (sistema == ESistema.SistemaBinario)
            {
                if (sistemaDestino == ESistema.SistemaDecimal)
                {

                       double test = BinarioADecimal(valorNumerico.ToString());

                       return test.ToString();

                }
            }
            return "Conversión no soportada";
        }

        public static string DecimalABinario(int numeroDecimal)
        {
            if (numeroDecimal < 0)
            {
                return "0";
            }

            if (numeroDecimal == 0)
            {
                return "0";
            }

            string binario = "";

            while (numeroDecimal > 0)
            {
                double residuo = numeroDecimal % 2;
                binario = residuo.ToString() + binario;
                numeroDecimal = numeroDecimal / 2;
            }

            return binario.ToString();
        }

        public static string DecimalABinario(string numeroDecimal)
        {
            if (double.TryParse(numeroDecimal, out double valor) && valor >= 0)
            {
                int parteEntera = (int)valor; // Obtener la parte entera del número decimal

                string binario = "";

                while (parteEntera > 0)
                {
                    int residuo = parteEntera % 2;
                    binario = residuo.ToString() + binario;
                    parteEntera = parteEntera / 2;
                }

                if (binario == "")
                {
                    binario = valor.ToString();
                }

                return binario;
            }
            else
            {
                return "Número Inválido";
            }
        }

        private double BinarioADecimal(string valor)
        {
            // Verifica si la cadena es válida
            if (!esBinario(valor))
            {
                return 0.0;
            }

            int longitud = valor.Length;
            double resultado = 0.0;

            for (int i = 0; i < longitud; i++)
            {
                char digito = valor[longitud - 1 - i];
                if (digito == '1')
                {
                    resultado += Math.Pow(2, i);
                }
            }

            return resultado;
        }

        private bool esBinario(string valor)
        {
            // Verifica que todos los caracteres sean '0' o '1'
            foreach (char digito in valor)
            {
                if (digito != '0' && digito != '1')
                {
                    return false;
                }
            }

            return true;
        }

        public ESistema GetSistema()
        {
            return sistema;
        }

        public double GetValorNumerico()
        {
            return valorNumerico;
        }

        public static Numeracion operator +(Numeracion num1, Numeracion num2)
        {
            double resultado = num1.GetValorNumerico() + num2.GetValorNumerico();
            return new Numeracion(ESistema.SistemaDecimal, resultado);
        }

        public static Numeracion operator -(Numeracion num1, Numeracion num2)
        {
            double resultado = num1.GetValorNumerico() - num2.GetValorNumerico();
            return new Numeracion(ESistema.SistemaDecimal, resultado);
        }

        public static Numeracion operator *(Numeracion num1, Numeracion num2)
        {
            double resultado = num1.GetValorNumerico() * num2.GetValorNumerico();
            return new Numeracion(ESistema.SistemaDecimal, resultado);
        }

        public static Numeracion operator /(Numeracion num1, Numeracion num2)
        {
            if (num2.GetValorNumerico() != 0)
            {
                double resultado = num1.GetValorNumerico() / num2.GetValorNumerico();
                return new Numeracion(ESistema.SistemaDecimal, resultado);
            }
            else
            {
                throw new ArgumentException("División por cero no permitida.");
            }
        }


    }
}
