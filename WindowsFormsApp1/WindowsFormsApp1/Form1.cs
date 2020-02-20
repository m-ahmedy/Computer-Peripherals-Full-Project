using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidSharp.Utility;
using HidSharp;

namespace WindowsFormsApp1
{
    public partial class ControlGUI : Form
    {
        static DeviceList list = DeviceList.Local;
        static HidDevice[] hidDeviceList = list.GetHidDevices().ToArray();

        static HidDevice hidDevice;
        static HidStream hidStream;

        public ControlGUI()
        {
            InitializeComponent();
            
        }

        private void ControlGUI_Load(object sender, EventArgs e)
        {
            HidSharpDiagnostics.EnableTracing = true;
            HidSharpDiagnostics.PerformStrictChecks = true;

            checkIfConnected();
            list.Changed += list_Changed;
            
        }

        private void list_Changed(object sender, EventArgs e)
        {
            Console.WriteLine("Device list changed.");
            hidDeviceList = list.GetHidDevices().ToArray();
            checkIfConnected();
        }
        private void checkIfConnected()
        {
            if (hidDeviceList.Length > 0)
            {
                foreach (HidDevice dev in hidDeviceList)    
                {
                    //Console.WriteLine(dev.GetManufacturer() + ':' + dev.GetProductName());

                    if (dev.GetProductName() == "MasterPIC" && dev.GetManufacturer() == "AhmedyCorp")
                    {
                        Console.WriteLine("found");
                        hidStatusLabel.Text = "Connected to MasterPIC";
                        hidDevice = dev;
                        EnableComponents(true);
                        break;
                    }



                    Console.WriteLine("not found");
                    hidStatusLabel.Text = "Disconnected";
                    EnableComponents(false);
                    hidDevice = null;

                }
            }
            else
            {
                Console.WriteLine("not found");
                hidStatusLabel.Text = "Disconnected";
                EnableComponents(false);
                hidDevice = null;
            }
        }

        delegate void EnableComponentsCallback(bool state);

        private void EnableComponents(bool state)
        {

            try
            {
                if (TemperatureLabel.InvokeRequired && HumidityLabel.InvokeRequired && PirLabel.InvokeRequired)
                {
                    EnableComponentsCallback d = new EnableComponentsCallback(EnableComponents);
                    Invoke(d, new object[] { state });
                }
                else
                {
                    if (state == false)
                    {
                        TemperatureLabel.Text = HumidityLabel.Text = PirLabel.Text = "None";
                    }

                    ServoMotorSend.Enabled = ServoAngle.Enabled = state;
                    StepperMotorSend.Enabled = StepperDirection.Enabled = StepperSteps.Enabled = StepperAngle.Enabled = state;
                    DcMotorSend.Enabled = DcMotorPower.Enabled = DcMotorDirection.Enabled = state;

                }
            }
            catch (Exception e) { }

        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if(hidDevice != null)
            {
                try
                {
                    byte[] buff = new byte[65];
                    Console.WriteLine("Writing to device");
                    hidStream = hidDevice.Open();
                    hidStream.ReadTimeout = 10000;
                    hidStream.Write(new byte[] { 0, (byte)'g', (byte)'a' });
                    hidStream.BeginRead(buff, 0, 65, (ar) => { UpdateGUI(buff); }, null);
                }
                catch (Exception ex) { }

                
            }
        }

        delegate void UpdateGUICallback(byte[] buff);

        private void UpdateGUI(byte[] buff)
        {
            try
            {
                if (TemperatureLabel.InvokeRequired && HumidityLabel.InvokeRequired && PirLabel.InvokeRequired)
                {
                    UpdateGUICallback d = new UpdateGUICallback(UpdateGUI);
                    Invoke(d, new object[] { buff });
                }
                else
                {
                    TemperatureLabel.Text = buff[1] + " ˚C";
                    HumidityLabel.Text = buff[2] + "%";
                    PirLabel.Text = (buff[3] == 1) ? "Near" : "Far";
                }

            }
            catch (Exception e) { }
            
        }
        
        

        private void DcMotorSend_Click(object sender, EventArgs e)
        {
            byte directionValue = (byte)((DcMotorDirection.Text == "Clockwise") ? 1 : 2);
            byte powerValue = (byte)(byte.Parse(DcMotorPower.Text) * 255 / 100);
            Console.WriteLine(powerValue.ToString());
            Console.WriteLine(directionValue.ToString());

            hidStream.Write(new byte[] { 0, (byte)'d', (byte)'c', powerValue, directionValue });
        }

        private void ServoMotorSend_Click(object sender, EventArgs e)
        {
            byte angleValue = (byte)(byte.Parse(ServoAngle.Text) / 45);
            Console.WriteLine(angleValue.ToString());

            hidStream.Write(new byte[] { 0, (byte)'s', (byte)'m', angleValue });
        }

        private void StepperMotorSend_Click(object sender, EventArgs e)
        {
            byte multiplierValue = (byte)(StepperAngle.Value);
            byte directionValue = (byte)((StepperDirection.Text == "Clockwise") ? 0x01 : 0x02);
            byte stepsValue = byte.Parse(StepperSteps.Text);


            Console.WriteLine(multiplierValue.ToString());

            hidStream.Write(new byte[] { 0, (byte)'s', (byte)'t', multiplierValue, stepsValue, directionValue });
        }

        private void StepperSteps_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(StepperSteps.Text, out parsedValue))
            {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.Show("This is number only field!", StepperSteps);
                StepperSteps.ResetText();
                return;
            }
        }
    }
}
