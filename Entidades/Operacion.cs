using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        // Propiedades de lectura y escritura para los operandos
        public Numeracion PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }


        // Método para realizar operaciones matemáticas
        public Numeracion Operar(char operador = '+')
        {
            Numeracion resultado = new Numeracion(ESistema.SistemaDecimal,0.0);
                
            Numeracion num1 = new Numeracion(ESistema.SistemaDecimal, primerOperando.GetValorNumerico());
            Numeracion num2 = new Numeracion(ESistema.SistemaDecimal, segundoOperando.GetValorNumerico());

            switch (operador)
            {
                case '+':

                    Numeracion suma = (num1) + (num2);
                    resultado = suma;
                    break;
                case '-':
                    Numeracion resta = (num1) - (num2);
                    resultado = resta;

                    break;
                case '*':
                    Numeracion multiplicacion = (num1) * (num2);
                    resultado = multiplicacion;

                    break;
                case '/':
                    if (segundoOperando.GetValorNumerico() != 0)
                    {
                        Numeracion division = (num1) / (num2);
                        resultado = division;
                    }
                    break;
                default:
                    throw new ArgumentException("Operador no válido. Use +, -, *, o /.");
            }

            return resultado;
        }
    }

}
