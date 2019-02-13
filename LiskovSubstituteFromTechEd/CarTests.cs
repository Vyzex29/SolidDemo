using System;
using LiskovSubstituteFromTechEd.Entities;
using NUnit.Framework;

namespace LiskovSubstituteFromTechEd
{
    [TestFixture]
    public class CarUnitTest
    {
        [Test]
        public void Make_sure_car_can_start()
        {
            var car = new Car(ConsoleColor.DarkCyan);
            //var car = new BrokenCar(Color.Aqua);          //Post condition Weakened
            //var car = new CrimeBossCar(Color.Aqua, true);   //Throws new type of exception
            try
            {
                car.StartEngine();
            }
            catch (OutOfFuelException)
            {
                Assert.Fail("Car is out of gas....");
            }

            Assert.IsTrue(car.IsEngineRunning);
        }

        [Test]
        public void Make_sure_engine_is_running_after_start()
        {
            var car = new Car(ConsoleColor.Cyan);
            //var car = new Prius(Color.Aqua);          // Changing invariants
            //var car = new StolenCar(Color.Aqua);      // Changing preconditions

            car.StartEngine();

            Assert.IsTrue(car.IsEngineRunning);
        }

        [Test]
        public void Make_sure_the_car_is_painted_correctly()
        {
            var car = new Car(ConsoleColor.Cyan);
            //var car = new PimpedCar(Color.Aqua);    // Violating history constraint
            //car.setTempreture(30);

            Assert.AreEqual(ConsoleColor.Cyan, car.Color);
        }
    }
}