﻿namespace ArduinoControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arduinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbLED = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arduinoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arduinoToolStripMenuItem
            // 
            this.arduinoToolStripMenuItem.Name = "arduinoToolStripMenuItem";
            this.arduinoToolStripMenuItem.Size = new System.Drawing.Size(124, 41);
            this.arduinoToolStripMenuItem.Text = "Arduino";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslConnection,
            this.sslMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 800);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1283, 42);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslConnection
            // 
            this.sslConnection.Name = "sslConnection";
            this.sslConnection.Size = new System.Drawing.Size(269, 37);
            this.sslConnection.Text = "toolStripStatusLabel1";
            // 
            // sslMessage
            // 
            this.sslMessage.Name = "sslMessage";
            this.sslMessage.Size = new System.Drawing.Size(269, 37);
            this.sslMessage.Text = "toolStripStatusLabel1";
            // 
            // cbLED
            // 
            this.cbLED.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbLED.AutoSize = true;
            this.cbLED.Location = new System.Drawing.Point(242, 174);
            this.cbLED.Name = "cbLED";
            this.cbLED.Size = new System.Drawing.Size(69, 39);
            this.cbLED.TabIndex = 2;
            this.cbLED.Text = "LED";
            this.cbLED.UseVisualStyleBackColor = true;
            this.cbLED.CheckedChanged += new System.EventHandler(this.cbLED_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 842);
            this.Controls.Add(this.cbLED);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arduinoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslConnection;
        private System.Windows.Forms.ToolStripStatusLabel sslMessage;
        private System.Windows.Forms.CheckBox cbLED;
    }
}

