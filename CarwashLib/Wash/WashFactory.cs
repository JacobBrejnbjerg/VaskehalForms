using System;
using System.Collections.Generic;
using System.Text;

namespace CarwashLib.Wash
{
    class WashFactory
    {
        public static IWash GetWash(WashType selector, Car car, string collectPassword)
        {
            switch (selector)
            {
                case WashType.Basic:
                    return new BasicWash(car, collectPassword);
                case WashType.Silver:
                    return new SilverWash(car, collectPassword);
                case WashType.Gold:
                    return new GoldWash(car, collectPassword);
                default:
                    return null;
            }
        }
    }
}
