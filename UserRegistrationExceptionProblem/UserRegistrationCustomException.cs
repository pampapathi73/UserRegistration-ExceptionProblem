using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationExceptionProblem 
{
   public class UserRegistrationCustomException : Exception
    {
       public enum ExceptionsType
       {
        Invalid_MESSAGE,   
       }
       public ExceptionsType type;
      public UserRegistrationCustomException(ExceptionsType Type, string message) : base(message)
      {
        this.type = Type;
      }
    }
}
