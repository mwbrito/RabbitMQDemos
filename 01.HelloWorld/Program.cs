using System;

namespace RabbitMQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();

            Console.WriteLine("Comecando\n");

            Console.WriteLine("Enviando mensagem\n");
            demo.SetMensagem("FilaTeste", "Minha primeira mensagem");

            Console.WriteLine("Recebendo mensagem");
            Console.WriteLine("Mensagem recebida: " + demo.GetMensagem("FilaTeste"));

            Console.WriteLine("\nFinish");
        }
    }
}
