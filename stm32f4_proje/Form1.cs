using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace stm32f4_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] gorulen_portlar;
            gorulen_portlar = SerialPort.GetPortNames();
            
            foreach(string port in gorulen_portlar)
            {
                ComboBox_seri_port_isimleri.Items.Add(port);
                
            }

            ComboBox_seri_port_isimleri.SelectedIndex = 0;


            comboBox_baudrate.Items.Add("4800");
            comboBox_baudrate.Items.Add("9600");
            comboBox_baudrate.Items.Add("19200");
            comboBox_baudrate.Items.Add("38400");
            comboBox_baudrate.Items.Add("57600");
            comboBox_baudrate.Items.Add("115200");

        }
    }
}
