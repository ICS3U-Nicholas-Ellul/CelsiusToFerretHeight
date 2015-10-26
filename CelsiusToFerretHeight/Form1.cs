/*
 * Created by: Nicholas  Ellul
 * Created on: 26-Oct-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 4-01
 * This program converts degreesC to degreesF
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusToFerretHeight
{
    public partial class frmConvertCTOF : Form
    {
        public void CelsiusToFahrenheit(int Tc)
        {
            //converts celsius to fahrenheit

            //variables
            double Tf;
            string TfAsString;

            Tf = Tc * (9.0/5.0) + 32;
            TfAsString = Convert.ToString(Tf);
            MessageBox.Show("The temperature is " + TfAsString + " degrees fahrenheit.");
        }
        public frmConvertCTOF()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variables
            int celsius;

            celsius = Convert.ToInt32(this.txtInput.Text);
            CelsiusToFahrenheit(celsius);
    

        }
    }
}
