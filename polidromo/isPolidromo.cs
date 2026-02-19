using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace polindromos
{
    internal class isPolindromos
    {
        public bool checker(int a)
        {
            if (a < 0 ) return false;
            if (a == 0) return true;
            var str = a.ToString();

            int digitoL = (int)Math.Floor(Math.Log10(a) + 1);
            if (digitoL == 1) return true;
            //int[] digitos = new int[(int)Math.Floor(Math.Log(a) + 1)];
            int[] digitos = new int[digitoL];


            int temp = a;

            for (int i = digitos.Length - 1; i >= 0; i--)
            {
                digitos[i] = temp % 10;
                temp /= 10;
            }
            long result = 0;
            long multiplier = 1;

     
            for (int i = 0; i <= digitos.Length - 1; i++)
            {
                result += digitos[i] * multiplier;
                multiplier *= 10;

            }

            if (result == a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
