using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Cont.Model.DTOs;
using Newtonsoft.Json;
using Modele.Cont;
using Modele.Generic;
using Cont.RabbitMQ;

namespace Cont.Comenzi
{
    public class CmdReceiver
    {
        public static void Receive()
        {

            String serializedResult = "";
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel()) //deschide un canal de comunicare
            {
                //creare coada, daca nu exist a deja
                channel.QueueDeclare(queue: "command", //numele cozii, acelasi cu coada care pe care se transmite in sender
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
                    var body = ea.Body;
                    message = Encoding.UTF8.GetString(body);
                    SerializedCommandDTO cmd = JsonConvert.DeserializeObject<SerializedCommandDTO>(message);
                    if(cmd.TipTranzactie.Equals("transfera"))
                    {
                        //preia datele din comanda (deserializate)
                        double sum = cmd.suma;
                        ContDTO source = cmd.conturi[0];
                        ContDTO destination = cmd.conturi[1];

                        //proceseaza comanda si obtine prin asta un raspuns serializat (rezultatul)
                        String res = ProcesatorComanda.Proceseaza(sum, source, destination);

                        serializedResult = res;
                       
                    }
                    else if (cmd.TipTranzactie.Equals("depunere"))
                    {
                        double sum = cmd.suma;
                        ContDTO source = cmd.conturi[0];

                        String res = ProcesatorComanda.Proceseaza(sum, source);

                        serializedResult = res;
                    }
                };
                
                //Asteapta sa se primeasca mesajul
                 channel.BasicConsume(queue: "command",
                                     autoAck: true,
                                     consumer: consumer);

                do
                {
                    //asteapta sa se proceseze comanda apoi trimite raspunsul
                    if (!serializedResult.Equals(""))
                    {
                        //trimite rezultatul pe coada de raspuns
                        ResultSender.Send(serializedResult);
                    }

                } while (serializedResult.Equals(""));
                
            }
    }
    }
}
