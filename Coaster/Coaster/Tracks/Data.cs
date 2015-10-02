using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coaster.Tracks // https://github.com/kevinburke/rct/blob/master/tracks/track.go
{
    public struct Data
    {
        public TrackElement[] Elements;
        public int Clearance;
        public ClearanceDirection ClearanceDirection;
    }
}
