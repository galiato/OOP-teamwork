using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    class ObjectOperator : IObjectOperator
    {
        public GameObject ObjectProducer(params string[] TypeNumber)
        {
            GameObject obj;
            for (int i = 0; i < TypeNumber.Length; i++)
            {
                int number = int.Parse(TypeNumber[i]);
                string type = TypeNumber[i + 1];

                switch (type)
                {
                    case "Fish":

                    case "SmartPenguin":
                        
                        break;


                    default:
                        break;
                }

            }
            return obj;
        }


    }
}
