using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coaster.Bits;

namespace Coaster.Tracks // https://github.com/kevinburke/rct/blob/master/tracks/track.go
{
    public static class Track
    {
        public static Dictionary<SegmentType, TrackSegment> TrackSegmentMap;

        static Track()
        {
            initializeMap();
        }

        private static void initializeMap()
        {
            TrackSegmentMap = new Dictionary<SegmentType, TrackSegment>();
            TrackSegmentMap = TrackSegmentMapGenerator.GenerateSegmentMap();

            
        }
    }
}
