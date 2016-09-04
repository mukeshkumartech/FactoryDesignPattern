using System;

namespace FactoryDesignPattern
{
    public interface ICarSupplier
    {
        string CarColor
        {
            get;
        }
        void GetCarModel();
    }
    class Honda : ICarSupplier
    {
        public string CarColor
        {
            get { return "RED"; }
        }

        public void GetCarModel()
        {
            Console.WriteLine("Honda Car Model is Honda 2014");
        }
    }
    class BMW : ICarSupplier
    {
        public string CarColor
        {
            get { return "WHITE"; }
        }
        public void GetCarModel()
        {
            Console.WriteLine("BMW Car Model is BMW 2000");
        }
    }

    class Nano : ICarSupplier
    {
        public string CarColor
        {
            get { return "YELLOW"; }
        }
        public void GetCarModel()
        {
            Console.WriteLine("Nano Car Model is Nano 2016");
        }
    }
    class Suzuki : ICarSupplier
    {
        public string CarColor
        {
            get { return "Orange"; }
        }
        public void GetCarModel()
        {
            Console.WriteLine("Suzuki Car Model is Suzuki 2006");
        }
    }

    static class CarFactory
    {
        public static ICarSupplier GetCarInstance(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new Honda();
                case 1:
                    return new BMW();
                case 2:
                    return new Nano();
                case 3:
                    return new Suzuki();
                default:
                    return null;
            }
        }
    }
    class ClientProgram
    {
        static void Main(string[] args)
        {
            
            ICarSupplier objCarSupplier = CarFactory.GetCarInstance(3);
            objCarSupplier.GetCarModel();
            Console.WriteLine("And Coloar is " + objCarSupplier.CarColor);

            Console.ReadLine();
        }

    }
}
