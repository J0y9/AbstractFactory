using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FurnitureFactory
    {
        public static IChair CreateChair(string chairType)
        {
            switch (chairType)
            {
                case "modern":
                    return new ModernChair();
                    break;
                case "victorian":
                    return new VictorianChair();
                    break;
                default:
                    throw new ArgumentException("invalid type",chairType);
            }
        }
        public static ISofa CreateSofa(string sofaType)
        {
            switch (sofaType)
            {
                case "modern":
                    return new ModernSofa();
                    break;
                case "victorian":
                    return new VictorianSofa();
                    break;
                default:
                    throw new ArgumentException("invalid type", sofaType);
            }
        }
    }
}
