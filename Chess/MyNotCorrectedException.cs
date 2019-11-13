using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class MyNotCorrectedInputException : Exception
    {
       
     public MyNotCorrectedInputException(string message) : base(message)
            {
            }
            public MyNotCorrectedInputException()
            { }
        

    }
}
