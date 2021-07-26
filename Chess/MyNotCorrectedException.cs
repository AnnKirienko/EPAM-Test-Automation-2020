using System;

namespace Chess
{
    class MyNotCorrectedInputException : Exception
    {
        public MyNotCorrectedInputException(string message) : base(message)
        { }
        public MyNotCorrectedInputException()
        { }
        
    }
}
