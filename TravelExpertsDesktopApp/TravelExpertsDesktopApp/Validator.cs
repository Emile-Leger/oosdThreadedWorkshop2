using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TravelExpertsDesktopApp
{
    /// <summary>
    /// Class that will be used to validate the controls when creating a new package.
    /// </summary>
    public static class Validator
    {
        
        public static bool IsPresent(MetroFramework.Controls.MetroTextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        //an intermediate isPresent check
        public static bool IsPresent(MetroFramework.Controls.MetroTextBox textBox)
        {
            if (textBox.Text == "")
            {                                
                return false;
            }
            return true;
        }

        public static bool IsDecimal(MetroFramework.Controls.MetroTextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(MetroFramework.Controls.MetroTextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsPositive(MetroFramework.Controls.MetroTextBox textbox, string name)
        {
            if (Convert.ToDecimal(textbox.Text) < 0)
            {
                MessageBox.Show(name + " must be positive");
                return false;
            }
            return true;
        }

        public static bool IsWithinRange(MetroFramework.Controls.MetroTextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min
                    + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool DateIsAfter(DateTime start, DateTime end)
        {
            if (start >= end)
            {                
                return false;
            }
            return true;
        }

        public static bool PriceIsGreaterThan(string basePrice, string commission)
        {                   
            if(Convert.ToDecimal(basePrice) <= Convert.ToDecimal(commission))
            {                
                return false;
            }
            return true;
        }
    }
}
