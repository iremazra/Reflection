using ReflectionHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomework.Classes
{
    public class Kapıda_Ödeme : IOdeme
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar} TL kapıda ödeme ile teslimat günü ödenecek!";
        }

        public string OdemeYontemi()
        {
            return "Kapıda_Ödeme";
        }
    }
}
