using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using VISAInstrument.Ulitity;
using VISAInstrument.Port;
using VISAInstrument.Extension;
using VISAInstrument.Properties;
using Ivi.Visa;
using NationalInstruments.Visa;
using System.Threading;
using System.Drawing;

namespace NIVISAtest000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] baudRate = { 256000, 128000, 115200, 57600, 56000, 43000, 38400, 28800, 19200, 9600, 4800, 2400, 1200, 600, 300, 110 };
        PortOperatorBase serialopBase;
        PortOperatorBase usbopBase;
        PortOperatorBase gpibopBase;
        bool isWritingError = false;
        Task t = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            baudRateCB.DataSource = baudRate;
            baudRateCB.SelectedIndex = 9;
            scanBtn.PerformClick();
        }
        #region Serial Port
        private void openSPbtn_Click(object sender, EventArgs e)
        {
            if (openSPbtn.Text == "Open")
            {
                bool hasAddress = false;
                bool hasException = false;
                string str = devicesCB.SelectedItem.ToString();
                Console.WriteLine("address:" + str);
                if (!str.Contains("ASRL"))
                {
                    printInfo("Select port ERROR!", Color.Red);
                    return;
                }
                try
                { 
                    
                    serialopBase = new RS232PortOperator(str,
                                           (int)baudRateCB.SelectedItem, 0, 0, 8);
                    hasAddress = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error1:"+ ex.ToString());
                    hasException = true;
                }
                if (!hasException)
                {
                    hasException = false;
                    serialopBase.Timeout = 5000;
                    try
                    {
                        serialopBase.Open();
                        openSPbtn.Text = "Close";
                        //EnableControl(false);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("error2:"+ex.ToString());
                        hasException = true;
                    }
                    
                }
                if (!hasException) {
                    printInfo("Open Serial port successful!", Color.Green);
                }
                else
                {
                    printInfo("Open Serial port fail!", Color.Red);
                }



            }
            else
            {
                bool hasException = false;
                try
                {
                    serialopBase.Close();
                }
                catch { hasException = true; }
                openSPbtn.Text = "Open";
                //EnableControl(true);
                if (!hasException)
                {
                    printInfo("Close Serial port successful!", Color.Green);
                }
                else
                {
                    printInfo("Close Serial port fail!", Color.Red);
                }
            }

            
        }

        private void writeSPbtn_Click(object sender, EventArgs e)
        {
            writeCMD(serialopBase);
        }
        private void writeCMD(PortOperatorBase opBase)
        {
            isWritingError = false;

            if (string.IsNullOrEmpty(commandTB.Text))
            {
                MessageBox.Show("Command is empty!");
                return;
            }
            string content = commandTB.Text;

            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                opBase.WriteLine(content);
                // cboCommand.AddItem(cboCommand.Text);
            }
            catch
            {
                content = $"写入命令\"{content}\"失败！";
            }
            listBox1.Items.Add($"[Time:{stopwatch.ElapsedMilliseconds}ms] Write: {content}");
        }
        private void readSPbtn_Click(object sender, EventArgs e)
        {
            readData(serialopBase);
        }
        private void readData(PortOperatorBase opBase)
        {
            string result;
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                result = opBase.ReadLine();
            }
            catch (IOTimeoutException)
            {
                result = "Time Out!";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            listBox1.Items.Add($"[Time:{stopwatch.ElapsedMilliseconds}ms] Read:  {result}");
        }
        #endregion
        #region USB Port
        private void openUSBbtn_Click(object sender, EventArgs e)
        {
            if (openUSBbtn.Text == "Open")
            {
                bool hasException = false;
                string str = devicesCB.SelectedItem.ToString();
                Console.WriteLine("address:" + str);
                if (!str.Contains("USB"))
                {
                    printInfo("Select port ERROR!", Color.Red);
                    return;
                }
                try
                {
                    usbopBase = new USBPortOperator(str);
                    // hasAddress = true;
                }
                catch
                {
                    hasException = true;
                }
                if (!hasException)
                {
                    hasException = false;
                    usbopBase.Timeout = 5000;
                    try
                    {
                        usbopBase.Open();
                        openUSBbtn.Text = "Close";
                        //EnableControl(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error2:" + ex.ToString());
                        hasException = true;
                    }

                }
                if (!hasException)
                {
                    printInfo("Open USB port successful!", Color.Green);
                }
                else
                {
                    printInfo("Open USB port fail!", Color.Red);
                }
            }
            else
            {
                bool hasException = false;
                try
                {
                    usbopBase.Close();
                }
                catch { hasException = true; }
                openUSBbtn.Text = "Open";
                //EnableControl(true);
                if (!hasException)
                {
                    printInfo("Close USB port successful!", Color.Green);
                }
                else
                {
                    printInfo("Close USB port fail!", Color.Red);
                }
            }
            
        }

        private void writeUSBbtn_Click(object sender, EventArgs e)
        {
            writeCMD(usbopBase);
        }

        private void readUSBbtn_Click(object sender, EventArgs e)
        {
            readData(usbopBase);
        }
        #endregion
        #region GPIB
        private void openGPIBbtn_Click(object sender, EventArgs e)
        {
            if (openGPIBbtn.Text == "Open")
            {
                bool hasException = false;
                string str = devicesCB.SelectedItem.ToString();
                Console.WriteLine("address:" + str);
                if (!str.Contains("GPIB"))
                {
                    printInfo("Select port ERROR!", Color.Red);
                    return;
                }
                try
                {
                    gpibopBase = new GPIBPortOperator(str);
                    // hasAddress = true;
                }
                catch
                {
                    hasException = true;
                }
                if (!hasException)
                {
                    hasException = false;
                    gpibopBase.Timeout = 5000;
                    try
                    {
                        gpibopBase.Open();
                        openGPIBbtn.Text = "Close";
                        //EnableControl(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error2:" + ex.ToString());
                        hasException = true;
                    }

                }
                if (!hasException)
                {
                    printInfo("Open GPIB port successful!", Color.Green);
                }
                else
                {
                    printInfo("Open GPIB port fail!", Color.Red);
                }
            }
            else
            {
                bool hasException = false;
                try
                {
                    gpibopBase.Close();
                }
                catch { hasException = true; }
                openGPIBbtn.Text = "Open";
                //EnableControl(true);
                if (!hasException)
                {
                    printInfo("Close GPIB port successful!", Color.Green);
                }
                else
                {
                    printInfo("Close GPIB port fail!", Color.Red);
                }
            }
        }

        private void writeGPIBbtn_Click(object sender, EventArgs e)
        {
            writeCMD(gpibopBase);
        }

        private void readGPIBbtn_Click(object sender, EventArgs e)
        {
            readData(gpibopBase);
        }
        #endregion
        private void scanBtn_Click(object sender, EventArgs e)
        {
            string title = Text;
            t = Task.Factory.StartNew(() =>
            {
                try
                {
                    //InvokeToForm(() => { btnRefresh.Enabled = false; btnOpen.Enabled = false; Text = title + Resources.LoadingRS232; });
                    List<string> devices = new List<string>();
                    string[] content1 = PortUltility.FindAddresses(PortType.RS232);
                    string[] content2 = PortUltility.FindRS232Type(content1);
                    List<string> list1 = new List<string>();
                    List<string> list2 = new List<string>();
                    for (int i = 0; i < content2.Length; i++)
                    {
                        if (content2[i].Contains("LPT")) continue;
                        list1.Add(content1[i]);
                        list2.Add(content2[i]);
                    }
                    content1 = list1.ToArray();  //ASRL1::INSR...
                    content2 = list2.ToArray(); //COM1...
                    devices = list1;

                    // InvokeToForm(() => devicesCB.ShowAndDisplay(content1, content2));
                    // InvokeToForm(() => { Text = title + Resources.LoadingUSB; });
                    content1 = PortUltility.FindAddresses(PortType.USB);
                    devices.AddRange(content1);
                    // InvokeToForm(() => cboUSB.ShowAndDisplay(content1));
                    // InvokeToForm(() => { Text = title + Resources.LoadingGPIB; });
                    content1 = PortUltility.FindAddresses(PortType.GPIB);
                    devices.AddRange(content1);
                    // InvokeToForm(() => cboGPIB.ShowAndDisplay(content1));
                    // InvokeToForm(() => { Text = title + Resources.LoadingLAN; });
                    content1 = PortUltility.FindAddresses(PortType.LAN);
                    devices.AddRange(content1);
                    string[] list = devices.ToArray();
                    InvokeToForm(() => devicesCB.ShowAndDisplay(list));
                    // InvokeToForm(() => { btnRefresh.Enabled = true; btnOpen.Enabled = true; Text = title; });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("exception:" + ex.ToString());
                }
                
            }).ContinueWith(x =>
            {
                if (x.IsFaulted)
                {
                    MessageBox.Show("Scan not completed! Error!!!");
                   // CancelDisplayForm = true;
                   // InvokeToForm(() => { tableLayoutPanel.Enabled = false; this.Text = Resources.RuntimeError; });
                }
            });
        }
        private void InvokeToForm(Action action)
        {
            try
            {
                this.Invoke(action);
            }
            catch { }
        }
        private void printInfo(string txt, Color col) {
            infoLB.BackColor = col;
            infoLB.Text = txt;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (openSPbtn.Text == "Close") serialopBase.Close();
            if (openUSBbtn.Text == "Close") usbopBase.Close();
            if (openGPIBbtn.Text == "Close") gpibopBase.Close();
        }
        
    }
}
