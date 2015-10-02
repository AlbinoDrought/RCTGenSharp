using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coaster.Bits;
using Coaster.Tracks;

namespace Coaster.TD6 // https://github.com/kevinburke/rct/blob/master/td6/egress.go
{
    public struct Egress
    {
        public bool Exit;
        public int Direction;
        public Int16 XOffset;
        public Int16 YOffset;

        // Get list of entrances/exits for a ride from raw data
        // Copied mostly from "Scenery Items" here:
        // http://freerct.github.io/RCTTechDepot-Archive/TD6.html
        public static Egress[] Unmarshal(byte[] buf)
        {
            List<Egress> egresses = new List<Egress>();

            for(int i = 0; i < buf.Length; i += 6)
            {
                if(buf[i] == (byte)SegmentType.ELEM_END_OF_RIDE) break; 

                int features = (int)buf[i + 1];
                Egress egr = new Egress()
                {
                    Exit = BitOp.On(features, 7),
                    Direction = features & 3,
                    XOffset = BitConverter.ToInt16(buf, i + 2),
                    YOffset = BitConverter.ToInt16(buf, i + 4),
                };
                egresses.Add(egr);
            }

            return egresses.ToArray();
        }

        public static byte[] Marshal(Egress egr)
        {
            // might need to 0-align?
            byte[] buf = new byte[6];
            int ftrBit = egr.Direction;
            ftrBit = BitOp.SetCond(ftrBit, 7, egr.Exit);
            buf[1] = (byte)ftrBit;

            BitConverter.GetBytes(egr.XOffset).CopyTo(buf, 2);
            BitConverter.GetBytes(egr.YOffset).CopyTo(buf, 4);
            
            return buf;
        }

        public static byte[] Marshal(params Egress[] egrs)
        {
            byte[] buf = new byte[6 * egrs.Length + 1];

            for(int i = 0; i < egrs.Length; i++)
            {
                byte[] marshalledEgr = Marshal(egrs[i]);
                marshalledEgr.CopyTo(buf, i * 6);
            }

            buf[buf.Length - 1] = 0xff;

            return buf;
        }
    }
}
