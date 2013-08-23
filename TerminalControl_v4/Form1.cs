using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace TerminalControl_v4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

         private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sett = new SettingsForm(this);
            sett.Show();
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        //int i = 0;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //rtbRX.Clear();
            rtbRX.AppendText(serialPort1.ReadLine());
            //Console.WriteLine(i++);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = Properties.Settings.Default.PortName;
            serialPort1.BaudRate = Convert.ToInt32(Properties.Settings.Default.BoudRate);
        }

       
    }
}
