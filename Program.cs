using System;

namespace Facade
{
    public class Order
    {
        protected Factory factory;
        protected Delivery delivery;
        protected Consulatant consulatnt;

        public Order(Factory factor, Delivery deliv, Consulatant cons)
        {
            this.factory = factor;
            this.delivery = deliv;
            this.consulatnt = cons;
        }

     
        public string Operation()
        {
            string result = "The process of making order:\n";
            result += this.consulatnt.GetOrderFromClient();
            result += this.factory.CreateProduct();
            result += this.delivery.DeliveryToClient();

            return result;
        }
    }




    public class Consulatant
    {
        public string GetOrderFromClient()
        {
            return "The order was received by consultant from client \n";
        }
    }



    public class Delivery
    {
        public string DeliveryToClient()
        {
            return "The product was delivered\n";
        }
    }


    public class Factory
    {
        public string CreateProduct()
        {
            return "The product was created\n";
        }
    }


    class Client
    {
      
        public static void ClientCode(Order order)
        {
            Console.Write(order.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Factory factory = new Factory();
            Delivery  delivery  = new Delivery();
            Consulatant consulatant = new Consulatant();
            Order order = new Order(factory, delivery, consulatant);
            Client.ClientCode(order);
        }
    }
}
