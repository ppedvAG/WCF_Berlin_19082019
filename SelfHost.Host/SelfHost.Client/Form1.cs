using SelfHost.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfHost.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var cf = new ChannelFactory<IWetterService>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:1"));


            var channel = cf.CreateChannel();

            label1.Text = $"TCP Es sind {channel.GetTemperatur("Bort")}°C";

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            var cf = new ChannelFactory<IWetterService>(new BasicHttpBinding(), new EndpointAddress("http://localhost:3"));


            var channel = cf.CreateChannel();

            label1.Text = $"BASIC Es sind {channel.GetTemperatur("Bort")}°C";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var cf = new ChannelFactory<IWetterService>(new WSHttpBinding(), new EndpointAddress("http://localhost:4"));


            var channel = cf.CreateChannel();

            label1.Text = $"WS Es sind {channel.GetTemperatur("Bort")}°C";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var cf = new ChannelFactory<IWetterService>(new NetNamedPipeBinding(), new EndpointAddress("net.pipe://localhost"));


            var channel = cf.CreateChannel();

            label1.Text = $"IPC Es sind {channel.GetTemperatur("Bort")}°C";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var cf = new ChannelFactory<IWetterService>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:1"));


            var channel = cf.CreateChannel();

            try
            {
                label1.Text = $"TCP Es sind {channel.GetTemperatur("")}°C";
            }
            catch (FaultException<OrtErrorInfo> oei)
            {
                MessageBox.Show($"Fehler: {oei.Message}\n{oei.Detail.Info}");
            }
        }
    }
}
