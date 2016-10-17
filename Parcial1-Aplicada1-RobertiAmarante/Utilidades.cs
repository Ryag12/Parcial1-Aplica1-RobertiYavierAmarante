using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial1_Aplicada1_RobertiAmarante
{
    public class Utilidades
    {
        public static int ToInt(string Numero)
        {
            int retornar  = 0;

            int.TryParse(Numero, out retornar);

            return retornar;
        }
    }
}
