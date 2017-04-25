//==================================================================================================
// Title        : Making Connections On A Switch
// Description  : Use this example to learn how to connect and disconnect channels on a NI-Switch device.
//==================================================================================================
using System;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using NationalInstruments;
using NationalInstruments.ModularInstruments.NISwitch;
using NationalInstruments.ModularInstruments.SystemServices.DeviceServices;

namespace NationalInstruments.Examples.MakingConnectionsOnASwitch
{

    public partial class MainForm : Form
    {
        NISwitch switchSession;
        PrecisionTimeSpan maxTime = new PrecisionTimeSpan(5);

        private System.Threading.Timer relayTimer;
        private System.Threading.TimerCallback relayCallback;

        static public string[] StatesText = System.IO.File.ReadAllLines(@"H:\cs\relay.txt");
        private int n = 0;
        private int i; private int j;
        private int whichState;
        private string[] pins = { "c0", "c1", "c2", "c3", "c4", "c5" };

        private struct state
        {
            public bool[] whichToActivate;
            public int SwitchTime;
        }
        private state[] States = new state[StatesText.Length];

        public MainForm()
        {

            foreach (string line in StatesText)
            {
                ReadText(line);
            }

            foreach (state st in States)
            { Debug.WriteLine(st.SwitchTime); }

            InitializeComponent();
            LoadSwitchDeviceNames();
            LoadTopology();

            // relayCallback = new System.Threading.TimerCallback(this.Default_Click);
            // relayTimer = new System.Threading.Timer(relayCallback, null, 100, System.Threading.Timeout.Infinite);
        }

        private void ReadText(string line)
        {
            States[n].whichToActivate = new bool[pins.Length];
            for (j = 0; j < pins.Length; j++)
            {
                Debug.WriteLine(Convert.ToInt16(line.Substring(j, 1)));
                if (Convert.ToInt16(line.Substring(j, 1)) == 1)
                { States[n].whichToActivate[j] = true; }
            }
            States[n].SwitchTime = Convert.ToInt32(line.Substring(7, 3)) * 10;

            n++;
        }

        #region UI Initial Value Config Section
        private void LoadTopology()
        {
            Type myType = typeof(SwitchDeviceTopology);
            PropertyInfo[] properties = myType.GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                topologyNameComboBox.Items.Add(prop.GetValue(myType, null).ToString());
            }
            topologyNameComboBox.SelectedIndex = 0;
        }
        private void LoadSwitchDeviceNames()
        {
            ModularInstrumentsSystem modularInstrumentsSystem = new ModularInstrumentsSystem("NI-SWITCH");
            foreach (DeviceInfo device in modularInstrumentsSystem.DeviceCollection)
            {
                resourceNameComboBox.Items.Add(device.Name);
            }
            if (modularInstrumentsSystem.DeviceCollection.Count > 0)
            {
                resourceNameComboBox.SelectedIndex = 0;
            }
        }
        #endregion UI Initial Value Config Section
        #region Program Properties
        private string ResourceName
        {
            get
            {
                return this.resourceNameComboBox.Text;
            }
        }

        private string TopologyName
        {
            get
            {
                return this.topologyNameComboBox.SelectedItem.ToString();
            }
        }
        private string Channel1
        {
            get
            {
                return this.channel1TextBox.Text;
            }
        }
        private string Channel2
        {
            get
            {
                return this.channel2TextBox.Text;
            }
        }
        private string Channel3
        {
            get
            {
                return this.channel3TextBox.Text;
            }
        }
        private string Channel4
        {
            get
            {
                return this.channel4TextBox.Text;
            }
        }
        #endregion Program Properties

        #region FormEvents
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseSession();
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            ChangeControlState(false);

            try
            {
                CloseSession();

                //Open session to the switch module and sets topology
                InitializeSwitchSession();
                //Connect channel1 and channel2.
                //switchSession.Path.DisconnectAll();
                Reset();
                //List<string> pathList = new List<string> ();
                //switchSession.Path.SetPath(pathList);


                // Wait for any relay to activate and debounce.
                switchSession.Path.WaitForDebounce(maxTime);

                whichState = 1;
                relayCallback = new System.Threading.TimerCallback(SwitchState);
                relayTimer = new System.Threading.Timer(relayCallback, null, 1500, System.Threading.Timeout.Infinite);

            }
            catch (System.Exception ex)
            {
                ShowError(ex.Message);
            }
            finally
            {
                ChangeControlState(true);
                //Close session to switch module.
                //CloseSession();
            }
        }
        private void Reset()
        {
            switchSession.Path.DisconnectAll();
            switchSession.Path.Connect("c0", "r0");
            switchSession.Path.Connect("c1", "r0");
            switchSession.Path.Connect("c2", "r0");
            switchSession.Path.Connect("c3", "r0");
            switchSession.Path.Connect("c4", "r0");
            switchSession.Path.Connect("c5", "r0");
        }
        public void SwitchState(object o)
        {
            Reset();
            switch (whichState)
            {
                case 1:
                    for (i = 0; i < pins.Length; i++)
                    {
                        if (States[0].whichToActivate[i])
                        {
                            switchSession.Path.Connect(pins[i], "r1");
                            switchSession.Path.Disconnect(pins[i], "r0");
                        }
                    }
                    whichState = 2;
                    relayTimer.Change(States[0].SwitchTime, System.Threading.Timeout.Infinite);
                    break;
                case 2:
                    for (i = 0; i < pins.Length; i++)
                    {
                        if (States[1].whichToActivate[i])
                        {
                            switchSession.Path.Connect(pins[i], "r1");
                            switchSession.Path.Disconnect(pins[i], "r0");
                        }
                    }
                    whichState = 3;
                    relayTimer.Change(States[1].SwitchTime, System.Threading.Timeout.Infinite);
                    break;
                case 3:
                    for (i = 0; i < pins.Length; i++)
                    {
                        if (States[2].whichToActivate[i])
                        {
                            switchSession.Path.Connect(pins[i], "r1");
                            switchSession.Path.Disconnect(pins[i], "r0");
                        }
                    }
                    whichState = 4;
                    relayTimer.Change(States[2].SwitchTime, System.Threading.Timeout.Infinite);
                    break;
                case 4:
                    for (i = 0; i < pins.Length; i++)
                    {
                        if (States[3].whichToActivate[i])
                        {
                            switchSession.Path.Connect(pins[i], "r1");
                            switchSession.Path.Disconnect(pins[i], "r0");
                        }
                    }
                    whichState = 5;
                    relayTimer.Change(States[3].SwitchTime, System.Threading.Timeout.Infinite);
                    break;
                case 5:
                    for (i = 0; i < pins.Length; i++)
                    {
                        if (States[4].whichToActivate[i])
                        {
                            switchSession.Path.Connect(pins[i], "r1");
                            switchSession.Path.Disconnect(pins[i], "r0");
                        }
                    }
                    whichState = 6;
                    relayTimer.Change(States[4].SwitchTime, System.Threading.Timeout.Infinite);
                    break;
                case 6:
                    for (i = 0; i < pins.Length; i++)
                    {
                        if (States[5].whichToActivate[i])
                        {
                            switchSession.Path.Connect(pins[i], "r1");
                            switchSession.Path.Disconnect(pins[i], "r0");
                        }
                    }
                    whichState = 7;
                    relayTimer.Change(States[5].SwitchTime, System.Threading.Timeout.Infinite);
                    break;
                case 7:
                    Reset();
                    relayTimer.Dispose();
                    break;
            }
        }


        #endregion FormEvents
        #region Program Functions
        private void ChangeControlState(bool isEnabled)
        {
            this.connectButton.Enabled = isEnabled;
            this.resourceNameComboBox.Enabled = isEnabled;
            this.topologyNameComboBox.Enabled = isEnabled;
            this.channel1TextBox.Enabled = isEnabled;
            this.channel2TextBox.Enabled = isEnabled;
            this.channel3TextBox.Enabled = isEnabled;
            this.channel4TextBox.Enabled = isEnabled;
        }

        private static void ShowError(string message)
        {
            if (string.IsNullOrEmpty(message))
                message = "Unexpected Error";
            MessageBox.Show(message, "Error"); ;
        }
        private void InitializeSwitchSession()
        {
            switchSession = new NISwitch(ResourceName, TopologyName, false, true);
            switchSession.DriverOperation.Warning += new System.EventHandler<SwitchWarningEventArgs>(DriverOperationWarning);
        }
        private void DriverOperationWarning(object sender, SwitchWarningEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Warning");
        }
        private void CloseSession()
        {
            if (switchSession != null)
            {
                try
                {
                    switchSession.Close();
                    switchSession = null;
                }
                catch (System.Exception ex)
                {
                    ShowError("Unable to Close Session, Reset the device.\n" + "Error : " + ex.Message);
                    Application.Exit();
                }
            }
        }

        #endregion Program Functions

        private void Default_Click(object sender, EventArgs e)
        {
            ChangeControlState(false);
            try
            {
                CloseSession();

                //Open session to the switch module and sets topology
                InitializeSwitchSession();
                //Connect channel1 and channel2.    
                switchSession.Path.DisconnectAll();
                switchSession.Path.Connect("c0", "r0");
                switchSession.Path.Connect("c1", "r0");
                switchSession.Path.Connect("c2", "r0");
                switchSession.Path.Connect("c3", "r0");
                switchSession.Path.Connect("c4", "r0");
                switchSession.Path.Connect("c5", "r0");
                // Wait for any relay to activate and debounce.
                switchSession.Path.WaitForDebounce(maxTime);

            }
            catch (System.Exception ex)
            {
                ShowError(ex.Message);
            }
            finally
            {
                ChangeControlState(true);
                //Close session to switch module.
                //CloseSession();
            }
        }
    }
}