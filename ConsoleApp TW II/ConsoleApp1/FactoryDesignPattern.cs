using System;



namespace FactoryDesignPattern
{
    public interface ICarFactory
    {
        string CarColor
        {
            get;
        }
        void GetCarModel();
    }
    class Audi : ICarFactory
    {
        public string CarColor
        {
            get { return "white"; }
        }

        public void GetCarModel()
        {
            Console.WriteLine("This is an Audi");
        }
    }
    class BMW : ICarFactory
    {
        public string CarColor
        {
            get { return "black"; }
        }
        public void GetCarModel()
        {
            Console.WriteLine("This is a BMW");
        }
    }

    class Mercedes : ICarFactory
    {
        public string CarColor
        {
            get { return "red"; }
        }
        public void GetCarModel()
        {
            Console.WriteLine("This is a Mercedes");
        }
    }
    class Suzuki : ICarFactory
    {
        public string CarColor
        {
            get { return "blue"; }
        }
        public void GetCarModel()
        {
            Console.WriteLine("This is a Suzuki");
        }
    }

    static class CarFactory
    {
        public static ICarFactory GetCarInstance(string Id)
        {
            switch (Id)
            {
                case "1":
                    return new Audi();
                case "2":
                    return new BMW();
                case "3":
                    return new Mercedes();
                case "4":
                    return new Suzuki();
                default:
                    return null;
            }
        }
    }
    
}