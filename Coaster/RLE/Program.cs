using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE // https://github.com/kevinburke/rct/tree/master/rle
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 2)
            {
                printHelp();
                return;
            }

            switch(args[0])
            {
                case "e":
                case "encode":
                    encode(getFileName(args));
                    break;

                case "d":
                case "dec":
                case "decode":
                    decode(getFileName(args));
                    break;

#if DEBUG
                case "test":
                    test();
                    Console.ReadLine();
                    break;

                case "test2":
                    test2();
                    Console.ReadLine();
                    break;

                case "test3":
                    test3();
                    Console.ReadLine();
                    break;
#endif

                default:
                    printHelp();
                    break;
            }
        }

        private static string getFileName(string[] args)
        {
            return string.Join(" ", args, 1, args.Length - 1);
        }

        private static void encode(string filename)
        {
            byte[] fileBytes = File.ReadAllBytes(filename);

            using(FileStream w = new FileStream(filename + ".TD6", FileMode.OpenOrCreate))
            {
                IO.Write(w, fileBytes);
            }
        }

        private static void decode(string filename)
        {
            byte[] readBytes;

            using(FileStream r = new FileStream(filename, FileMode.Open))
            {
                readBytes = IO.Read(r);
            }

            File.WriteAllBytes(filename + ".txt", readBytes);
        }

#if DEBUG
        private static void test()
        {
            using(FileStream w = new FileStream("test.txt", FileMode.OpenOrCreate))
            {
                string testString = "Goood job!";
                byte[] testBytes = getBytes(testString);
                IO.Write(w, testBytes);
            }          
        }

        private static void test2()
        {
            //IO.Reader r = new IO.Reader(new FileStream("test.txt", FileMode.Open));
            using(FileStream r = new FileStream("test.txt", FileMode.Open))
            {
                byte[] unencoded = IO.Read(r);
                Console.WriteLine(getString(unencoded));
            }
        }

        private static void test3()
        {
            string testString = "Little licorice lollipops.";
            string readString = "";

            using (FileStream w = new FileStream("test3.txt", FileMode.OpenOrCreate))
            {
                byte[] testBytes = getBytes(testString);
                IO.Write(w, testBytes);
            }

            using (FileStream r = new FileStream("test3.txt", FileMode.Open))
            {
                byte[] unencoded = IO.Read(r);
                readString = getString(unencoded);
            }

            Console.WriteLine(testString);
            Console.WriteLine(readString);

            Console.WriteLine((testString == readString) ? "Equal" : "Not Equal!");
        }

        static byte[] getBytes(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }

        static string getString(byte[] bytes)
        {
            return Encoding.ASCII.GetString(bytes);
        }
#endif

        private static void printHelp()
        {
            Console.WriteLine("RLE TD6 Encoder/Decoder Usage:");
            Console.WriteLine("RLE.exe <encode/decode> <filename>");
        }
    }
}
