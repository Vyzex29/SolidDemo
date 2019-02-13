using System;
using System.Drawing;

namespace LiskovSubstituteFromTechEd.Entities
{
    public class Car
    {
        private bool _hasFuel = true;
        public bool IsEngineRunning { get; private set; }
        public ConsoleColor Color { get; protected set; }

        public Car(ConsoleColor color)
        {
            this.Color = color;
        }

        public virtual void StartEngine()
        {
            if (!_hasFuel)
                throw new OutOfFuelException("Cant start car without Fuel in tansk...");
            IsEngineRunning = true;

        }
        public virtual void StopEngine()
        {
            IsEngineRunning = false;
        }

    }
    public class BrokenCar : Car
    {
        public BrokenCar(ConsoleColor color) : base(color)
        {
        }

        public override void StartEngine()
        {
            throw new NotImplementedException();
        }
    }

    public class CrimeBossCar : Car
    {
        private readonly bool _boobyTrap;
        public CrimeBossCar(ConsoleColor color, bool boobyTrap) : base(color)
        {
            _boobyTrap = boobyTrap;
        }

        public override void StartEngine()
        {
            if (_boobyTrap)
                throw new MetYourMakerException("Boom!! You are dead!");
            base.StartEngine();
        }
    }

    public class Prius : Car
    {
        public Prius(ConsoleColor color) : base(color)
        {
        }

        public override void StartEngine()
        {
        }

        public override void StopEngine()
        {
        }
    }

    public class StolenCar : Car
    {
        private bool _ignitionWiresStripped;

        public StolenCar(ConsoleColor color) : base(color)
        {
        }

        public void StripIgnitionWire()
        {
            _ignitionWiresStripped = true;
        }

        public override void StartEngine()
        {
            if (!_ignitionWiresStripped)
                return;
            base.StartEngine();
        }
    }

    public class PimpedCar : Car
    {
        private readonly ConsoleColor _color;
        public PimpedCar(ConsoleColor color) : base(color)
        {
        }

        public void setTempreture(int temp)
        {
            if (temp < 25)
                this.Color = _color;
            else
                Color = ConsoleColor.DarkRed;
        }
    }
}
