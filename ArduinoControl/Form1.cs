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

        public Form1()
        {
            InitializeComponent();
            menuStrip1.ImageScalingSize = new Size(16, 16);
            arduino = new Arduino();
            arduino.addMenu(arduinoToolStripMenuItem);
            arduino.addStatusStrip(sslConnection, sslMessage);
        }

        private void cbLED_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLED.Checked)
            {
                arduino.write("l");
            }
            else
            {
                arduino.write("L");
            }
        }
    }
}
