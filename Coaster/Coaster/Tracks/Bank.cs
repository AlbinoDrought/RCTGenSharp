using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coaster.Tracks // https://github.com/kevinburke/rct/blob/master/tracks/segment.go
{
    public enum Bank
    {
        TRACK_BANK_NONE = 1,
        TRACK_BANK_LEFT = 1 << 2,
        TRACK_BANK_RIGHT = 1 << 3,
        TRACK_BANK_UPSIDE_DOWN = 1 << 4
    }
}
