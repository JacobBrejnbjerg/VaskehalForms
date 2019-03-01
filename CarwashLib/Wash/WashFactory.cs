using System;
using System.Collections.Generic;
using System.Text;

namespace CarwashLib.Wash
{
    class WashFactory
    {
        public static WashBase GetWash(WashSelector selector)
        {
            WashBase wb;
            switch (selector)
            {
                case WashSelector.Basic:
                    wb = new BasicWash();
                    break;
                case WashSelector.Silver:
                    wb = new SilverWash();
                    break;
                case WashSelector.Gold:
                    wb = new GoldWash();
                    break;
                default:
                    wb = null;
                    break;
            }

            return wb;
        }
    }
}
