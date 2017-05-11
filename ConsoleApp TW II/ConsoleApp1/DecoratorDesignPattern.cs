using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    //Attach additional responsibilities to an object dynamically.
    //Decorators provide a flexible alternative to subclassing for extending functionality
    public abstract class Icecream
    {
        protected string Name = "some name";
        protected decimal Price = 0.00m;

        public virtual string GetName()
        {
            return Name;
        }
        public virtual decimal GetPrice()
        {
            return Price;
        }
    }

    public class BoringIcecream : Icecream
    {
        public BoringIcecream()
        {
            Name = "Icecream";
            Price = 250.00m;
        }
    }

    public abstract class Decorator : Icecream
    {
        Icecream icecream = null;

        public Decorator(Icecream icecream)
        {
            this.icecream = icecream;
        }

        public override string GetName()
        {
            return $"{icecream.GetName()}, {Name}";
        }

        public override decimal GetPrice()
        {
            return icecream.GetPrice() + Price;
        }
    }

    public class ChocolateSauce : Decorator
    {
        public ChocolateSauce(Icecream icecream)
            : base(icecream)
        {
            Name = "chocolate sauce";
            Price = 100.00m;
        }
    }

    public class Sprinkle : Decorator
    {
        public Sprinkle(Icecream icecream)
            : base(icecream)
        {
            Name = "sprinkle cookie";
            Price = 50.00m;
        }
    }

    public class WhippedCream : Decorator
    {
        public WhippedCream(Icecream icecream)
            : base(icecream)
        {
            Name = "whipped Cream";
            Price = 150.00m;
        }
    }
}
