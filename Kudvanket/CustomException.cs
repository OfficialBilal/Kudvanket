using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class CustomException
    {
        public static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User Already Logged In");
            }
            catch(UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    [Serializable]
    class UserAlreadyLoggedInException : Exception 
    {
        public UserAlreadyLoggedInException() : base()
        {

        }
        public UserAlreadyLoggedInException(string message) : base(message)
        {

        }
        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
