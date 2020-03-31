using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Common
{
    public static class ObjectValidator
    {
        public static void CheckForNullObject(object obj, string errorMessage="")
        {
            if(obj==null)
            {
                throw new NullReferenceException(errorMessage);
            }
        }
    }
}
