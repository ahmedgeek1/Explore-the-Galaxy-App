using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_5B
{
    public partial class SpeedAndDistanceCalculatorForm : Form
    {
        public SpeedAndDistanceCalculatorForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //declare the variables to use
                int Speed;
                int Day;
                int NumberOfDays;
                Double Distance;
                //declare the constant
                const int THOUSAND_CONSTANT = 1000;
                //initialization of variables to use
                double DistanceInBegining = 0;
                int firstDaySpeed = THOUSAND_CONSTANT;

                Speed = firstDaySpeed;  //calculate the speed for the first day seperately from the loop
                Distance = DistanceInBegining + (Speed / 2);  //calculate the Distance for the first day seperately from the loop
                //verify if the entry is empty
                if (txtBoxNumberOfDays.Text == "")
                {
                    MessageBox.Show("Please enter a number of days! This field cannot be empty");
                    txtBoxNumberOfDays.Focus();
                    if (txtBoxNumberOfDays.Text != "" || lblSpeedOutput.Text != "" || lblDistanceOutput.Text != "")
                    {
                        lblDistanceOutput.Text = "";
                        lblSpeedOutput.Text = "";
                    }

                }
                //verify the entry is integer and positive
                else if ((int.TryParse(txtBoxNumberOfDays.Text, out NumberOfDays)) && NumberOfDays > 0)
                {
                    //in case only 1 day
                    if (NumberOfDays == 1)
                    {
                        Speed = firstDaySpeed;
                        Distance = DistanceInBegining + (Speed / 2);
                    }
                    //in case 2 days or more
                    if (NumberOfDays >= 2)
                    {
                        for (Day = 2; Day <= NumberOfDays; Day++)
                        {
                            Speed = Speed * 2;
                            Distance = Distance + ((Speed + (Speed / 2)) / 2);
                        }
                    }

                    //print out the Distance and the speed calculated
                    lblDistanceOutput.Text = Distance.ToString() + " Miles";
                    lblSpeedOutput.Text = Speed.ToString() + " MPD";
                }
                else
                {   //show error message if the entry is not valid (negative or not integer or not numeric)
                    MessageBox.Show("Please enter a valid input! (only positive integer numbers (ex 1 2 3 15) are accepted)");
                    txtBoxNumberOfDays.Focus();
                }

            }
            catch (Exception ex)
            {   //Display the default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //in case there is data in the labels or textboxes
            if (txtBoxNumberOfDays.Text != "" || lblSpeedOutput.Text != "" || lblDistanceOutput.Text != "")
            {
                txtBoxNumberOfDays.Text = ""; //clear the numberofdays
                lblDistanceOutput.Text = ""; //clear the distance
                lblSpeedOutput.Text = "";   //clear the speed
                MessageBox.Show("Form cleared!"); //alert and notify the user that the form is cleared! (optional)
                txtBoxNumberOfDays.Focus(); //focus on the txtBoxNumberOfDays
            }
            else
            {
                MessageBox.Show("Form is already clear!"); //alert the user that the form is already clear
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void txtBoxNumberOfDays_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

