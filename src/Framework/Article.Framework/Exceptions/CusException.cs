using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Framework.Exceptions
{
    public abstract class CusException : Exception
    {
        public CusException(string message) : base(message)
        {

        }
        public abstract int ErrorCode { get; }


    }
}
