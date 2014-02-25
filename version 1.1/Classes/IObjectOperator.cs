using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    interface IObjectOperator
    {
        GameObject ObjectProducer(params string[] TypeNumber);
    }
}
