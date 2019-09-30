using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        /// <summary>
        /// Client
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var superBuilder = new SuperCarBuilder();
            var notSuperBuilder = new NotSoSuperCarBuilder();
            var factory= new CarFactory();
            var builders = new List<CarBuilder>
            {
                superBuilder, notSuperBuilder
            };
            foreach (var bld in builders)
            {
                var c = factory.Build(bld);
                Console.WriteLine($"The car requested by {bld.GetType().Name}: " +
                                  $"\n------------------" +
                                  $"\n Horse power: {c.HorsePower}" +
                                  $"\n Impressive feature: {c.MostImpressiveFeature}"+ 
                                  $"\n Top Speed: {c.TopSpeedMPH} mph\n");
            }

            Console.ReadLine();
        }
    }


    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Car
    {
        public int TopSpeedMPH { get; set; }
        public int HorsePower { get; set; }
        public string MostImpressiveFeature { get; set; }
    }

    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    public abstract class CarBuilder
    {
        protected readonly Car _car = new Car();
        public abstract void SetHorsePower();
        public abstract void SetTopSpeed();
        public abstract void SetImpressiveFeature();

        public virtual Car GetCar()
        {
            return _car;
        }
    }

    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class CarFactory
    {
        public Car Build(CarBuilder builder)
        {
            builder.SetHorsePower();
            builder.SetTopSpeed();
            builder.SetImpressiveFeature();
            return builder.GetCar();
        }
    }

    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class NotSoSuperCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 120;
        }
        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 70;
        }
        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Has Air Conditioning";
        }
    }

    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    public class SuperCarBuilder : CarBuilder
    {

        public override void SetHorsePower()
        {
            _car.HorsePower = 1640;
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 600;
        }
        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Can Fly";
        }

    }
}
