using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoControl.Microcontrollers;

namespace ArduinoControl
{
    public partial class Form1 : Form
    {
        Arduino arduino;

        bool ledOn = false;

        public Form1()
        {
            InitializeComponent();
            menuStrip1.ImageScalingSize = new Size(16, 16);
            arduino = new Arduino();
            arduino.addMenu(arduinoToolStripMenuItem);
            arduino.addStatusStrip(sslConnection, sslMessage);
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            arduino.write("L");
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            arduino.write("l");
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (ledOn)
            {
                btnToggle.BackColor = SystemColors.Control;
                arduino.write("l");
                ledOn = false;
            }
            else
            {
                btnToggle.BackColor = Color.Red;
                arduino.write("L");
                ledOn = true;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            arduino.write("a" + hScrollBar1.Value + ";");
        }
    }
}
