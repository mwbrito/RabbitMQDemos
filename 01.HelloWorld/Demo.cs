using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMQDemo
{
    class Demo
    {
        public void SetMensagem(string fila, string message)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: fila,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: fila,
                                     basicProperties: null,
                                     body: body);
            }
        }

        // metodo excessivamente complexo !
        public string GetMensagemV2(string fila)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };

            string message = "";
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: fila,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    message = Encoding.UTF8.GetString(body.ToArray());
                    Console.WriteLine(" [x] Recebido {0}", message);
                };
                channel.BasicConsume(queue: fila,
                                     autoAck: true,
                                     consumer: consumer);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("[enter] para Sair.");
                Console.ReadLine();
            }

            return message;
        }

        public string GetMensagem(string fila)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };

            string message = "";
            BasicGetResult data;

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: fila,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);
                data = channel.BasicGet(queue: fila, autoAck: true);
                message = System.Text.Encoding.UTF8.GetString(data.Body.ToArray());
            }

            return message;
        }
    }
}