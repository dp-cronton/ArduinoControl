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
            ledOn = true;
            setLED();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            ledOn = false;
            setLED();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (ledOn)
                ledOn = false;
            else
                ledOn = true;
            setLED();
        }

        private void setLED()
        {
            if (ledOn)
            {
                btnToggle.BackColor = Color.Red;
                arduino.write(ledOnKey);
            }
            else
            {
                btnToggle.BackColor = SystemColors.Control;
                arduino.write(ledOffKey);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ledOnKey = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ledOffKey = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 90;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            arduino.write("a" + trackBar1.Value + ";");
            lblAngle.Text = trackBar1.Value + "°";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 180;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
        }
    }
}
