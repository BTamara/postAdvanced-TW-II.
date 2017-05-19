using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface ITrafficLight
    {
        void ChangeStatus(TrafficLight light);
        void ActualStatus();
    }

    public class Green : ITrafficLight
    {
        public void ChangeStatus(TrafficLight light)
        {
            light.State = new Red();
        }

        public void ActualStatus()
        {
            Console.WriteLine("Green Light");
        }
    }

    public class Yellow : ITrafficLight
    {
        public void ChangeStatus(TrafficLight light)
        {
           
                light.State = new Green();
        }

        public void ActualStatus()
        {
            Console.WriteLine("Yellow Light");
        }
    }

    public class Red : ITrafficLight
    {
        public void ChangeStatus(TrafficLight light)
        {
            light.State = new Yellow();
        }

        public void ActualStatus()
        {
            Console.WriteLine("Red Light.");
        }
    }

    public class TrafficLight
    {
        public ITrafficLight State { get; set; }

        public void ChangeStatus()
        {
            State.ChangeStatus(this);
        }

        public void ActualStatus()
        {
            State.ActualStatus();
        }
    }
}
