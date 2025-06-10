using System;
using System.ComponentModel;

namespace OOP
{
    class Roteador
    {
        public static dynamic GetObject(string perfil)
        {
            if (perfil.ToLower().Equals("regra1"))
            {
                //pulo do gato 2
                Regra1 r1 = new Regra1 { Tipo_Regra1 = 1 };
                return r1;
            }
            else if (perfil.ToLower().Equals("regra2"))
            {
                Regra2 r2 = new Regra2 { Tipo_Regra2 = 2 };
                return r2;
            }
            else if (perfil.ToLower().Equals("catalog"))
            {
                Regra1 r1 = new Regra1();
                return r1;
            }
            else
            {
                return "regra não implementada, comando não reconhecido!";
            }
        }
    }
}
