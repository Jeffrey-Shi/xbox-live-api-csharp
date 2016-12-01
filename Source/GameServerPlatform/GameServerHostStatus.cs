using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.GameServerPlatform
{
    public enum GameServerHostStatus : int
    {
        Unknown = 0,
        Active = 1,
        Queued = 2,
        Aborted = 3,
        Error = 4,
    }

}