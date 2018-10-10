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
        string ledOnKey = "L";
        string ledOffKey = "l";

        public Form1()
        {
            InitializeComponent();
            menuStrip1.ImageScalingSize = new Size(16, 16);
            arduino = new Arduino();
            arduino.addMenu(arduinoToolStripMenuItem);
            arduino.addStatusStrip(sslConnection, sslMessage);
            textBox1.Text = ledOnKey;
            textBox2.Text = ledOffKey;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            arduino.write(ledOnKey);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            arduino.write(ledOffKey);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (ledOn)
            {
                btnToggle.BackColor = SystemColors.Control;
                arduino.write(ledOffKey);
                ledOn = false;
            }
            else
            {
                btnToggle.BackColor = Color.Red;
                arduino.write(ledOnKey);
                ledOn = true;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            arduino.write("a" + hScrollBar1.Value + ";");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ledOnKey = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ledOffKey = textBox2.Text;
        }
    }
}
