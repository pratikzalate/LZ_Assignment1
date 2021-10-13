using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_device1_Click(object sender, EventArgs e)
        {
            Device1Details device1Details = new Device1Details();
            device1Details.Show();
        }

        private void btn_device2_Click(object sender, EventArgs e)
        {
            Device2Details device2Details = new Device2Details();
            device2Details.Show();
        }
    }
}
