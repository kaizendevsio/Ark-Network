﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ark.Entities.Enums
{
    [Flags]
    public enum PackageStatus
    {
        Unactivated = 0,
        PendingActivation = 1,
        Activated = 2,
        Revoked = 3,
        Invalid = 4,
        Expired = 5,
        Cancelled = 6
    }
}
