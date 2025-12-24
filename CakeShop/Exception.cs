using System;
namespace CakeShop
{
    class InvalidFlavourException : Exception
    {
        public InvalidFlavourException() : base()
        {
            
        }
        public InvalidFlavourException(string msg) : base(msg)
        {
            
        }
    }
    class InvalidQuantityException: Exception
    {
        public InvalidQuantityException():base()
        {
            
        }
        public InvalidQuantityException(string msg) : base(msg)
        {
            
        }
    }
}