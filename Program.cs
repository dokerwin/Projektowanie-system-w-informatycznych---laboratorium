using System;

namespace _36350Adapter
{ 

    public interface ITarget
    {
        int GetRequest();
    }

    class Adaptee
    {
        public double GetSpecificRequest()
        {
            return 3.14;
        }
    }

  
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public int GetRequest()
        {
            int a = (int)_adaptee.GetSpecificRequest();
            return a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            Console.WriteLine("Class adaptee returns double : " + adaptee.GetSpecificRequest());
            Console.WriteLine("By adapter i have converted double to int : "+ target.GetRequest());
       
            
        }
    }
}

