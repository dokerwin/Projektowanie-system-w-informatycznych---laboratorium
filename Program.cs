using System;


// to use the SinglTone i do not recomend because it is like global variable but hidden in class  



namespace SinglTone
{



    class Singleton
    {

        private static Singleton _pointer = null;

        private Singleton()
        {
        }

        public static Singleton getPointerToSinleTone
        {
            get
            {

                if (_pointer == null)
                {
                    _pointer = new Singleton();
                }

                return _pointer;
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getPointerToSinleTone;
            Singleton s2 = Singleton.getPointerToSinleTone;

            // s1 and s2 are equals

            if (Object.ReferenceEquals(s1, s2))
            {
                Console.WriteLine("Singleton is working");
            }
            else
            {

                Console.WriteLine("Singleton does not work");
            }
        }
    }
}
