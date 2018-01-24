using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Threading;
using System.IO;

namespace Chat
{
    public partial class Chat : MetroForm
    {
        string exchangeName = "chat";
         string clientId = Guid.NewGuid().ToString();
        IConnection connection = null;
        IModel channelSend = null;
        IModel channelReceive = null;
        Thread receivingThread = null;

        public Chat()
        {
            InitializeComponent();

            //SetUp
            sendButton.Enabled = false;
            msgBox.Enabled = false;
            
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest",
                VirtualHost = "/"
            };

            connection = connectionFactory.CreateConnection();
            channelSend = connection.CreateModel();
            channelSend.ExchangeDeclare(exchangeName, ExchangeType.Fanout, false, true, null);

            channelReceive = connection.CreateModel();
            channelReceive.QueueDeclare(clientId, false, false, true, null);
            channelReceive.QueueBind(clientId, exchangeName, "");

            receivingThread = new Thread(() => channelReceive.StartConsume(clientId, MessageHandler));
            receivingThread.Name = "ReceivingThread";
            receivingThread.Start();
            msgBox.Focus();
        }

        public void MessageHandler(IModel channel, DefaultBasicConsumer consumer, BasicDeliverEventArgs eventArgs)
        {
            string message = Encoding.UTF8.GetString(eventArgs.Body) + "\r\n";

            chatBox.InvokeIfRequired(() =>
            {
                chatBox.Text += message;
                chatBox.ScrollToEnd();
            });
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (channelSend.IsOpen) channelSend.Close();
            if (channelReceive.IsOpen) channelReceive.Close();
            if (connection.IsOpen) connection.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string input = metroLabel2.Text + " \u003A " + msgBox.Text;
            byte[] message = Encoding.UTF8.GetBytes(input);
            channelSend.BasicPublish(exchangeName, "", null, message);
            msgBox.Text = string.Empty;
            msgBox.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            chatBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            sendButton.Enabled = true;
            msgBox.Enabled = true;
            addButton.Visible = false;
            metroTextBox1.Visible = false;
            metroLabel3.Visible = false;
            metroLabel2.Text = metroTextBox1.Text;
        }

        private void newChatButton_Click(object sender, EventArgs e)
        {
            Chat f = new Chat();
            f.Show();
        }

       
    }
    
}
