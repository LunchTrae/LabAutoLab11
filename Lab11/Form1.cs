using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab11
{
    public partial class Form1 : Form
    {
        double FreqRange = 1;
        int arraySize;
        int sampleRate;
        bool running;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateGraph()
        {
            //Sample Rate Max = 800,000  CHECK SPECS ON POWERPOINT
            //Array Size Max = 8,000
            //1 Hz --> SR = 8000 AS = 8000
            //10 kHz --> SR = 800,000 AS 
            //Update Preview Plot with desired parameters (WaveType, Frequency, etc.)
        }

        private void WaveType_CheckedChanged(object sender, EventArgs e)
        {
            if (optSine.Checked)
            {
                updAmplitude.Enabled = true;
                updDutyCycle.Enabled = false;
                updDCOffset.Enabled = true;
            }
            else if (optTriangle.Checked)
            {
                updAmplitude.Enabled = true;
                updDutyCycle.Enabled = true;
                updDCOffset.Enabled = true;
            }
            else if (optSawtooth.Checked)
            {
                updAmplitude.Enabled = true;
                updDutyCycle.Enabled = false;
                updDCOffset.Enabled = true;
            }
            else if (optSquare.Checked)
            {
                updAmplitude.Enabled = true;
                updDutyCycle.Enabled = true;
                updDCOffset.Enabled = true;
            }
            else if (optTTL.Checked)
            {
                updAmplitude.Value = 5;
                updAmplitude.Enabled = false;
                updDutyCycle.Enabled = true;
                updDCOffset.Enabled = false;
            }
        }

        private void FreqRange_CheckedChanged(object sender, EventArgs e)
        {
            if (opt1Hz.Checked)
            {
                FreqRange = 1;
                updFrequency.Maximum = 100000;
            }
            else if(opt10Hz.Checked)
            {
                FreqRange = 10;
                updFrequency.Maximum = 100000 / Convert.ToInt32(FreqRange);
            }
            else if(opt100Hz.Checked)
            {
                FreqRange = 100;
                updFrequency.Maximum = 100000 / Convert.ToInt32(FreqRange);
            }
            else if(opt1kHz.Checked)
            {
                FreqRange = 1000;
                updFrequency.Maximum = 100000 / Convert.ToInt32(FreqRange);
            }
            else if(opt10kHz.Checked)
            {
                FreqRange = 10000;
                updFrequency.Maximum = 100000 / Convert.ToInt32(FreqRange);
            }

            txtActFreq.Text = (Convert.ToDouble(updFrequency.Text) * FreqRange).ToString();
        }

        private void updFrequency_ValueChanged(object sender, EventArgs e)
        {
            double newValue = Convert.ToDouble(updFrequency.Value);
            double actFreq = (newValue * FreqRange);
            txtActFreq.Text = actFreq.ToString();
            if (actFreq < 100)
            {
                //Define array size and sample rate for different ranges
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPort.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External));
            if (cboPort.Items.Count > 0)
                cboPort.SelectedIndex = 0;

            running = false;

            //Chart Setup
            while (chtData.Series.Count > 0) chtData.Series.RemoveAt(0);
            chtData.ChartAreas[0].AxisX.Minimum = 0.0;
            chtData.ChartAreas[0].AxisX.Title = "Cycle Point Number";
            chtData.ChartAreas[0].AxisY.Title = "Voltage (V)";
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdOnOff_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                try
                {
                    running = true;
                    cmdOnOff.BackColor = Color.Green;
                    cmdOnOff.Text = "ON";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                running = false;
                cmdOnOff.BackColor = Color.Red;
                cmdOnOff.Text = "OFF";
                //PUT CODE TO SET VOLTAGE TO 0 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
        }
    }
}
