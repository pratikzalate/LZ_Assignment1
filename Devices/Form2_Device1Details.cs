using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Devices
{
    public partial class Device1Details : Form, Device
    {
        public Device1Details()
        {
            InitializeComponent();
            setValuesDevice1();
        }
        private void setValuesDevice1()
        {
            this.device_name_textbox.Text = "Lenze PLC c300";
            this.product_code_textbox.Text = "c300-X23UA4EO5";
            this.firmware_version_textbox.Text = "1.0.20.0.278435";
            this.switching_freq_textbox.Text = "450";
            this.start_freq_textbox.Text = "200";
            this.delay_time_textbox.Text = "10 ms";
        }
        public void showErrorStatus()
        {
            int switchingFreq,startFreq; 
            bool flag = int.TryParse(switching_freq_textbox.Text, out switchingFreq);
            if (!flag)
            {
                MessageBox.Show("You entered invalid switching frequency!", "Error");
                switching_freq_textbox.Focus();
                return;
            }
            flag = int.TryParse(start_freq_textbox.Text, out startFreq);
            if (!flag)
            {
                MessageBox.Show("You entered invalid start frequency!", "Error");
                start_freq_textbox.Focus();
                return;
            }

            if(startFreq > 250 && switchingFreq > 500)
            {
                LED.Image = Image.FromFile("../../../Resources/RedLED.png");
            }
            else
            {
                LED.Image = Image.FromFile("../../../Resources/GreenLED.png");
            }

        }
        private void switching_freq_textbox_TextChanged(object sender, EventArgs e)
        {
            showErrorStatus();
        }

        private void start_freq_textbox_TextChanged(object sender, EventArgs e)
        {
            showErrorStatus();
        }
    }
}
