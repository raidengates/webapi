using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Shared.Classes
{
    public enum NavigationFailReason
    {
        Unknown = -1,
        NoFail = 0,
        NotLoggedIn = 1,
        RoleNotAllowed
    }
}
