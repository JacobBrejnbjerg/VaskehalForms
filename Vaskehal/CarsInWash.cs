using CarwashLib;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaskehal
{
    public partial class CarsInWash : Form
    {
        private int _carwashId;
        private SynchronizationContext uiCtx;

        public CarsInWash(int carwashId)
        {
            _carwashId = carwashId;
            uiCtx = SynchronizationContext.Current;
            InitializeComponent();
            DisplayWashes();
        }

        private void DisplayWashes()
        {
            flowpanel_Washes.FlowDirection = FlowDirection.TopDown;

            // Gets current washes where car is not collected
            Carwash carwash = CarwashRepository.GetCarwash(_carwashId);
            List<Wash> washes = carwash.Washes
                .Where(w => w.Car.IsCollected == false)
                .ToList();

            // Handles the layout
            foreach (Wash wash in washes)
            {
                FlowLayoutPanel panelUpper = new FlowLayoutPanel();
                panelUpper.AutoSize = true;
                panelUpper.Height = 15;

                Label carName = new Label();
                carName.Text = $"{wash.GetType().Name}: {wash.Car.Name} {wash.Car.CarPlate}";
                carName.AutoSize = true;

                Label carStatus = new Label();
                carStatus.Text = Enum.GetName(typeof(CarStatus), wash.Car.CarStatus);

                // Adds the labels to panelUpper
                panelUpper.Controls.Add(carName);
                panelUpper.Controls.Add(carStatus);

                FlowLayoutPanel panelLower = new FlowLayoutPanel();
                panelLower.AutoSize = true;
                panelLower.Height = 25;
                panelLower.Margin = new Padding(0, 0, 0, 20);

                ProgressBar progressBar = new ProgressBar();
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Width = 150;
                progressBar.Value = wash.Progress;

                Button button = new Button();
                button.Text = "Cancel";
                button.Click += Cancel_Clicked;
                button.Name = wash.Id.ToString();

                Button collect = new Button();
                collect.Text = "Collect";
                collect.Click += btn_Collect;
                collect.Name = wash.Id.ToString();
                collect.Enabled = (wash.Progress == 100) ? true : false;

                // Adds the progressbar and button to the panelLower
                panelLower.Controls.Add(button);
                panelLower.Controls.Add(progressBar);
                panelLower.Controls.Add(collect);

                // Adds the panels to the flowpanel
                flowpanel_Washes.Controls.Add(panelUpper);
                flowpanel_Washes.Controls.Add(panelLower);

                wash.OnProgressChange += (int progress) => 
                {
                    uiCtx.Send(_ => progressBar.Value = progress, null);
                };

                wash.Car.OnCarStatusChanged += (CarStatus carstatus) =>
                {
                    uiCtx.Send(_ => carStatus.Text = Enum.GetName(typeof(CarStatus), carstatus), null);

                    if (carstatus == CarStatus.Finished)
                    {
                        uiCtx.Send(_ => collect.Enabled = true, null);
                    }
                    else if (carstatus == CarStatus.Collected)
                    {
                        uiCtx.Send(_ => panelUpper.Controls.Clear(), null);
                        uiCtx.Send(_ => panelLower.Controls.Clear(), null);
                    }
                };
            }
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int washId = Convert.ToInt32(button.Name);

            Wash wash = CarwashRepository.GetCarwash(_carwashId).Washes
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

        private void btn_Collect(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int washId = Convert.ToInt32(button.Name);

            Wash wash = CarwashRepository.GetCarwash(_carwashId).Washes
                                    .SingleOrDefault(w => w.Id == washId);

            if (wash != null)
            {
                CollectCar form = new CollectCar(wash);
                form.ShowDialog();
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
