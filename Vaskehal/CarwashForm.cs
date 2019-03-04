using CarwashLib;
using CarwashLib.Wash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarwashLib.Wash;
using Repository;

namespace Vaskehal
{
    public partial class CarwashForm : Form
    {
        private readonly int _carwashId;

        public CarwashForm(int carwashId)
        {
            _carwashId = carwashId;

            InitializeComponent();
            InitializeWashTypes();
        }

        private void InitializeWashTypes()
        {
            cbox_WashType.DataSource = Enum.GetValues(typeof(WashType));
        }

        private void btn_StartWash_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.CarPlate = tbox_CarPlate.Text;
            car.Name = tbox_CarName.Text;

            // Gets the correct wash using WashType and WashFactory.
            IWash wash = WashFactory.GetWash((WashType)cbox_WashType.SelectedItem, car, tbox_WashCollectPassword.Text);

            if (checkbox_WashNotification.Checked)
            {
                wash.OnFihish += Notification.ShowNotification;
            }

            CarwashRepository.AddWash(_carwashId, wash);

            wash.StartAsync();

            ResetFields();
        }

        private void ResetFields()
        {
            tbox_CarPlate.Text = "";
            tbox_CarName.Text = "";
            tbox_WashCollectPassword.Text = "";
        }

        private void btn_CurrentWashes_Click(object sender, EventArgs e)
        {

        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Vaskehaller form = new Vaskehaller();
            form.Show();
            this.Hide();
        }
    }
}
