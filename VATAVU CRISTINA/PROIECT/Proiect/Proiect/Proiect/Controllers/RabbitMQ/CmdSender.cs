using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using Cont.Comenzi;

namespace Proiect.Models
{
    public class CmdSender
    {

        public static void Send(string serializedCommand)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                //creaza o noua coada pe care sa se trimita
                //(daca nu exista deja)
                channel.QueueDeclare(queue: "command", //nume
                                durable: false,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);

                //encode message in variable body
                var body = Encoding.UTF8.GetBytes(serializedCommand);

                //publish the massge on the queue
                channel.BasicPublish(exchange: "",
                                        routingKey: "command", //numele cozii
                                        basicProperties: null,
                                        body: body); //trimite mesajul prin body
                //call the recei
                CmdReceiver.Receive();
            }
        }
        }
}