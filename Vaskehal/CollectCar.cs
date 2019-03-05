using CarwashLib;
using System;
using System.Windows.Forms;

namespace Vaskehal
{
    public partial class CollectCar : Form
    {
        private readonly Wash _wash;

        public CollectCar(Wash wash)
        {
            _wash = wash;
            InitializeComponent();
        }

        private void btn_Collect_Click(object sender, EventArgs e)
        {
            if (_wash.Collect(tbox_CollectPassword.Text) != null)
            {
                // Hides the form
                this.Hide();
                _wash.Car.CarStatus = CarwashLib.CarStatus.Collected;
            }
            else
            {
                lbl_Text.Text = "Wrong password";
            }
        }
    }
}
