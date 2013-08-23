using System;
using System.Windows.Forms;

namespace TerminalControl_v4
{
    public partial class SettingsForm : Form
    {
        private readonly MainForm _parentForm;

        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(MainForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            foreach (string item in System.IO.Ports.SerialPort.GetPortNames())
            {
                portBox.Items.Add(item);
                portBox.SelectedIndex = 0;
            }

            portBox.Text = Properties.Settings.Default.PortName;
            boudBox.Text = Convert.ToString(Properties.Settings.Default.BoudRate);
            dataBitsBox.Text = Convert.ToString(Properties.Settings.Default.DataBits);
            parityBox.Text = Convert.ToString(Properties.Settings.Default.Parity);
            stopBitsBox.Text = Convert.ToString(Properties.Settings.Default.StopBits);
        }

        private void boudBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parentForm.serialPort1.BaudRate = Convert.ToInt32(boudBox.Text);
            _parentForm.textBox1.Text = boudBox.Text;
        }

        private void portBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parentForm.serialPort1.PortName = portBox.Text;
            _parentForm.textBox2.Text = portBox.Text;
        }

        private void dataBitsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parentForm.serialPort1.DataBits = Convert.ToInt16(dataBitsBox.Text);

        }

        private void parityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //parentForm.serialPort1.Parity = parityBox.Text;

        }

        private void stopBitsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BoudRate = Convert.ToInt32(boudBox.Text);
            Properties.Settings.Default.PortName = portBox.Text;
            Properties.Settings.Default.DataBits = Convert.ToInt32(dataBitsBox.Text);
            //Properties.Settings.Default.Parity = parityBox.Text;
            Properties.Settings.Default.Save();
        }

        private void btnSettClose_Click(object sender, EventArgs e)
        {
            Hide();
        }



        
    }
}
