using System;

namespace LiskovSubstituteFromTechEd.Entities
{
    public class OutOfFuelException : Exception
    {
        protected string _message;

        public override string Message
        {
            get { return _message; }
        }

        public OutOfFuelException(string message)
        {
            _message = message;

        }
    }
}
