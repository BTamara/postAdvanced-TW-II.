using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PrototypeDesignPattern
    {
        /*This pattern involves implementing a prototype interface which tells to create a clone of the current object.
         * This pattern is used when creation of object directly is costly.
         * For example, an object is to be created after a costly database operation. 
         * We can cache the object, returns its clone on next request 
         * and update the database as and when needed thus reducing database calls.*/
    }
    public abstract class Prototype
    {

        public int Age { set; get; }
        public String Name { set; get; }

        public abstract Prototype Clone();
    }

    public class CloneMaker : Prototype
    {

        public override Prototype Clone()
        {
            return this.MemberwiseClone() as Prototype;
        }
    }
}
