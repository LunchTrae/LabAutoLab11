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
        const int maxBufferSize = 8000;
        const int maxD2Arate = 833000;
        double freqRange = 1;
        int arraySize;
        int sampleRate;
        double[] waveData;
        string waveType;
        bool running;
        bool error;
        NationalInstruments.DAQmx.Task analogwritetask;
        AnalogSingleChannelWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateArraySample()
        {
            double frequency = Convert.ToDouble(txtActFreq.Text);

            sampleRate = maxD2Arate;
            arraySize = Convert.ToInt32(sampleRate / frequency);

            if(arraySize > maxBufferSize)
            {
                arraySize = maxBufferSize;
                sampleRate = Convert.ToInt32(frequency * arraySize);
                while (sampleRate > maxD2Arate)
                {
                    arraySize = arraySize - 1;
                    sampleRate = Convert.ToInt32(frequency * arraySize);
                }
            }
            try
            {
                analogwritetask.Timing.ConfigureSampleClock("", sampleRate, SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double CalculatePoint(double x)
        {
            double y = 0;
            double amplitude = Convert.ToDouble(updAmplitude.Value);
            double dcOffset = Convert.ToDouble(updDCOffset.Value);
            double frequency = Convert.ToDouble(txtActFreq.Text);
            double dutyCycle = Convert.ToDouble(updDutyCycle.Value);
            switch (waveType)
            {
                case "Sine":
                    y = amplitude * Math.Sin(2.0 * Math.PI * x * frequency) + dcOffset;
                    break;
                case "Square":
                    if (x < (1 / frequency) * (dutyCycle / 100))
                    {
                        y = amplitude + dcOffset;
                    }
                    else y = -amplitude + dcOffset;
                    break;
                case "Sawtooth":
                    y = 2 * amplitude * x / (1 / frequency) - amplitude + dcOffset;
                    break;
                case "Triangle":
                    if (x < (1 / frequency) * (dutyCycle / 100))
                    {
                        y = (2 * amplitude * x / ((1 / frequency) * (dutyCycle / 100))) - amplitude + dcOffset;
                    }
                    else y = (-2 * amplitude * (x - ((1 / frequency) * (dutyCycle / 100))) / ((1 / frequency) * ((100 - dutyCycle) / 100))) + amplitude + dcOffset;
                    break;
                case "TTL":
                    if (x < (1 / frequency) * (dutyCycle / 100))
                    {
                        y = 5;
                    }
                    else y = 0;
                    break;
            }

            if (y > 10) y = 10;
            else if (y < -10) y = -10;
            return y;
        }

        private void GenerateWaveform()
        {
            double actFreq = Convert.ToDouble(txtActFreq.Text);
            double timeish = 0;

            while (chtData.Series.Count > 0) chtData.Series.RemoveAt(0);
            chtData.Series.Add(waveType + " Wave");
            chtData.Series[waveType + " Wave"].ChartType = SeriesChartType.Line;
            UpdateArraySample();
            timeish = (1.0 / (actFreq * arraySize));
            waveData = new double[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                chtData.Series[waveType + " Wave"].Points.AddXY(i, CalculatePoint(i*timeish));
                waveData[i] = CalculatePoint(i*timeish);
            }

            if (running)
            {
                try
                {
                    analogwritetask.Stop();
                    writer.WriteMultiSample(true, waveData);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void WaveType_CheckedChanged(object sender, EventArgs e)
        {
            if (optSine.Checked)
            {
                updAmplitude.Enabled = true;
                updDutyCycle.Enabled = false;
                updDCOffset.Enabled = true;
                waveType = "Sine";
            }
            else if (optTriangle.Checked)
            {
                updAmplitude.Enabled = true;
                updDutyCycle.Enabled = true;
                updDCOffset.Enabled = true;
                waveType = "Triangle";
            }
            else if (optSawtooth.Checked)
            {
                updAmplitude.Enabled = true;
                updDutyCycle.Enabled = false;
                updDCOffset.Enabled = true;
                waveType = "Sawtooth";
            }
            else if (optSquare.Checked)
            {
                updAmplitude.Enabled = true;
                updDutyCycle.Enabled = true;
                updDCOffset.Enabled = true;
                waveType = "Square";
            }
            else if (optTTL.Checked)
            {
                updAmplitude.Value = 5;
                updAmplitude.Enabled = false;
                updDutyCycle.Enabled = true;
                updDCOffset.Enabled = false;
                waveType = "TTL";
            }
            GenerateWaveform();
        }

        private void FreqRange_CheckedChanged(object sender, EventArgs e)
        {
            if (opt1Hz.Checked)
            {
                freqRange = 1;
                updFrequency.Maximum = 100000;
            }
            else if(opt10Hz.Checked)
            {
                freqRange = 10;
                updFrequency.Maximum = 100000 / Convert.ToInt32(freqRange);
            }
            else if(opt100Hz.Checked)
            {
                freqRange = 100;
                updFrequency.Maximum = 100000 / Convert.ToInt32(freqRange);
            }
            else if(opt1kHz.Checked)
            {
                freqRange = 1000;
                updFrequency.Maximum = 100000 / Convert.ToInt32(freqRange);
            }
            else if(opt10kHz.Checked)
            {
                freqRange = 10000;
                updFrequency.Maximum = 100000 / Convert.ToInt32(freqRange);
            }

            txtActFreq.Text = (Convert.ToDouble(updFrequency.Text) * freqRange).ToString();
            GenerateWaveform();
        }

        private void updFrequency_ValueChanged(object sender, EventArgs e)
        {
            double newValue = Convert.ToDouble(updFrequency.Value);
            double actFreq = (newValue * freqRange);
            txtActFreq.Text = actFreq.ToString();
            GenerateWaveform();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPort.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External));
            if (cboPort.Items.Count > 0)
                cboPort.SelectedIndex = 0;

            running = false;
            waveType = "Sine";
            sampleRate = 833000;

            try
            {
                analogwritetask = new NationalInstruments.DAQmx.Task();


                for (int i = 0; i < cboPort.Items.Count - 1; i++)
                {
                    analogwritetask.AOChannels.CreateVoltageChannel(cboPort.Items[i].ToString(), "AO Channel " + i.ToString(), -10, 10, AOVoltageUnits.Volts);
                }
                analogwritetask.Timing.ConfigureSampleClock("", sampleRate, SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples);
                analogwritetask.AOChannels.All.UseOnlyOnBoardMemory = true;
                writer = new AnalogSingleChannelWriter(analogwritetask.Stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                error = true;
                Application.Exit();
            }
            
            

            //Chart Setup
            while (chtData.Series.Count > 0) chtData.Series.RemoveAt(0);
            chtData.ChartAreas[0].AxisX.Minimum = 0.0;
            chtData.ChartAreas[0].AxisY.Minimum = -11.0;
            chtData.ChartAreas[0].AxisY.Maximum = 11.0;
            chtData.ChartAreas[0].AxisX.Title = "Cycle Point Number";
            chtData.ChartAreas[0].AxisY.Title = "Voltage (V)";
            GenerateWaveform();
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
                    GenerateWaveform();
                    analogwritetask.Stop();
                    writer.WriteMultiSample(false, waveData);
                    analogwritetask.Start();
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
                analogwritetask.Stop();
                for (int i = 0; i < arraySize; i++)
                {
                    waveData[i] = 0;
                }
                analogwritetask.Stop();
                writer.WriteMultiSample(true, waveData);
            }
        }

        private void updAmplitude_ValueChanged(object sender, EventArgs e)
        {
            GenerateWaveform();
        }

        private void updDCOffset_ValueChanged(object sender, EventArgs e)
        {
            GenerateWaveform();
        }

        private void updDutyCycle_ValueChanged(object sender, EventArgs e)
        {
            GenerateWaveform();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (analogwritetask != null && !error)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    waveData[i] = 0;
                }
                if (arraySize > maxBufferSize)
                {
                    Array.Resize(ref waveData, maxBufferSize - 50);
                }
                analogwritetask.Stop();
                writer.WriteMultiSample(true, waveData);
                analogwritetask.Dispose();
            }
        }

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
