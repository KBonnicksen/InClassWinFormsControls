using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassWinFormsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateExpirationYears();
        }

        /// <summary>
        /// Populates a list of the next 5 years 
        /// into the expiration year combobox
        /// </summary>
        private void PopulateExpirationYears()
        {
            cboExpYear.Items.Add(" - - Choose an Exp Year - -");

            int currYear = DateTime.Now.Year;
            int endYear = currYear + 5;
            for (int i = currYear; i <= endYear; i++)
            {
                cboExpYear.Items.Add(i);
            }

            cboExpYear.SelectedIndex = 0;

        }

        private void cboExpYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fired everytime the index is changed

            if(cboExpYear.SelectedIndex == 0)
            {
                //Like a break that takes you out of the entire method
                return;
            }
            int chosenYear = (int)cboExpYear.SelectedItem;
            MessageBox.Show($"You chose {chosenYear}");
        }
    }
}
