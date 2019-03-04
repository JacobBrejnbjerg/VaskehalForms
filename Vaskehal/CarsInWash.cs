using CarwashLib;
using CarwashLib.Wash;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaskehal
{
    public partial class CarsInWash : Form
    {
        private int _carwashId;

        public CarsInWash(int carwashId)
        {
            _carwashId = carwashId;
            InitializeComponent();
            DisplayWashes();
        }

        private void DisplayWashes()
        {
            //flowpanel_Washes.AutoSize = true;
            //flowpanel_Washes.AutoSizeMode = AutoSizeMode.GrowOnly;
            flowpanel_Washes.FlowDirection = FlowDirection.TopDown;

            // Gets current washes where car is not collected
            List<IWash> washes = CarwashRepository.GetCarwash(_carwashId).Washes
                .Where(w => w.Car.IsCollected == false)
                .ToList();

            // Handles the layout
            foreach (IWash wash in washes)
            {
                Panel panelUpper = new Panel();
                panelUpper.Height = 15;

                Label label = new Label();
                label.Text = $"{wash.Car.Name} {wash.Car.CarPlate} - {Enum.GetName(typeof(CarStatus), wash.Car.CarStatus)}";

                // Adds the label to the panel
                panelUpper.Controls.Add(label);

                Panel panelLower = new Panel();
                panelLower.Height = 25;
                panelLower.Margin = new Padding(0, 0, 0, 20);

                ProgressBar progressBar = new ProgressBar();
                progressBar.Minimum = 0;
                progressBar.Maximum = 101;
                progressBar.Width = 300;
                progressBar.Value = wash.Progress;

                Button button = new Button();
                button.Text = "Cancel";
                button.Click += Cancel_Clicked;
                button.Name = wash.Id.ToString();

                // Adds the progressbar and button to the panelLower
                panelLower.Controls.Add(button);
                panelLower.Controls.Add(progressBar);

                // Adds the panels to the flowpanel
                flowpanel_Washes.Controls.Add(panelUpper);
                flowpanel_Washes.Controls.Add(panelLower);
            }
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int washId = Convert.ToInt32(button.Name);

            IWash wash = CarwashRepository.GetCarwash(_carwashId).Washes
                                    .SingleOrDefault(w => w.Id == washId);

            if (wash != null)
            {
                wash.Cancel();
            }
            else
            {
                MessageBox.Show("Could not find a wash with the matching id");
            }
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            CarwashForm form = new CarwashForm(_carwashId);
            form.Show();
            this.Hide();
        }
    }
}
