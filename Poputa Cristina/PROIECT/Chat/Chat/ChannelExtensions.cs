using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public static class ChannelExtensions
    {
        // http://lostechies.com/derekgreer/2012/05/29/rabbitmq-for-windows-headers-exchanges/
        public static void StartConsume(this IModel channel, string queueName, Action<IModel, DefaultBasicConsumer, BasicDeliverEventArgs> callback)
        {
            QueueingBasicConsumer consumer = new QueueingBasicConsumer(channel);
            channel.BasicConsume(queueName, true, consumer);

            while (true)
            {
                try
                {
                    var eventArgs = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                    callback(channel, consumer, eventArgs);
                }
                catch (EndOfStreamException)
                {
                    // The consumer was cancelled, the model closed, or the connection went away.
                    break;
                }
            }
        }

        ////hat tip: http://stackoverflow.com/questions/2367718/c-automating-the-invokerequired-code-pattern
        public static void InvokeIfRequired(this Control control, MethodInvoker action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }
        public static void ScrollToEnd(this MetroFramework.Controls.MetroTextBox textbox)
        {
            textbox.Select(textbox.Text.Length - 1, 0);
        }
    }
}
