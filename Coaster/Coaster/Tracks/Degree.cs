using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coaster.Tracks
{
    public enum Degree // https://github.com/kevinburke/rct/blob/master/tracks/segment.go
    {
        TRACK_NONE           = 0,
        TRACK_UP_25          = 1,
        TRACK_UP_60          = 4,
        TRACK_DOWN_25        = -1,
        TRACK_DOWN_60        = -4,
        TRACK_UP_90          = 10,
        TRACK_DOWN_90        = -10,
    }
}
