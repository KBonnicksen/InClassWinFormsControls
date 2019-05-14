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

            //this if statement allows you to cast the selected item to an int 
            //because it handles the only string that you have to deal with
            if(cboExpYear.SelectedIndex == 0)
            {
                //Like a break that takes you out of the entire method
                return;
            }
            int chosenYear = (int)cboExpYear.SelectedItem;
            MessageBox.Show($"You chose {chosenYear}");
        }

        private void btnClearYears_Click(object sender, EventArgs e)
        {
            int totalItems = cboExpYear.Items.Count;
            MessageBox.Show($"Items before clear {totalItems}");

            cboExpYear.Items.Clear();
        }

        private void radFaculty_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPersonChoice(radFaculty);

        }


        private void radStaff_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPersonChoice(radStaff);
        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPersonChoice(radStudent);
        }

        /// <summary>
        /// Displays a messagebox telling the user which radio button
        /// option they have chosen
        /// </summary>
        /// <param name="radBtn">The radio button selected by the user</param>
        private void DisplayPersonChoice(RadioButton radBtn)
        {
            if (radBtn.Checked)
            {
                string choice = radBtn.Text;
                MessageBox.Show($"You chose {choice}!");
            }
        }
    }
}
