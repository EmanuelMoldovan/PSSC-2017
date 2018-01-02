
'''import pika
import time

connection = pika.BlockingConnection(pika.ConnectionParameters(
        host='localhost'))
channel = connection.channel()

channel.queue_declare(queue='task_queue', durable=True)
print(' [*] Waiting for messages. To exit press CTRL+C')

def callback(ch, method, properties, body):
    print("Partner: {}".format(body))
    time.sleep(body.count(b'.'))
    #print(" [x] Done")
    ch.basic_ack(delivery_tag = method.delivery_tag)

channel.basic_qos(prefetch_count=1)
channel.basic_consume(callback,
                      queue='task_queue')

channel.start_consuming()'''
import pika

connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))

channel = connection.channel()

def on_request(ch, method, props, body):
    received = body.decode("utf-8") 
    if received != "User disconnected!":
        print("partner: {}".format(body.decode("utf-8")))
        response = input("you: ")
        if response != "exit":
            ch.basic_publish(exchange='',
                             routing_key=props.reply_to,
                             properties=pika.BasicProperties(correlation_id = \
                                                                 props.correlation_id),
                             body=str(response))
            ch.basic_ack(delivery_tag = method.delivery_tag)

        else:
            ch.basic_publish(exchange='',
                             routing_key=props.reply_to,
                             properties=pika.BasicProperties(correlation_id = \
                                                                 props.correlation_id),
                             body=str("User disconnected!"))
            print("System: You disconnected!")
            ch.basic_ack(delivery_tag = method.delivery_tag)
            channel.stop_consuming()
    else:
        print("System: User disconnected")
        ch.basic_ack(delivery_tag = method.delivery_tag)
        channel.close()

channel.basic_qos(prefetch_count=1)
channel.basic_consume(on_request, queue='Queue_dd')

channel.start_consuming()