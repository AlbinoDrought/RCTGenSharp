using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coaster.Tracks // https://github.com/kevinburke/rct/blob/master/tracks/track.go
{
    // An Element containts a single track segment and some metadata about the
    // track segment - whether it is a station piece, or has a chain lift.
    public struct TrackElement
    {
        // XXX, add color schemes
        public TrackSegment Segment;
        public bool ChainLift;
        public bool InvertedTrack;
        public bool Station;
        public int StationNumber;

        // bits 3, 2, 1 and 0 are a magnitude value (0..15) for brake and booster
        // track segments. The value obtained from these four bits is multiplied
        // by 7.6 km/hr = 4.5 mph.
        //
        // We store the value in km/h
        public float BoostMagnitude;

        // For RCT2 "Multi Dimensional Coaster", these four bits specify the amount
        // of rotation.
        public int Rotation;

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.Segment.Type.ToString(), Enum.GetName(typeof(SegmentType), this.Segment.Type));
        }
    }
}
