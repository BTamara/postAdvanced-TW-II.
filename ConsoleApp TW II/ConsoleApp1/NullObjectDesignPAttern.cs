using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern
{
    interface IFestival
    {
        void Welcome();
    }

    class Sziget : IFestival
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome in Sziget festival. You can buy your ticket here");
        }
    }

    class BalatonSound : IFestival
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome in BalatonSound festival. You can buy your ticket here");
        }
    }

    class NullFestival : IFestival
    {
        public void Welcome()
        {
            Console.WriteLine("This festival is under construction. You can buy your ticket later on here");
        }
    }
}
