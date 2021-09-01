using System;
using System.IO;

namespace BinaryReaderWriterDemo
{
    class BinaryReaderWriterOperations
    {
        public void WriteDefaultValue()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"D:\wizzie\DOT NET\BinarySerialization.txt", FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"D:\wizzie\DOT NET");
                writer.Write(10);
                writer.Write(true);
            }
        }
        public void DisplayValue()
        {
            float aspectRatio;
            string tempDirectory;
            int autoSaveTime;
            bool showStatusBar;

            if (File.Exists(@"D:\wizzie\DOT NET\BinarySerialization.txt"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(@"D:\wizzie\DOT NET\BinarySerialization.txt", FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                    autoSaveTime = reader.ReadInt32();
                    showStatusBar = reader.ReadBoolean();
                }

                Console.WriteLine("Aspect ratio set to: " + aspectRatio);
                Console.WriteLine("Temp directory is: " + tempDirectory);
                Console.WriteLine("Auto save time set to: " + autoSaveTime);
                Console.WriteLine("Show status bar: " + showStatusBar);
            }
        }
    }
    class BinaryReaderWriterEx
    {
        static void Main(string[] args)
        {
            BinaryReaderWriterOperations BRWO = new BinaryReaderWriterOperations();
            BRWO.WriteDefaultValue();
            BRWO.DisplayValue();
        }
    }
}
