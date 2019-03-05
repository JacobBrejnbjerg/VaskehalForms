using CarwashLib;

using System;
using System.Windows.Forms;
using Repository;
using System.Linq;
using System.Collections.Generic;

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
            string carwashName = CarwashRepository.GetCarwash(carwashId).Name;
            this.Text = carwashName;
            lbl_CarwashName.Text = carwashName;
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
            Wash wash = WashFactory.GetWash((WashType)cbox_WashType.SelectedItem, car, tbox_WashCollectPassword.Text);

            // Gets current washes
            List<Wash> washes = CarwashRepository.GetCarwash(_carwashId).Washes;
            // Finds new ID using the highest ID + 1
            wash.Id = (washes.Count > 0) ? washes.Max(w => w.Id) + 1 : 0;

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
            checkbox_WashNotification.Checked = false;
        }

        private void btn_CurrentWashes_Click(object sender, EventArgs e)
        {
            CarsInWash form = new CarsInWash(_carwashId);
            form.Show();
            this.Hide();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Vaskehaller form = new Vaskehaller();
            form.Show();
            this.Hide();
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            StatisticsForm form = new StatisticsForm(_carwashId);
            form.ShowDialog();
        }
    }
}
