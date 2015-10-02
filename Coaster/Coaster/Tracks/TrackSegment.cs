using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coaster.Tracks
{
    public struct TrackSegment // https://github.com/kevinburke/rct/blob/master/tracks/segment.go
    {
        // Corresponds to the hex number of this element's order, eg 1 is flat,
	    // 2 is 25 deg up, etc.
	    public SegmentType Type;

	    // Computes the change in direction
	    //DirectionDelta DirectionDelta

	    // The starting slope
        public Degree InputDegree;
	    // The ending slope
        public Degree OutputDegree;

	    // Change in tile position. A positive number indicates after the track
	    // segment, we're that many tiles forward. A negative number indicates we
	    // moved backwards
        public int ForwardDelta;

	    // The total change in elevation
        public int ElevationDelta;

	    // How far we moved side to side. Negative numbers indicate the track
	    // turned left.
        public int SidewaysDelta;

	    // Starting bank
        public Bank StartingBank;
	    // the ending bank
        public Bank EndingBank;

        public override string ToString()
        {
            return Enum.GetName(typeof(SegmentType), this.Type).Replace("ELEM_", "");
        }
    }
}
