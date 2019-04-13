using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        private MessageServer server;
        private Timer poller;
        public Form1()
        {
            InitializeComponent();
            ServicePointManager
    .ServerCertificateValidationCallback +=
    (sender, cert, chain, sslPolicyErrors) => true;
            server = new MessageServer();
            poller = new Timer();
            UpdateMessageList();
            poller.Interval = 1000;
            poller.Tick += (s, e) => UpdateMessageList();
            poller.Start();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            var text = textBoxMessage.Text;
            server.SendMessage(text);
        }

        private void UpdateMessageList()
        {
            var messages = server.GetMessages();
            listBoxMessages.Items.Clear();
            listBoxMessages.Items.AddRange(messages.ToArray());
        }
    }
}
