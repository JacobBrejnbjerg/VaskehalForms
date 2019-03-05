
using System;
using System.Windows.Forms;

namespace CarwashLib
{
    public class Notification
    {
        public static void ShowNotification(Wash wash)
        {
            MessageBox.Show($"{wash.Car.Name} - {wash.Car.CarPlate} Klar til afhentning", wash.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
