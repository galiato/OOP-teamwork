using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    public interface IObjectOperator
    {
        List<GameObject> MainObjectsProducer(params string[] TypeNumber);
    }
}
