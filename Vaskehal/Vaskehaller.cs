using CarwashLib;
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
    public partial class Vaskehaller : Form
    {
        public Vaskehaller()
        {
            InitializeComponent();
        }

        // New carwash
        private void button1_Click(object sender, EventArgs e)
        {
            CarwashRepository.NewCarwash(tbox_CarwashName.Text);
            UpdateComboCarwashes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateComboCarwashes()
        {
            // Clears combobox
            combo_Carwashes.Items.Clear();

            // Adds all Carwashes
            combo_Carwashes.Items.AddRange(CarwashRepository.GetCarwashes().ToArray());

            // Selects newest item in combobox
            combo_Carwashes.SelectedIndex = combo_Carwashes.Items.Count - 1; 
        }

        private void btn_DeleteCarwash_Click(object sender, EventArgs e)
        {
            Carwash carwash = (Carwash)combo_Carwashes.SelectedItem;
            if (CarwashRepository.DeleteCarwash(carwash.Name))
            {
                UpdateComboCarwashes();
            }
        }
    }
}
