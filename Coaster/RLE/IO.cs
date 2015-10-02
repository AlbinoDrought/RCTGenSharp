using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE // https://github.com/kevinburke/rct/blob/master/rle/lib.go
{
    public static class IO
    {
        /// <summary>
        /// Reads bytes from FileStream, decodes them, and then returns them
        /// </summary>
        /// <param name="r">FileStream to read from</param>
        /// <returns>Unencoded ride bytes</returns>
        public static byte[] Read(FileStream r)
        {
            List<byte> decodedBytes = new List<byte>();

            while (r.Position < r.Length - 4) // - 4 to strip checksum
            {
                int b = r.ReadByte();

                if (b >= 0 && b <= 128)
                {
                    // pos, read next b bytes
                    for (int i = 0; i <= b; i++)
                    {
                        decodedBytes.Add((byte)r.ReadByte());
                    }
                }
                else
                {
                    // neg, repeat next byte (1 - b) times
                    byte repeatByte = (byte)r.ReadByte();
                    int repeatTimes = (byte)(1 - b);

                    for (int i = 0; i < repeatTimes; i++)
                    {
                        decodedBytes.Add(repeatByte);
                    }
                }
            }

            return decodedBytes.ToArray();
        }
        
        /// <summary>
        /// Encodes unencoded bytes and writes them to the FileStream
        /// </summary>
        /// <param name="w">FileStream to write to</param>
        /// <param name="ride">Unencoded bytes</param>
        public static void Write(FileStream w, byte[] ride)
        {
            byte[] encodedBytes = Encode(ride);
            w.Write(encodedBytes, 0, encodedBytes.Length);

            uint checksum = Checksum(encodedBytes);
            byte[] checksumBytes = BitConverter.GetBytes(checksum);

            w.Write(checksumBytes, 0, checksumBytes.Length);
            w.Flush();
        }

        /// <summary>
        /// Encodes unencoded bytes and returns them
        /// </summary>
        /// <param name="ride">Unencoded ride bytes</param>
        /// <returns>Encoded ride bytes</returns>
        public static byte[] Encode(byte[] ride)
        {
            if (ride.Length == 0 || ride.Length == 1) return ride;

            List<byte> encodedBytes = new List<byte>();
            int current = 0;

            while(current < ride.Length)
            {
                if(current < ride.Length - 2 && ride[current] == ride[current + 1])
                {
                    // read all duplicates to get count
                    // write count, write dupe byte
                    int duplicateCount = 2;

                    // TODO: Check logic
                    while(ride.Length > duplicateCount && duplicateCount <= 127 && ride[current] == ride[current + duplicateCount])
                    {
                        duplicateCount++;
                    }

                    encodedBytes.Add((byte)(-duplicateCount + 1));
                    encodedBytes.Add(ride[current]);
                    //w.Write(new byte[] { (byte)(-duplicateCount + 1), ride[current] }, current, 2);

                    current += duplicateCount;
                }
                else
                {
                    int count = 0;

                    while(current + count <= ride.Length - 1)
                    {
                        /*if(current + count == ride.Length - 1)
                        {
                            count++;
                            break;
                        }*/

                        if(current + count == ride.Length - 1 || ride[current + count] != ride[current + count + 1] && count <= 127)
                        {
                            count++;
                        }
                        else
                        {
                            // break on dupe or if reaching negative territory
                            break;
                        }
                    }

                    encodedBytes.Add((byte)(count - 1));
                    for (int i = 0; i < count; i++)
                    {
                        encodedBytes.Add(ride[current + i]);
                    }

                    current += count;
                }
            }

            byte[] encoded = encodedBytes.ToArray();
            //w.Write(encoded, 0, encoded.Length);

            return encoded;
        }

        /// <summary>
        /// Return checksum for use with encoded TD6 files (voodoo magic)
        /// </summary>
        /// <param name="ride">Encoded ride bytes</param>
        /// <returns></returns>
        public static uint Checksum(byte[] ride)
        {
            uint summation = 0;

            for (int i = 0; i < ride.Length; i++)
            {
                uint tmp = summation + (uint)ride[i];
                summation = (summation & 0xffffff00) | (tmp & 0x000000ff);
                uint highthree = (uint)(summation & (7 << 29));
                summation = summation << 3;
                summation |= highthree >> 29;
            }

            summation -= 120001;

            return summation;
        }
    }
}
