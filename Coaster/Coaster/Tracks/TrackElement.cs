using Coaster.Bits;
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

        public static TrackElement Unmarshal(byte[] rawElement)
        {
            if (rawElement.Length != 2)
            {
                throw new Exception("Invalid length for element input");
            }

            // XXX hack for brakes
            if (rawElement[0] == 0xd8)
            {
                rawElement[0] = (byte)SegmentType.ELEM_BRAKES;
            }

            TrackElement te = new TrackElement();

            te.Segment = Track.TrackSegmentMap[(SegmentType)rawElement[0]];
            if (te.Segment.Type == SegmentType.ELEM_END_OF_RIDE) return te;

            int q = (int)rawElement[1];

            te.ChainLift = BitOp.On(q, 7);
            te.InvertedTrack = BitOp.On(q, 6);
            te.Station = BitOp.On(q, 3);

#if DEBUG
            if (te.Station)
            {
                Console.WriteLine("found station piece");
                Console.WriteLine(te.Segment);
            }
#endif

            te.StationNumber = q & 3;

            te.BoostMagnitude = (float)(q & 15) * (float)7.6;
            te.Rotation = (q & 15) * 45 - 180;

            return te;
        }

        public static byte[] Marshal(TrackElement e)
        {
            byte[] buf = new byte[2];
            buf[0] = (byte)e.Segment.Type;
            int featureBit = 0;
            featureBit = BitOp.SetCond(featureBit, 7, e.ChainLift);
            featureBit = BitOp.SetCond(featureBit, 6, e.InvertedTrack);
            featureBit = BitOp.SetCond(featureBit, 3, e.Station);

            if (e.Segment.Type == SegmentType.ELEM_END_STATION || e.Segment.Type == SegmentType.ELEM_BEGIN_STATION || e.Segment.Type == SegmentType.ELEM_MIDDLE_STATION)
            {
                // Set the station bit
                featureBit |= e.StationNumber;
            }

            // XXX booster?
            if (e.Segment.Type == SegmentType.ELEM_BRAKES || e.Segment.Type == SegmentType.ELEM_BLOCK_BRAKES)
            {
                float bm = (float)(e.BoostMagnitude / 7.6);
                featureBit |= (int)bm;
            }
            else
            {
                // 2nd bit seems to be set in most cases.
                featureBit |= 1 << 2;
            }
            // XXX, rotation for multi dimensional coasters
            buf[1] = (byte)featureBit;

            return buf;
        }
    }
}
