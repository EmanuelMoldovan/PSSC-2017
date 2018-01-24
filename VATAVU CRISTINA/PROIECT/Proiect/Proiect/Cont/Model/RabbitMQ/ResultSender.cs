using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont.Comenzi
{
    public class ResultSender
    {
        public static void Send(string serializedResult)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                //creaza o noua coada pe care sa se trimita
                //(daca nu exista deja)
                channel.QueueDeclare(queue: "result", //nume
                                durable: false,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);

                //encode message in variable body
                var body = Encoding.UTF8.GetBytes(serializedResult);

                //publish the massge on the queue
                channel.BasicPublish(exchange: "",
                                        routingKey: "result", //numele cozii
                                        basicProperties: null,
                                        body: body); //trimite mesajul prin body
            }
        }
    }
}

