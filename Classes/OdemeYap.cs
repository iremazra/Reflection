using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionHomework.Interfaces;

namespace ReflectionHomework.Classes
{
    public class OdemeYap
    {
        public IOdeme iOdeme { get; set; }

        public OdemeYap(IOdeme iOdeme)
        {
            this.iOdeme = iOdeme;
        }

        public string OdemeYapma(decimal tutar)
        {
            return iOdeme.Ode(tutar);
        }

    }
}
