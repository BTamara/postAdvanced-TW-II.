using DecoratorDesignPattern;
using FacadeDesignPattern;
using FactoryDesignPattern;
using IteratorDesignPattern;
using NullObjectDesignPattern;
using ProxyDesignPattern;
using StateDesignPattern;
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
            //TW week:
            Console.WriteLine("1-Factory method design pattern");
            Console.WriteLine("2-Singleton design pattern");
            Console.WriteLine("3-Facade design pattern");
            Console.WriteLine("4-Decorator design pattern");
            //SI WEEK
            Console.WriteLine("5-Prototype design pattern");
            Console.WriteLine("6-Iterator design pattern");
            Console.WriteLine("7-Proxy design pattern");
            Console.WriteLine("8-NullObject design pattern");
            Console.WriteLine("9-State design pattern");

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

        public void displayPrototype()
        {
            CloneMaker prototype = new CloneMaker();
            prototype.Age = 30;
            prototype.Name = "my name is Steve";
            Console.WriteLine("Hi " +  prototype.Name + " and I am " + prototype.Age + " years old.");
            CloneMaker clone = prototype.Clone() as CloneMaker;
            clone.Age = 15;
            clone.Name = "my name is Jane";
            Console.WriteLine("Hi " + clone.Name + " and I am " + clone.Age + " years old.");

            if (prototype == clone)
            {
                Console.WriteLine("it is the same object");
            }
            else
            {
                Console.WriteLine("it isn't the same object");
            }
        }

        public void displayIterator()
        {
            Collection collectionToIterate = new Collection();
            collectionToIterate[0] = new Item("One for sorrow,");
            collectionToIterate[1] = new Item("Two for joy,");
            collectionToIterate[2] = new Item("Three for a girl,");
            collectionToIterate[3] = new Item("Four for a boy,");
            collectionToIterate[4] = new Item("Five for silver,");
            collectionToIterate[5] = new Item("Six for gold,");
            collectionToIterate[6] = new Item("Seven for a secret,");
            collectionToIterate[7] = new Item("Never to be told!");
            collectionToIterate[8] = new Item("Eight for a wish,");
            collectionToIterate[9] = new Item("Nine for a kiss,");
            collectionToIterate[10] = new Item("Ten for a bird,");
            collectionToIterate[11] = new Item("You must not miss.");


            Iterator iterator = collectionToIterate.CreateIterator();

            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }
        }

        public void displayProxy()
        {
            IPub pub = new ProxyPub(new Hipster(16));
            pub.DrinkBeer();

            pub = new ProxyPub(new Hipster(25));
            pub.DrinkBeer();
        }

        public void displayNullObject()
        {
            IFestival sziget = new Sziget();
            sziget.Welcome();

            IFestival unknown = new NullFestival();
            unknown.Welcome();
        }

        public void displayState()
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.State = new Red();
            trafficLight.ActualStatus();
            trafficLight.ChangeStatus();
            trafficLight.ActualStatus();
            trafficLight.ChangeStatus();
            trafficLight.ActualStatus();

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
                    else if(menuNumber == "5")
                    {
                        myMenu.displayPrototype();
                    }
                    else if(menuNumber == "6")
                    {
                        myMenu.displayIterator();
                    }
                    else if (menuNumber == "7")
                    {
                        myMenu.displayProxy();
                    }
                    else if (menuNumber == "8")
                    {
                        myMenu.displayNullObject();
                    }
                    else if (menuNumber == "9")
                    {
                        myMenu.displayState();
                    }
                else
                    {
                    break;
                    }

            }
        }

    }
}
