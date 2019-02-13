﻿using System;

namespace LiskovSubstituteFromTechEd.Entities
{
    public class MetYourMakerException : Exception
    {
        protected string _message;

        public override string Message
        {
            get { return _message; }
        }

        public MetYourMakerException(string message)
        {
            _message = message;

        }
    }
}
