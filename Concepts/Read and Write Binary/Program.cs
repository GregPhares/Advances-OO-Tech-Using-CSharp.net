using System;
using System.IO;
/// <summary>
/// This program is designed to allow for insight into how C# reads and writes to temp files with binary
/// </summary>


namespace HW14
{
    class Program
    {
        //The Executable of the script
        static void Main(string[] args)
        {
            string BinaryFileName = Path.GetTempFileName();
            WriteBinaryData(BinaryFileName, "Neytiri", "Na'vi", 18, 112.0f);
            var tuple = ReadBinaryData(BinaryFileName);
            Console.WriteLine($"{tuple.Item1} speaks {tuple.Item2}, is {tuple.Item3} years old, and is {tuple.Item4} inches tall");
            File.Delete(BinaryFileName);
        }

        //This method will read the binary from the temp file, passing back a tuple
        public static (string, string, int, float) ReadBinaryData(string fileName)
        {
            using (BinaryReader read = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                return (read.ReadString(),read.ReadString(), read.ReadInt32(), read.ReadSingle());
            } 
        }

        //This method will write to a temp file using binary
        public static void WriteBinaryData(string BinaryFileName, string name, string language, int age, float heightInches)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(BinaryFileName, FileMode.Create)))
            {
                writer.Write(name);
                writer.Write(language);
                writer.Write(age);
                writer.Write(heightInches);
            }
        }
    }
}
