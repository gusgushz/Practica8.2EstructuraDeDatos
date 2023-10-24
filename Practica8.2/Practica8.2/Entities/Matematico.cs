using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8._2.Entities
{
    internal class Matematico
    {
        Stack<int> Num1 = new Stack<int>();
        Stack<int> Num2 = new Stack<int>();
        public Stack<int> SumarStack(string num1, string num2)
        {
            Stack<int> resultado = new Stack<int>();

            foreach (char digito in num1)
            {
                Num1.Push(int.Parse(digito.ToString()));
            }

            foreach (char digito in num2)
            {
                Num2.Push(int.Parse(digito.ToString()));
            }

            int acarreo = 0;
            int digito1 = 0;
            int digito2 = 0;
            while (Num1.Count > 0 || Num2.Count > 0)
            {
                if (Num1.Count == 0)
                {
                    digito1 = 0;
                }
                else
                {
                    digito1 = Num1.Pop();
                }

                if (Num2.Count == 0)
                {
                    digito2 = 0;
                }
                else
                {
                    digito2 = Num2.Pop();
                }

                int res = digito1 + digito2 + acarreo;

                if (res >= 10)
                {
                    acarreo = res / 10;
                    res %= 10;
                }
                else
                {
                    acarreo = 0;
                }

                resultado.Push(res);

                if (Num1.Count == 0 && Num2.Count == 0 && acarreo != 0)
                {
                    resultado.Push(acarreo);
                }
            }
            return resultado;
        }
    }
}
