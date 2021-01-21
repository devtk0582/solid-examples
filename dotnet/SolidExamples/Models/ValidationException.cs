using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.Models
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }
}
