using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB1
{
    interface IDrivable
    {
        void On();
        void Off();
        string GetBrand();
        int GetNombrePortieres();
        int GetNombreroues();
    }
}
