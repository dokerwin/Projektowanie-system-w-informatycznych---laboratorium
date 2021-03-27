using System;

namespace FactoryMethod
{


    abstract class Furniture

    {
    }



    class Chair : Furniture

    {
    }



    class ArmChair : Furniture

    {
    }


    abstract class CreatorFurniture

    {
        public abstract Furniture FactoryMethod();
    }


    class ChairCreator : CreatorFurniture

    {
        public override Furniture FactoryMethod()
        {
            return new Chair();
        }
    }

    class ArmChairCreator : CreatorFurniture

    {
        public override Furniture FactoryMethod()
        {
            return new ArmChair();
        }
    }




    class MainApp

    {
   
        static void Main()
        {
          

            CreatorFurniture[] creators = new CreatorFurniture[2];

            creators[0] = new ChairCreator();
            creators[1] = new ArmChairCreator();


            foreach (CreatorFurniture creator in creators)
            {
                Furniture furniture  = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  furniture.GetType().Name);
            }

  

            Console.ReadKey();
        }
    }



}
