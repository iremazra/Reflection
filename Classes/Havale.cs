using ReflectionHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomework.Classes
{
    public class Havale:IOdeme
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar} TL havale ile ödendi!";
        }

        public string OdemeYontemi()
        {
            throw new NotImplementedException();
        }
    }
    
}
