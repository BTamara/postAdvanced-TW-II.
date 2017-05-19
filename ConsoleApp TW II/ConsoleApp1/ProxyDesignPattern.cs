using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern

//"Provide a surrogate or placeholder for another object to control access to it." 
{
    interface IPub
    {
        void DrinkBeer();
    }

    public class Pub : IPub
    {
        public void DrinkBeer()
        {
            Console.WriteLine("You are 18. Here is your beer");
            Console.WriteLine("* it is the real Pub, with very heavy tasks *");
        }
    }

    public class ProxyPub : IPub
    {
        private Hipster hipster;
        private IPub realPub;

        public ProxyPub(Hipster hipster)
        {
            this.hipster = hipster;
            realPub = new Pub();
        }

        void IPub.DrinkBeer()
        {
            Console.WriteLine("* First the proxyPub check *");
            if (hipster.Age <= 18)
            {
                Console.WriteLine("Sorry, you are under 18, we cannot serve you with alcohol");
                Console.WriteLine("* The proxy checked first so we shouldn't have to invite the realPub with heavy methods *");
            }
            else
                realPub.DrinkBeer();
        }
    }

    public class Hipster
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Hipster(int age)
        {
            this.age = age;
        }
    }
}
