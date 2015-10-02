using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coaster.Tracks // https://github.com/kevinburke/rct/blob/master/tracks/track.go
{
    // The amount of space each track piece needs above or below. XXX should this
    // go on the ride object?
    [Flags]
    public enum ClearanceDirection
    {
        CLEARANCE_ABOVE = 1,
        // For suspended coasters
        CLEARANCE_BELOW = 1 << 2
    }
}
