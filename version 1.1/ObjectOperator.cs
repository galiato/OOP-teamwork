using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    public class ObjectOperator : IObjectOperator
    {
        public List<GameObject> MainObjectsProducer(params string[] TypeNumber)
        {

            List<GameObject> objects = new List<GameObject>();
            for (int i = 0; i < TypeNumber.Length; i += 3)
            {
                string name = TypeNumber[i];
                string type = TypeNumber[i + 1];
                int number = int.Parse(TypeNumber[i + 2]);
                switch (type)
                {
                    case "Fish":
                        objects.Add(new Fish(new Coords(60, 25)));
                        break;
                    case "SmartPenguin":
                        switch (number)
                        {
                            case 1:
                                objects.Add(new SmartPenguin(name, new Coords(1, 1), new Coords(0, 0)));
                                break;
                            case 2:
                                objects.Add(new SmartPenguin(name, new Coords(105, 35), new Coords(0, 0)));
                                break;
                            case 3:
                                objects.Add(new SmartPenguin(name, new Coords(1, 35), new Coords(0, 0)));
                                break;
                            case 4:
                                objects.Add(new SmartPenguin(name, new Coords(105, 1), new Coords(0, 0)));
                                break;
                            default:
                                //throw
                                break;
                        }
                        break;


                }

            }
            return objects;

        }



    }
}
