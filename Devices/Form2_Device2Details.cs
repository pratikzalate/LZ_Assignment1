using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Devices
{
    public partial class Device2Details : Form, Device
    {
        public Device2Details()
        {
            InitializeComponent();
            setValuesDevice2();
        }
        private void setValuesDevice2()
        {
            this.device_name_textbox.Text = "Lenze Inverter i950";
            this.product_code_textbox.Text = "i950-UX2UI4E94";
            this.firmware_version_textbox.Text = "1.0.20.0.298436";
            this.actual_torque_textbox.Text = "56";
            this.actual_speed_textbox.Text = "2000";
            this.actual_voltage_textbox.Text = "12";
        }
        public void showErrorStatus()
        {
            int actualSpeed, actualVoltage;
            bool flag = int.TryParse(actual_speed_textbox.Text, out actualSpeed);
            if (!flag)
            {
                MessageBox.Show("You entered invalid actual speed value!", "Error");
                actual_speed_textbox.Focus();
                return;
            }
            flag = int.TryParse(actual_voltage_textbox.Text, out actualVoltage);
            if (!flag)
            {
                MessageBox.Show("You entered invalid actual voltage value!", "Error");
                actual_voltage_textbox.Focus();
                return;
            }

            if (actualVoltage > 25 && (actualSpeed > 5000 || -5000 > actualSpeed))
            {
                LED.Image = Image.FromFile("../../../Resources/RedLED.png");
            }
            else
            {
                LED.Image = Image.FromFile("../../../Resources/GreenLED.png");
            }

        }
        private void actual_voltage_textbox_TextChanged(object sender, EventArgs e)
        {
            showErrorStatus();
        }

        private void actual_speed_textbox_TextChanged(object sender, EventArgs e)
        {
            showErrorStatus();
        }
    }
}
