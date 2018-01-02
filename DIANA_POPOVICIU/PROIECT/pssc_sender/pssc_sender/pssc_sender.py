'''import pika
import sys
import time

connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))
channel = connection.channel()

channel.queue_declare(queue='task_queue1', durable=True)

def callback(ch, method, properties, body):
    print("Partner: {}".format(body))
    time.sleep(body.count(b'.'))
    #print(" [x] Done")
    ch.basic_ack(delivery_tag = method.delivery_tag)
channel.basic_qos(prefetch_count=1)
channel.basic_consume(callback,
                      queue='task_queue1')


message = input("You: ")



while message != "exit":
    channel.basic_publish(exchange='',
                          routing_key='task_queue',
                          body=message,
                          properties=pika.BasicProperties(
                             delivery_mode = 2, # make message persistent
                          ))
    while self.response is None:
            self.connection.process_data_events()
            print("Partner: {}".format(response))

    message =  input("You: ")
   
    
connection.close()'''

import pika
import uuid

class Client(object):
    def __init__(self):
        self.connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))

        self.channel = self.connection.channel()

        result = self.channel.queue_declare(exclusive=True)
        self.callback_queue = result.method.queue

        self.channel.basic_consume(self.on_response, no_ack=True,
                                   queue=self.callback_queue)

    def on_response(self, ch, method, props, body):
        if self.corr_id == props.correlation_id:
            self.response = body

    def call(self, message, wait=True):
        self.response = None
        self.corr_id = str(uuid.uuid4())
        self.channel.basic_publish(exchange='',
                                   routing_key='Queue_dd',
                                   properties=pika.BasicProperties(
                                         reply_to = self.callback_queue,
                                         correlation_id = self.corr_id,
                                         ),
                                   body=str(message))
        if wait is True:
            while self.response is None:
                self.connection.process_data_events()
            return self.response
        else:
            self.connection.close()
            return None


chat = Client()
message = ""
while message != "exit":
    message = input("you:")
    if message == "exit":
        print("System: You disconnected!")
        chat.call("User disconnected!", wait=False)
    else:
        response = chat.call(message)
        response = response.decode("utf-8")
        if response != "User disconnected!":
            print("partner: {}".format(response))
        else:
            print("System: User disconnected")
            message = "exit"
