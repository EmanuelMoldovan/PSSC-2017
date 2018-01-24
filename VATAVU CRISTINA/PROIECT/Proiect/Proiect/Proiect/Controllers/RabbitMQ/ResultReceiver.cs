using Cont.Model.DTOs;
using Modele.Cont;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Proiect.Controllers.RabbitMQ
{
    public class ResultReceiver
    {

        public static SerializedResultDTO Receive()
        {
            SerializedResultDTO Result=null;
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel()) //deschide un canal de comunicare
            {
                //creare coada, daca nu exist a deja
                channel.QueueDeclare(queue: "result", //numele cozii, acelasi cu coada care pe care se transmite in sender
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                //creare obiect consumer care va primi mesajul de pe canalul de comunicare
                var consumer = new EventingBasicConsumer(channel);
                String message = ""; //declare string in care se va prelua mesajul 
                                     // dupa ca va fi decodat

                //ce sa se intample cand s-a primit mesajul
                consumer.Received += (model, ea) =>
                {
                    //ia mesajul si il trimite inapoi la MVC
                    var body = ea.Body;
                    message = Encoding.UTF8.GetString(body);
                    SerializedResultDTO res = JsonConvert.DeserializeObject<SerializedResultDTO>(message);
                    Result = res;
                };
                //Asteapta sa se primeasca mesajul
                channel.BasicConsume(queue: "result",
                                    autoAck: true,
                                    consumer: consumer);

                do
                {
                    //asteapta sa se proceseze comanda apoi trimite raspunsul
                    if (Result != null)
                    {
                        //trimite rezultatul pe coada de raspuns
                        return Result;
                    }

                } while (Result == null);

                return Result;


            }
        }
    }
}