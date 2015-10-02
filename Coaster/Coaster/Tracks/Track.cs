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

        public static TrackElement UnmarshalElement(byte[] rawElement)
        {
            if(rawElement.Length != 2)
            {
                throw new Exception("Invalid length for element input");
            }

            // XXX hack for brakes
            if(rawElement[0] == 0xd8)
            {
                rawElement[0] = (byte)SegmentType.ELEM_BRAKES;
            }

            TrackElement te = new TrackElement();

            te.Segment = TrackSegmentMap[(SegmentType)rawElement[0]];
            if (te.Segment.Type == SegmentType.ELEM_END_OF_RIDE) return te;

            int q = (int)rawElement[1];
            
            te.ChainLift = BitOp.On(q, 7);
            te.InvertedTrack = BitOp.On(q, 6);
            te.Station = BitOp.On(q, 3);

#if DEBUG
            if(te.Station)
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

        public static byte[] MarshalElement(TrackElement e)
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

        public static Data Unmarshal(byte[] buf)
        {
            Data d = new Data();

            List<TrackElement> elements = new List<TrackElement>();
            for(int i = 0; i < buf.Length; i += 2)
            {
                TrackElement elem = UnmarshalElement((byte[])buf.GetValue(i, i + 1));
                if(elem.Segment.Type == SegmentType.ELEM_END_OF_RIDE)
                {
                    break;
                }

                elements.Add(elem);
            }

            // XXX where is this data actually stored?
	        d.Clearance = 2;
            d.ClearanceDirection = ClearanceDirection.CLEARANCE_ABOVE;

            return d;
        }

        public static byte[] Marshal(Data d)
        {
            byte[] buf = new byte[(2 * d.Elements.Length) + 1];

            for(int i = 0; i < d.Elements.Length; i++)
            {
                byte[] bts = MarshalElement(d.Elements[i]);
                bts.CopyTo(buf, i * 2);
            }

            buf[buf.Length - 1] = 0xff; // track end

            return buf;
        }
    }
}
