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

        public static Data Unmarshal(byte[] buf)
        {
            Data d = new Data();

            List<TrackElement> elements = new List<TrackElement>();
            for (int i = 0; i < buf.Length; i += 2)
            {
                TrackElement elem = TrackElement.Unmarshal((byte[])buf.GetValue(i, i + 1));
                if (elem.Segment.Type == SegmentType.ELEM_END_OF_RIDE)
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

            for (int i = 0; i < d.Elements.Length; i++)
            {
                byte[] bts = TrackElement.Marshal(d.Elements[i]);
                bts.CopyTo(buf, i * 2);
            }

            buf[buf.Length - 1] = 0xff; // track end

            return buf;
        }
    }
}
