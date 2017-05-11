using DecoratorDesignPattern;
using FacadeDesignPattern;
using FactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SingletonDesignPattern.SingletonDesignPattern;

namespace ConsoleApp1
{
    class MyMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("\nHere are some design patter:");
            Console.WriteLine("Please select a number:");
            Console.WriteLine("1-Factory method design pattern");
            Console.WriteLine("2-Singleton design pattern");
            Console.WriteLine("3-Facade design pattern");
            Console.WriteLine("4-Decorator design pattern");

        }

        public void displayFactory()
        {
            Console.WriteLine("Choose a brand:");
            Console.WriteLine("1-Audi");
            Console.WriteLine("2-BMW");
            Console.WriteLine("3-Mercedes");
            Console.WriteLine("4-Suzuki");
            ICarFactory objCarSupplier = CarFactory.GetCarInstance(Console.ReadLine());
            Console.WriteLine("Your car is ready");
            objCarSupplier.GetCarModel();
            Console.WriteLine("The car color is: " + objCarSupplier.CarColor);
        }

        public void displaySingleton()
        {
            SingleObject obj1 = SingleObject.Instance;
            SingleObject obj2 = SingleObject.Instance;

            if (obj1 == obj2)
            {
                Console.WriteLine("obj1 and obj2 are the same objects");
            }
            else
            {
                Console.WriteLine("someting went wrong");
            }
        }

        public void displayFacade()
        {

            Facade shapeBuilder = new Facade();

            shapeBuilder.DrawCircle();
            shapeBuilder.DrawTriangle();
            shapeBuilder.DrawPentagon();

        }

        public void displayDecorator()
        {
            var Icecreams = new List<Icecream>();

            var IceBoring = new BoringIcecream();
            var ChocolateSauceIcecream = new ChocolateSauce(IceBoring);
            var SprinkleIcecream = new Sprinkle(IceBoring);
            var WhippedCreamIcecream = new WhippedCream(IceBoring);
            var WhippedCreamSprinkleIcecream = new WhippedCream(SprinkleIcecream);

            Icecreams.Add(IceBoring);
            Icecreams.Add(ChocolateSauceIcecream);
            Icecreams.Add(SprinkleIcecream);
            Icecreams.Add(WhippedCreamIcecream);
            Icecreams.Add(WhippedCreamSprinkleIcecream);

            foreach (Icecream icecream in Icecreams)
            {
                Console.WriteLine($"{icecream.GetName()} Price : Ft{icecream.GetPrice()}");
            }

        }
    }
        
    class MainMenu
    {
    
            static void Main(string[] args)
            {
                MyMenu myMenu = new MyMenu();

                while (true)
                {
                    myMenu.DisplayMenu();
                    string menuNumber = Console.ReadLine();

                    if (menuNumber == "1")
                    {
                        myMenu.displayFactory();
                    }
                    else if(menuNumber == "2")
                    {
                    myMenu.displaySingleton();
                    }
                    else if(menuNumber == "3")
                    {
                        myMenu.displayFacade();
                    }
                    else if (menuNumber == "4")
                    {
                        myMenu.displayDecorator();
                    }
                else
                    {
                    break;
                    }

            }
        }

    }
}
