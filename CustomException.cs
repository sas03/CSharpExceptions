using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CustomException : Exception
    {
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public CustomException(string message) : base(message)
        {
            Message = message;
            DateTime = DateTime.Now;
        }
    }
}
