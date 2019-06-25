using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Shared.Classes
{
    public static class Extensions
    {
        public static int GetNextHighestMultiple(this int source, int multipicand)
        {
            int result = source;
            while ((result % multipicand) != 0)
            {
                result++;
            }
            return result;
        }

    }
}
